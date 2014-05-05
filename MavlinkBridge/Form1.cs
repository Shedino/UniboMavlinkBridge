using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Net.Sockets;
using System.Net;
using MavLink;

namespace MavlinkBridge
{
    public partial class Form1 : Form
    {
        private const string EOL = "\r\n";

        private UdpClient _sourceUDP = null;
        private UdpClient _destinationUDP = null;

        private SerialPort _sourceSerial = null;
        private SerialPort _destinationSerial = null;

        private bool _commActive = false;
        IPEndPoint sep = null;

        //MAVLink.MavlinkParse mav = null;
        Mavlink mav = null;


        private int _rcvOpti = 0;
        private int _rcvPars = 0;
        private int _rcvRefs = 0;
        private int _rcvJoy = 0;
        byte seqOpti = 0;
        byte seqPars = 0;
        byte seqRefs = 0;
        byte seqJoy = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _disconnetcBtn.Enabled = true;
            _connectBtn.Enabled = false;

            tbDebug.Text = "Trying to connect..."+EOL;
            _commActive = true;

            //mav = new MAVLink.MavlinkParse();
            mav = new Mavlink();

            try
            {
                //Source
                if (rbSourceUDP.Checked) //UDP
                {
                    //Enable udp readings
                    string utxt = tbSourceUdp.Text;
                    string[] spl = utxt.Split(':');
                    sep = new IPEndPoint(IPAddress.Any, int.Parse(spl[1]));
                    _sourceUDP = new UdpClient(sep);

                    ConnectSourceUDP();
                }
                else if (rbSourceSerial.Checked) //SERIALE
                {
                    //Parse serial string
                    string stxt = tbSourceSerial.Text;
                    string[] spl = stxt.Split(':');
                    _sourceSerial = new SerialPort(spl[0], int.Parse(spl[1]));
                    _sourceSerial.DataReceived += new SerialDataReceivedEventHandler(_sourceSerial_DataReceived);
                    _sourceSerial.Open();
                }

                //Destination
                if (rbDestinationUDP.Checked) //UDP
                {
                    //Enable udp readings
                    string utxt = tbDestUdp.Text;
                    string[] spl = utxt.Split(':');
                    _destinationUDP = new UdpClient(spl[0], int.Parse(spl[1]));
                }
                else if (rbDestinationSerial.Checked) //SERIALE
                {
                    //Parse serial string
                    string stxt = tbDestSerial.Text;
                    string[] spl = stxt.Split(':');
                    _destinationSerial = new SerialPort(spl[0], int.Parse(spl[1]));
                    _destinationSerial.Open();
                }
                tbDebug.Text = "Done." + EOL;
            }
            catch (Exception ex)
            {
                tbDebug.Text = "Error during connection!" + EOL;
                tbDebug.Text += ex.Message + EOL + ex.StackTrace;
                _disconnetcBtn.Enabled = false;
                _connectBtn.Enabled = true;
            }

        }

        void _sourceSerial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ConnectSourceUDP()
        {
            UdpState s = new UdpState();
            s.e = sep;
            s.u = _sourceUDP;
            _sourceUDP.BeginReceive(new AsyncCallback(ReceiveCallback), s);
        }

        private void _disconnetcBtn_Click(object sender, EventArgs e)
        {
            _commActive = false;
            _disconnetcBtn.Enabled = false;
            _connectBtn.Enabled = true;
            //Disconnetti tutte le porte (sia sorgenti che destinazione)
            if (_sourceUDP != null)
            {
                //_sourceUDP.EndReceive();
                _sourceUDP.Close();
            }
            if (_sourceSerial != null)
            {
                _sourceSerial.Close();
            }
            if (_destinationUDP != null)
            {
                _destinationUDP.Close();
            }
            if (_destinationSerial != null)
            {
                _destinationSerial.Close();
            }

            tbDebug.Text = "Disconnected.";
        }



        public void ReceiveCallback(IAsyncResult ar)
        {
            UdpClient u = (UdpClient)((UdpState)(ar.AsyncState)).u;
            IPEndPoint e = (IPEndPoint)((UdpState)(ar.AsyncState)).e;

            if (u != null)
            {
                Byte[] receiveBytes = u.EndReceive(ar, ref e);
                string receiveString = Encoding.ASCII.GetString(receiveBytes);

                //Console.WriteLine("Received: {0}", receiveString);

                string[] ppstr = receiveString.Split('S');
                foreach (string packstr in ppstr)
                {
                    if (packstr.Length > 1)
                    {
                        //Parsa la stringa e prepara messaggio x invio
                        string[] pspl = packstr.Trim().Split(' ');

                        int type = 0;
                        int.TryParse(pspl[1], out type);
                        //switch in base al tipo!
                        byte[] toSend = new byte[255];
                        int offset = 0;
                        int size = 0;
                        switch (type)
                        {
                            case 1:
                                //Optitrack
                                Msg_vicon_position_estimate opti = new Msg_vicon_position_estimate();
                                //MAVLink.mavlink_vicon_position_estimate_t opti = new MAVLink.mavlink_vicon_position_estimate_t();
                                _rcvOpti++;
                                opti.x = int.Parse(pspl[2]) / 1000.0f;
                                opti.y = int.Parse(pspl[3]) / 1000.0f;
                                opti.z = int.Parse(pspl[4]) / 1000.0f;
                                opti.roll = 0f;
                                opti.pitch = 0f;
                                opti.yaw = 0f;
                                opti.usec = ulong.Parse(pspl[10]) * 100;          //from matlab is sent 1e+4, we convert to usec which is 1e+6
                                //toSend = .
                                //toSend = mav.GenerateMAVLinkPacket(MAVLink.MAVLINK_MSG_ID.VICON_POSITION_ESTIMATE, opti);
                                //size = MavLinkSerializer.Serialize_VICON_POSITION_ESTIMATE(opti, toSend, ref offset);
                                MavlinkPacket mpopt = new MavlinkPacket();
                                mpopt.Message = opti;
                                mpopt.ComponentId = 0;
                                mpopt.SequenceNumber = ++seqOpti;
                                mpopt.SystemId = 0;
                                mpopt.TimeStamp = DateTime.Now;
                                toSend = mav.Send(mpopt);
                                break;
                            case 5:
                                Msg_unibo_parameters pars = new Msg_unibo_parameters();
                                //AVLink.mavlink_unibo_parameters_t pars = new MAVLink.mavlink_unibo_parameters_t();
                                _rcvPars++;
                                pars.Offset_T = float.Parse(pspl[2]) / 1000.0f;
                                pars.lat_mode = float.Parse(pspl[3]) / 1000.0f;
                                pars.delta = float.Parse(pspl[4]) / 1000.0f;
                                pars.K1 = float.Parse(pspl[5]) / 1000.0f;
                                pars.L1 = float.Parse(pspl[6]) / 1000.0f;
                                pars.Ixy = float.Parse(pspl[7]) / 1000.0f;
                                pars.K2 = float.Parse(pspl[8]) / 1000.0f;
                                pars.L2 = float.Parse(pspl[9]) / 1000.0f;
                                pars.Iz = float.Parse(pspl[10]) / 1000.0f;
                                pars.KpAttX = float.Parse(pspl[11]) / 1000.0f;
                                pars.KpAttY = float.Parse(pspl[12]) / 1000.0f;
                                pars.KpAttZ = float.Parse(pspl[13]) / 1000.0f;
                                pars.KdAttX = float.Parse(pspl[14]) / 1000.0f;
                                pars.KdAttY = float.Parse(pspl[15]) / 1000.0f;
                                pars.KdAttZ = float.Parse(pspl[16]) / 1000.0f;
                                pars.KiAttX = float.Parse(pspl[17]) / 1000.0f;
                                pars.KiAttY = float.Parse(pspl[18]) / 1000.0f;
                                pars.KiAttZ = float.Parse(pspl[19]) / 1000.0f;
                                pars.GE = float.Parse(pspl[20]) / 1000.0f;
                                pars.epsilon = float.Parse(pspl[21]) / 1000.0f;
                                pars.XY_Multiplier = float.Parse(pspl[22]) / 1000.0f;
                                pars.offset_x = float.Parse(pspl[23]) / 1000.0f;
                                pars.offset_y = float.Parse(pspl[24]) / 1000.0f;
                                pars.offset_z = float.Parse(pspl[25]) / 1000.0f;
                                //toSend = mav.GenerateMAVLinkPacket(MAVLink.MAVLINK_MSG_ID.UNIBO_PARAMETERS, pars);
                                //size = MavLinkSerializer.Serialize_UNIBO_PARAMETERS(pars, toSend, ref offset);
                                MavlinkPacket mppar = new MavlinkPacket();
                                mppar.Message = pars;
                                mppar.ComponentId = 0;
                                mppar.SequenceNumber = ++seqPars;
                                mppar.SystemId = 0;
                                mppar.TimeStamp = DateTime.Now;
                                toSend = mav.Send(mppar);
                                break;
                            case 7:
                                Msg_unibo_references refs = new Msg_unibo_references();
                                //MAVLink.mavlink_unibo_references_t refs = new MAVLink.mavlink_unibo_references_t();
                                _rcvRefs++;
                                refs.p_refX = float.Parse(pspl[2]) / 1000.0f;
                                refs.p_refY = float.Parse(pspl[3]) / 1000.0f;
                                refs.p_refZ = float.Parse(pspl[4]) / 1000.0f;
                                refs.dot_p_refX = float.Parse(pspl[5]) / 1000.0f;
                                refs.dot_p_refY = float.Parse(pspl[6]) / 1000.0f;
                                refs.dot_p_refZ = float.Parse(pspl[7]) / 1000.0f;
                                refs.dot2_p_refX = float.Parse(pspl[8]) / 1000.0f;
                                refs.dot2_p_refY = float.Parse(pspl[9]) / 1000.0f;
                                refs.dot2_p_refZ = float.Parse(pspl[10]) / 1000.0f;
                                refs.psi_ref = float.Parse(pspl[11]) / 1000.0f;
                                refs.dot_psi_ref = float.Parse(pspl[12]) / 1000.0f;
                                refs.dot2_psi_ref = float.Parse(pspl[13]) / 1000.0f;
                                refs.q = float.Parse(pspl[14]) / 1000.0f;
                                refs.buttons = UInt32.Parse(pspl[15]);
                                refs.Tstamp = Int32.Parse(pspl[16]);
                                //toSend = mav.GenerateMAVLinkPacket(MAVLink.MAVLINK_MSG_ID.UNIBO_REFERENCES, refs);
                                //size = MavLinkSerializer.Serialize_UNIBO_REFERENCES(refs, toSend, ref offset);
                                MavlinkPacket mp = new MavlinkPacket();
                                mp.Message = refs;
                                mp.ComponentId = 0;
                                mp.SequenceNumber = ++seqRefs;
                                mp.SystemId = 0;
                                mp.TimeStamp = DateTime.Now;
                                toSend = mav.Send(mp);
                                //refs.s
                                break;
                            case 10:
                                //Joypad RAW
                                Msg_rc_channels_scaled rc = new Msg_rc_channels_scaled();
                                //MAVLink.mavlink_vicon_position_estimate_t opti = new MAVLink.mavlink_vicon_position_estimate_t();
                                _rcvJoy++;
                                rc.chan1_scaled = (short)((short.Parse(pspl[2])-512) * 19.5); //-512/+512 --> -10000/+10000
                                rc.chan2_scaled = (short)((short.Parse(pspl[3])-512) * 19.5); //-512/+512 --> -10000/+10000
                                rc.chan3_scaled = (short)((short.Parse(pspl[4])-512) * 19.5); //-512/+512 --> -10000/+10000
                                rc.chan4_scaled = (short)((short.Parse(pspl[5])-512) * 19.5); //-512/+512 --> -10000/+10000
                                rc.chan5_scaled = unchecked((short)ushort.MaxValue);
                                rc.chan6_scaled = unchecked((short)ushort.MaxValue);
                                rc.chan7_scaled = unchecked((short)ushort.MaxValue);
                                rc.chan8_scaled = (short)(int.Parse(pspl[6]) * 30); //255*3*10 --> 0/7650 max value

                                MavlinkPacket mprc = new MavlinkPacket();
                                mprc.Message = rc;
                                mprc.ComponentId = 0;
                                mprc.SequenceNumber = ++seqJoy;
                                mprc.SystemId = 0;
                                mprc.TimeStamp = DateTime.Now;
                                toSend = mav.Send(mprc);
                                break;
                        }

                        //Invio dati correnti
                        if (_destinationUDP != null)
                        {
                            _destinationUDP.Send(toSend, toSend.Length);
                        }
                        if (_destinationSerial != null && _destinationSerial.IsOpen)
                        {
                            _destinationSerial.Write(toSend, 0, toSend.Length);
                        }
                        //tbPackets.Text = _rcvOpti + "";
                    }
                }
                //Recupera nuovo pacchetto
                if (_commActive)
                {
                    ConnectSourceUDP();
                }
            }

        }

    }
}

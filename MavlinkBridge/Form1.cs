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

        MAVLink.MavlinkParse mav = null;

        private int _rcvOpti = 0;
        private int _rcvPars = 0;
        private int _rcvRefs = 0;

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

            mav = new MAVLink.MavlinkParse();

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
                        byte[] toSend = new byte[0];
                        switch (type)
                        {
                            case 1:
                                //Optitrack
                                MAVLink.mavlink_vicon_position_estimate_t opti = new MAVLink.mavlink_vicon_position_estimate_t();
                                _rcvOpti++;
                                opti.x = int.Parse(pspl[2]) / 1000.0f;
                                opti.y = int.Parse(pspl[3]) / 1000.0f;
                                opti.z = int.Parse(pspl[4]) / 1000.0f;
                                opti.roll = 0;
                                opti.pitch = 0;
                                opti.yaw = 0;
                                //toSend = .
                                toSend = mav.GenerateMAVLinkPacket(MAVLink.MAVLINK_MSG_ID.VICON_POSITION_ESTIMATE, opti);
                                break;
                            case 5:
                                MAVLink.mavlink_unibo_parameters_t pars = new MAVLink.mavlink_unibo_parameters_t();
                                _rcvPars++;
                                pars.offset_T = float.Parse(pspl[2]);
                                pars.lat_mode = float.Parse(pspl[3]);
                                pars.delta = float.Parse(pspl[4]);
                                pars.K1 = float.Parse(pspl[5]);
                                pars.L1 = float.Parse(pspl[6]);
                                pars.Ixy = float.Parse(pspl[7]);
                                pars.K2 = float.Parse(pspl[8]);
                                pars.L2 = float.Parse(pspl[9]);
                                pars.Iz = float.Parse(pspl[10]);
                                pars.KpAttX = float.Parse(pspl[11]);
                                pars.KpAttY = float.Parse(pspl[12]);
                                pars.KpAttZ = float.Parse(pspl[13]);
                                pars.KdAttX = float.Parse(pspl[14]);
                                pars.KdAttY = float.Parse(pspl[15]);
                                pars.KdAttZ = float.Parse(pspl[16]);
                                pars.KiAttX = float.Parse(pspl[17]);
                                pars.KiAttY = float.Parse(pspl[18]);
                                pars.KiAttZ = float.Parse(pspl[19]);
                                pars.GE = float.Parse(pspl[20]);
                                pars.epsilon = float.Parse(pspl[21]);
                                pars.XY_Multiplier = float.Parse(pspl[22]);
                                pars.offset_x = float.Parse(pspl[23]);
                                pars.offset_y = float.Parse(pspl[24]);
                                pars.offset_z = float.Parse(pspl[25]);
                                toSend = mav.GenerateMAVLinkPacket(MAVLink.MAVLINK_MSG_ID.UNIBO_PARAMETERS, pars);
                                break;
                            case 7:
                                MAVLink.mavlink_unibo_references_t refs = new MAVLink.mavlink_unibo_references_t();
                                _rcvRefs++;
                                refs.p_refX = float.Parse(pspl[2]);
                                refs.p_refY = float.Parse(pspl[3]);
                                refs.p_refZ = float.Parse(pspl[4]);
                                refs.dot_p_refX = float.Parse(pspl[5]);
                                refs.dot_p_refY = float.Parse(pspl[6]);
                                refs.dot_p_refZ = float.Parse(pspl[7]);
                                refs.dot2_p_refX = float.Parse(pspl[8]);
                                refs.dot2_p_refY = float.Parse(pspl[9]);
                                refs.dot2_p_refZ = float.Parse(pspl[10]);
                                refs.psi_ref = float.Parse(pspl[11]);
                                refs.dot_psi_ref = float.Parse(pspl[12]);
                                refs.dot2_psi_ref = float.Parse(pspl[13]);
                                refs.q = float.Parse(pspl[14]);
                                refs.buttons = UInt32.Parse(pspl[15]);
                                refs.Tstamp = Int32.Parse(pspl[16]);
                                toSend = mav.GenerateMAVLinkPacket(MAVLink.MAVLINK_MSG_ID.UNIBO_REFERENCES, refs);
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

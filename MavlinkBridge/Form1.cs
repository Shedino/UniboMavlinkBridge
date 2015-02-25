using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.UI.WebControls;
using System.IO.Ports;
using System.Net.Sockets;
using System.Net;
using MavLink;
using System.Globalization;

namespace MavlinkBridge
{

    public enum ReloadType
    {
        ALL,
        SourceOnly,
        MavlinkOnly
    }

    public partial class MainForm : Form
    {
        private const string EOL = "\r\n";

        private UdpClient _sourceUDP = null;
        private UdpClient _destinationUDP = null;

        private SerialPort _sourceSerial = null;
        private SerialPort _destinationSerial = null;


        private UdpClient _sourceMavlinkUDP = null;
        
        private bool _commActive = false;
        IPEndPoint sep = null;
        IPEndPoint smavep = null;

        //MAVLink.MavlinkParse mav = null;
        Mavlink mav = null;

        Mavlink rcvmav = null;

        NumberFormatInfo nfi = System.Globalization.CultureInfo.InvariantCulture.NumberFormat;
        private int _rcvOpti = 0;
        private int _rcvPars = 0;
        private int _rcvRefs = 0;
        private int _rcvJoy = 0;
        private int counter = 0;
        byte seqOpti = 0;
        byte seqPars = 0;
        byte seqRefs = 0;
        byte seqJoy = 0;
        //parameters
        SendParams parsObj = new SendParams();

        bool paramsRcv = false;

        public MainForm()
        {
            InitializeComponent();
            UpdComPorts();
            //// Get a list of serial port names.
            //string[] ComPorts=SerialPort.GetPortNames();
            //this.rbComAddress.Items.Clear();
            //foreach(string ComPort in ComPorts)
            //{
            //    this.rbComAddress.Items.Add(new ListItem(ComPort,ComPort));
            //}
            //this.rbComAddress.SelectedIndex=0;
        }

        private void UpdComPorts()
        {
            // Get a list of serial port names.
            string[] ComPorts = SerialPort.GetPortNames();
            this.rbComAddress.Items.Clear();
            if (ComPorts.Length > 0)
            {
                foreach (string ComPort in ComPorts)
                {
                    this.rbComAddress.Items.Add(new ListItem(ComPort, ComPort));
                }
                this.rbComAddress.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _disconnetcBtn.Enabled = true;
            _connectBtn.Enabled = false;

            tbDebug.Text = "Trying to connect..."+EOL;
            _commActive = true;

            //mav = new MAVLink.MavlinkParse();
            mav = new Mavlink();
            rcvmav = new Mavlink();
            rcvmav.PacketReceived += new PacketReceivedEventHandler(rcvmav_PacketReceived);

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


                    string utxtmav = tbSourceMavlinkUdp.Text;
                    string[] splmav = utxtmav.Split(':');
                    smavep = new IPEndPoint(IPAddress.Any, int.Parse(splmav[1]));
                    _sourceMavlinkUDP = new UdpClient(smavep);

                    ConnectSourceUDP(ReloadType.ALL);
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
//                    _destinationUDP.op
                }
                else if (rbDestinationSerial.Checked) //SERIALE
                {
                    //Parse serial string
                    string stxt = tbDestSerial.Text;
                    string[] spl = stxt.Split(':');
                    _destinationSerial = new SerialPort(spl[0], int.Parse(spl[1]));
                    _destinationSerial.Open();
                }
                //Timer
                timer1.Enabled = true;
                tbDebug.Text = "Done." + EOL;
            }
            catch (Exception ex)
            {
                tbDebug.Text = "Error during connection!" + EOL;
                tbDebug.Text += ex.Message + EOL + ex.StackTrace;
                _disconnetcBtn.Enabled = false;
                _connectBtn.Enabled = true;
                timer1.Enabled = false;
            }

        }

        void _sourceSerial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ConnectSourceUDP(ReloadType reload)
        {
            if (reload == ReloadType.ALL || reload == ReloadType.SourceOnly)
            {
                UdpState s = new UdpState();
                s.e = sep;
                s.u = _sourceUDP;
                _sourceUDP.BeginReceive(new AsyncCallback(ReceiveCallback), s);
            }
            if (cbUseMavlink.Checked)
            {
                if (reload == ReloadType.ALL || reload == ReloadType.MavlinkOnly)
                {
                    UdpState smav = new UdpState();
                    smav.e = smavep;
                    smav.u = _sourceMavlinkUDP;
                    _sourceMavlinkUDP.BeginReceive(new AsyncCallback(ReceiveCallbackMavlink), smav);
                }
            }

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
            if (_sourceMavlinkUDP != null)
            {
                _sourceMavlinkUDP.Close();
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

            timer1.Enabled = false;

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
                        //int offset = 0;
                        //int size = 0;
                        switch (type)
                        {
                            case 1:
                                //Optitrack
                                Msg_vicon_position_estimate opti = new Msg_vicon_position_estimate();
                                //MAVLink.mavlink_vicon_position_estimate_t opti = new MAVLink.mavlink_vicon_position_estimate_t();
                                _rcvOpti++;
                                opti.x = int.Parse(pspl[2]) / 1000.0f;               //optitrack position
                                opti.y = int.Parse(pspl[3]) / 1000.0f;
                                opti.z = int.Parse(pspl[4]) / 1000.0f;
                                opti.roll = int.Parse(pspl[5]) * 100.0f;            //optitrack velocity
                                opti.pitch = int.Parse(pspl[6]) * 100.0f;
                                opti.yaw = int.Parse(pspl[7]) * 100.0f;
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
                                paramsRcv = true;
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
                        SendData(toSend);
                        //tbPackets.Text = _rcvOpti + "";
                    }
                }
                //Recupera nuovo pacchetto
                if (_commActive)
                {
                    ConnectSourceUDP(ReloadType.SourceOnly);
                }
            }

        }

        public void ReceiveCallbackMavlink(IAsyncResult ar)
        {
            UdpClient u = (UdpClient)((UdpState)(ar.AsyncState)).u;
            IPEndPoint e = (IPEndPoint)((UdpState)(ar.AsyncState)).e;

            if (u != null)
            {
                Byte[] receiveBytes = u.EndReceive(ar, ref e);
                //string receiveString = Encoding.ASCII.GetString(receiveBytes);

                //Console.WriteLine("Received: {0}", receiveString);
                /*
                if (mavlink_parse_char(MAVLINK_COMM_0, c, &rcvmsg, &rcvmstatus))
                {
                    // Handle message
                    //Serial.print("PACKET_RCV: ");
                    //Serial.println(millis());
                    switch (rcvmsg.msgid)
                    {
                        case MAVLINK_MSG_ID_COMMANDS:
                            //Decode mavlink message
                            //Serial.print("DECODE_START: ");
                            //Serial.println(millis());
                            mavlink_msg_commands_decode(&rcvmsg, &cmds);
                            //Serial.print("DECODE_END: ");
                            //Serial.println(millis());
                            frame[0] = cmds.LSX;
                            frame[1] = cmds.LSY;
                            frame[2] = cmds.RSX;
                            frame[3] = cmds.RSY;
                            frame[4] = cmds.BSX;
                            frame[5] = cmds.BSY;
                            frame[6] = cmds.Buttons; //frame[FRAME_LEN-2];
                            //Activate FLAGS
                            flgSendCommand = true;
                            lastRadio = millis();
                            digitalWrite(STATUS_LED, HIGH);
                            break;
                        default:
                            //Do nothing
                            break;
                    }
                }
                */
                rcvmav.ParseBytes(receiveBytes);

                //Recupera nuovo pacchetto
                if (_commActive)
                {
                    ConnectSourceUDP(ReloadType.MavlinkOnly);
                }
            }

        }

        void rcvmav_PacketReceived(object sender, MavlinkPacket e)
        {
            MavlinkMessage msg = e.Message;
            //Console.WriteLine(msg.GetType());
            byte[] toSend = new byte[255];
            if (msg.GetType() == typeof(Msg_rc_channels_scaled))
            {
                //parso?!
                Msg_rc_channels_scaled m = (Msg_rc_channels_scaled)msg;
                toSend = mav.Send(e);
                //Invio dati correnti
                SendData(toSend);
            }
            else if (msg.GetType() == typeof(Msg_command_long))
            {
                //parso?!
                Msg_command_long m = (Msg_command_long)msg;
                if (cbMini.Checked)
                {
                    //S LEN TYPE (13=references) DATA E
                    string sendStr = "S 0 17 " + m.command.ToString(nfi) + " " + m.confirmation.ToString(nfi) + " " + m.param1.ToString(nfi) + " " + m.param2.ToString(nfi) + " " + m.param3.ToString(nfi) + " " + m.param4.ToString(nfi) + " " + m.param5.ToString(nfi) + " " + m.param6.ToString(nfi) + " " + m.param7.ToString(nfi) + " E";
                    toSend = Encoding.ASCII.GetBytes(sendStr);
                }
                else
                {
                    toSend = mav.Send(e);
                }
                //Invio dati correnti
                SendData(toSend);
            }
            else if (msg.GetType() == typeof(Msg_position_target_local_ned))
            {
                //parso?!
                Msg_position_target_local_ned m = (Msg_position_target_local_ned)msg;
                if (cbMini.Checked)
                {
                    //S LEN TYPE (13=references) DATA E
                    string sendStr = "S 0 13 " + ConvIntStr(m.x) + " " + ConvIntStr(m.y) + " " + ConvIntStr(m.z) + " " + ConvIntStr(m.vx) + " " + ConvIntStr(m.vy) + " " + ConvIntStr(m.vz) + " " + ConvIntStr(m.afx) + " " + ConvIntStr(m.afy) + " " + ConvIntStr(m.afz) + " " + ConvIntStr(m.yaw) + " " + ConvIntStr(m.yaw_rate) + " E";
                    Console.WriteLine(sendStr);
                    toSend = Encoding.ASCII.GetBytes(sendStr);
                }
                else
                {
                    toSend = mav.Send(e);
                }
                //Invio dati correnti
                SendData(toSend);
            }
            else
            {
                //switch (msg.
                toSend = mav.Send(e);
                //Invio dati correnti
                SendData(toSend);
            }
            //Spedisco sempre dentro gli IF (che fungono da switch/case)
        }

        private string ConvIntStr(float p)
        {
            int retval = Convert.ToInt32(p*1000);
            return retval.ToString(nfi);
        }

        private void SendData(byte[] toSend)
        {
            if (_destinationUDP != null)
            {
                _destinationUDP.Send(toSend, toSend.Length);
            }
            if (_destinationSerial != null && _destinationSerial.IsOpen)
            {
                _destinationSerial.Write(toSend, 0, toSend.Length);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!paramsRcv)
            {
                byte[] toSend = new byte[255];
                Msg_unibo_parameters pars = new Msg_unibo_parameters();
                if (rbAtech.Checked)
                {
                    parsObj.SendType = UAVType.ATECH;
                    /*
                    pars.Offset_T = 0.0f; //1
                    pars.lat_mode = 1.0f;            //Mass
                    pars.delta = 0.1f;
                    pars.K1 = 7.0f;
                    pars.L1 = 18.0f; //5
                    pars.Ixy = 0.02f;
                    pars.K2 = 70.0f;
                    pars.L2 = 200.0f;
                    pars.Iz = 0.04f;
                    pars.KpAttX = 2.4f; //10
                    pars.KpAttY = 2.4f;
                    pars.KpAttZ = 1.5f;
                    pars.KdAttX = 0.14f;
                    pars.KdAttY = 0.14f;
                    pars.KdAttZ = 0.14f; //15
                    pars.KiAttX = 0.0f;
                    pars.KiAttY = 0.0f;
                    pars.KiAttZ = 0.01f;
                    pars.GE = 0.0f;
                    pars.epsilon = 0.06f; //20
                    pars.XY_Multiplier = 1.0f;
                    pars.offset_x = 0.0088f;             //J_xy
                    pars.offset_y = 0.0176f;             //J_z
                    pars.offset_z = 87.0f; //24
                    */
                }
                if (rbIris.Checked)
                {
                    parsObj.SendType = UAVType.IRIS;
                    //pars.Offset_T = 0.1f; //1
                    //pars.lat_mode = 1.35f;            //Mass
                    //pars.delta = 0.1f;
                    //pars.K1 = 7.0f;               //was7
                    //pars.L1 = 18.0f; //5
                    //pars.Ixy = 0.02f;
                    //pars.K2 = 70.0f;              //was 70
                    //pars.L2 = 200.0f;
                    //pars.Iz = 0.03f;            //was 0.06
                    //pars.KpAttX = 2.5f; //10   was 2.5
                    //pars.KpAttY = 2.4f;     // was 2.4
                    //pars.KpAttZ = 2.0f;
                    //pars.KdAttX = 0.19f;
                    //pars.KdAttY = 0.19f;
                    //pars.KdAttZ = 0.19f; //15
                    //pars.KiAttX = 0.0f;
                    //pars.KiAttY = 0.0f;
                    //pars.KiAttZ = 0.0f;
                    //pars.GE = 0.0f;
                    //pars.epsilon = 0.06f; //20
                    //pars.XY_Multiplier = 0.0f;
                    //pars.offset_x = 0.0088f;             //J_xy
                    //pars.offset_y = 0.0176f;             //J_z
                    //pars.offset_z = 80.0f; //24          //was 80

                }
                if (rbOverride.Checked)
                {
                    parsObj.SendType = UAVType.OVERRIDE;
                }
                pars.Offset_T = parsObj.Offset;
                pars.lat_mode = parsObj.Mass;
                pars.delta = parsObj.Delta;
                pars.K1 = parsObj.K1;
                pars.L1 = parsObj.L1;
                pars.Ixy = parsObj.Ixy;
                pars.K2 = parsObj.K2;
                pars.L2 = parsObj.L2;
                pars.Iz = parsObj.Iz;
                pars.KpAttX = parsObj.KpAttX;
                pars.KpAttY = parsObj.KpAttY;
                pars.KpAttZ = parsObj.KpAttZ;
                pars.KdAttX = parsObj.KdAttX;
                pars.KdAttY = parsObj.KdAttY;
                pars.KdAttZ = parsObj.KdAttZ;
                pars.KiAttX = parsObj.KiAttX;
                pars.KiAttY = parsObj.KiAttY;
                pars.KiAttZ = parsObj.KiAttZ;
                pars.GE = parsObj.GE;
                pars.epsilon = parsObj.Epsilon;
                pars.XY_Multiplier = parsObj.XY_mult;
                pars.offset_x = parsObj.Jxy;
                pars.offset_y = parsObj.Jz;
                pars.offset_z = parsObj.Offset_yaw;

                MavlinkPacket mppar = new MavlinkPacket();
                mppar.Message = pars;
                mppar.ComponentId = 0;
                mppar.SequenceNumber = ++seqPars;
                mppar.SystemId = 0;
                mppar.TimeStamp = DateTime.Now;
                toSend = mav.Send(mppar);

                //Invio dati correnti
                if (_destinationUDP != null)
                {
                    _destinationUDP.Send(toSend, toSend.Length);
                }
                if (_destinationSerial != null && _destinationSerial.IsOpen)
                {
                    _destinationSerial.Write(toSend, 0, toSend.Length);
                }

            }
            else
            {
                paramsRcv = false;
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadCustomParameters();
        }

        private void rbOverride_CheckedChanged(object sender, EventArgs e)
        {
            //button1_Click_1(sender, e);
            LoadCustomParameters();
        }

        private void LoadCustomParameters()
        {
            parsObj.Offset = float.Parse(textBox1.Text);
            parsObj.Mass = float.Parse(textBox2.Text);
            parsObj.Delta = float.Parse(textBox3.Text);
            parsObj.K1 = float.Parse(textBox4.Text);
            parsObj.L1 = float.Parse(textBox5.Text);
            parsObj.Ixy = float.Parse(textBox6.Text);
            parsObj.K2 = float.Parse(textBox7.Text);
            parsObj.L2 = float.Parse(textBox8.Text);
            parsObj.Iz = float.Parse(textBox9.Text);
            parsObj.KpAttX = float.Parse(textBox10.Text);
            parsObj.KpAttY = float.Parse(textBox11.Text);
            parsObj.KpAttZ = float.Parse(textBox12.Text);
            parsObj.KdAttX = float.Parse(textBox13.Text);
            parsObj.KdAttY = float.Parse(textBox14.Text);
            parsObj.KdAttZ = float.Parse(textBox15.Text);
            parsObj.KiAttX = float.Parse(textBox16.Text);
            parsObj.KiAttY = float.Parse(textBox17.Text);
            parsObj.KiAttZ = float.Parse(textBox18.Text);
            parsObj.GE = float.Parse(textBox19.Text);
            parsObj.Epsilon = float.Parse(textBox20.Text);
            parsObj.XY_mult = float.Parse(textBox21.Text);
            parsObj.Jxy = float.Parse(textBox22.Text);
            parsObj.Jz = float.Parse(textBox23.Text);
            parsObj.Offset_yaw = float.Parse(textBox24.Text);
        }

        private void btnMarco_Click(object sender, EventArgs e)
        {
            //Costruisco il mio array di bytes
            byte[] toSend = new byte[255];


            //Invio dati correnti
            if (_destinationUDP != null)
            {
                _destinationUDP.Send(toSend, toSend.Length);
            }
            if (_destinationSerial != null && _destinationSerial.IsOpen)
            {
                _destinationSerial.Write(toSend, 0, toSend.Length);
            }
        }

        private void rbSourceSerial_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbComAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    //TestLabel.Text = "ok" ;
        //    // Get a list of serial port names.
        //    string[] ports = SerialPort.GetPortNames();

        //    //Console.WriteLine("The following serial ports were found:");

        //    // Display each port name to the console.
        //    foreach (string port in ports)
        //    {
        //        this.rbComAddress.Items.Add(new ListItem(port, port));
        //        //Console.WriteLine(port);
        //        //TestLabel.Text = port;//"done";//
        //        //TestLabel.Update();
        //    }

        //    //Console.ReadLine();
        }

        private void rbSourceBox_Enter(object sender, EventArgs e)
        {

        }

        private void rbComBtn_Click(object sender, EventArgs e)
        {
            if (_commActive)
            {
                _commActive = false;
                _sourceSerial.Close();
                _sourceSerial.Dispose();
                rbCmdLbl.Enabled = false;
                rbCmdBox.Enabled = false;
                rbCmdBtn.Enabled = false;
                this.rbComBtn.Text = "Connect";
            }
            else
            {
                _commActive = true;
                _sourceSerial = new SerialPort(this.rbComAddress.Text);
                _sourceSerial.BaudRate = 57600;
                _sourceSerial.Parity = Parity.None;
                _sourceSerial.StopBits = StopBits.One;
                _sourceSerial.DataBits = 8;
                _sourceSerial.Handshake = Handshake.None;
                _sourceSerial.DataReceived += SerialPortDataReceived;
                try{
                    _sourceSerial.Open();
                }
                catch (Exception ex)
                {
                    //valutare come completare questa parte una volta che aggiungi la console
                    //System.Diagnostics.Debug.WriteLine(ex.Message + ex.StackTrace);
                    TestLabel.Text = "no";
                }
                rbCmdLbl.Enabled = true;
                rbCmdBox.Enabled = true;
                rbCmdBtn.Enabled = true;
                this.rbComBtn.Text = "Disconnect";
                //Console.WriteLine("Press any key to continue...");
                //Console.WriteLine();
                //Console.ReadKey();
            }
        }

        private void rbComUdBtn_Click(object sender, EventArgs e)
        {
            UpdComPorts();
        }

        private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();
            //this.TestLabel.Text = "ok";// indata;
            this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { indata });
            //Debug.Print("Data Received:");
            //Debug.Print(indata);
        }

        // delegate is used to write to a UI control from a non-UI thread
        private delegate void SetTextDeleg(string text);
        
        private void si_DataReceived(string data) {
            if (this.rbReadBox.Text.Length != 0) {
                this.rbReadBox.AppendText(Environment.NewLine);
            }
            this.rbReadBox.AppendText(data);
        }

        private void rbUdpAddress_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TestLabel_Click(object sender, EventArgs e)
        {

        }

        private void rbCmdBtn_Click(object sender, EventArgs e)
        {
            _sourceSerial.Write(this.rbCmdBox.Text + Environment.NewLine);
        }
    }
}

namespace MavlinkBridge
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSourceSerial = new System.Windows.Forms.TextBox();
            this.tbSourceUdp = new System.Windows.Forms.TextBox();
            this.rbSourceSerial = new System.Windows.Forms.RadioButton();
            this.rbSourceUDP = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbDestSerial = new System.Windows.Forms.TextBox();
            this.tbDestUdp = new System.Windows.Forms.TextBox();
            this.rbDestinationSerial = new System.Windows.Forms.RadioButton();
            this.rbDestinationUDP = new System.Windows.Forms.RadioButton();
            this._connectBtn = new System.Windows.Forms.Button();
            this._disconnetcBtn = new System.Windows.Forms.Button();
            this.tbPackets = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDebug = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rbAtech = new System.Windows.Forms.RadioButton();
            this.rbIris = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.rbOverride = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSourceSerial);
            this.groupBox1.Controls.Add(this.tbSourceUdp);
            this.groupBox1.Controls.Add(this.rbSourceSerial);
            this.groupBox1.Controls.Add(this.rbSourceUDP);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            // 
            // tbSourceSerial
            // 
            this.tbSourceSerial.Location = new System.Drawing.Point(419, 18);
            this.tbSourceSerial.Name = "tbSourceSerial";
            this.tbSourceSerial.Size = new System.Drawing.Size(138, 20);
            this.tbSourceSerial.TabIndex = 3;
            this.tbSourceSerial.Text = "COM12:57600";
            // 
            // tbSourceUdp
            // 
            this.tbSourceUdp.Location = new System.Drawing.Point(97, 18);
            this.tbSourceUdp.Name = "tbSourceUdp";
            this.tbSourceUdp.Size = new System.Drawing.Size(196, 20);
            this.tbSourceUdp.TabIndex = 2;
            this.tbSourceUdp.Text = "127.0.0.1:6655";
            // 
            // rbSourceSerial
            // 
            this.rbSourceSerial.AutoSize = true;
            this.rbSourceSerial.Location = new System.Drawing.Point(328, 19);
            this.rbSourceSerial.Name = "rbSourceSerial";
            this.rbSourceSerial.Size = new System.Drawing.Size(63, 17);
            this.rbSourceSerial.TabIndex = 1;
            this.rbSourceSerial.TabStop = true;
            this.rbSourceSerial.Text = "SERIAL";
            this.rbSourceSerial.UseVisualStyleBackColor = true;
            // 
            // rbSourceUDP
            // 
            this.rbSourceUDP.AutoSize = true;
            this.rbSourceUDP.Checked = true;
            this.rbSourceUDP.Location = new System.Drawing.Point(6, 19);
            this.rbSourceUDP.Name = "rbSourceUDP";
            this.rbSourceUDP.Size = new System.Drawing.Size(48, 17);
            this.rbSourceUDP.TabIndex = 0;
            this.rbSourceUDP.TabStop = true;
            this.rbSourceUDP.Text = "UDP";
            this.rbSourceUDP.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbDestSerial);
            this.groupBox2.Controls.Add(this.tbDestUdp);
            this.groupBox2.Controls.Add(this.rbDestinationSerial);
            this.groupBox2.Controls.Add(this.rbDestinationUDP);
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination";
            // 
            // tbDestSerial
            // 
            this.tbDestSerial.Location = new System.Drawing.Point(419, 18);
            this.tbDestSerial.Name = "tbDestSerial";
            this.tbDestSerial.Size = new System.Drawing.Size(138, 20);
            this.tbDestSerial.TabIndex = 5;
            this.tbDestSerial.Text = "COM21:115200";
            // 
            // tbDestUdp
            // 
            this.tbDestUdp.Location = new System.Drawing.Point(97, 18);
            this.tbDestUdp.Name = "tbDestUdp";
            this.tbDestUdp.Size = new System.Drawing.Size(196, 20);
            this.tbDestUdp.TabIndex = 4;
            this.tbDestUdp.Text = "127.0.0.1:54321";
            // 
            // rbDestinationSerial
            // 
            this.rbDestinationSerial.AutoSize = true;
            this.rbDestinationSerial.Checked = true;
            this.rbDestinationSerial.Location = new System.Drawing.Point(328, 19);
            this.rbDestinationSerial.Name = "rbDestinationSerial";
            this.rbDestinationSerial.Size = new System.Drawing.Size(63, 17);
            this.rbDestinationSerial.TabIndex = 3;
            this.rbDestinationSerial.TabStop = true;
            this.rbDestinationSerial.Text = "SERIAL";
            this.rbDestinationSerial.UseVisualStyleBackColor = true;
            // 
            // rbDestinationUDP
            // 
            this.rbDestinationUDP.AutoSize = true;
            this.rbDestinationUDP.Location = new System.Drawing.Point(6, 19);
            this.rbDestinationUDP.Name = "rbDestinationUDP";
            this.rbDestinationUDP.Size = new System.Drawing.Size(48, 17);
            this.rbDestinationUDP.TabIndex = 2;
            this.rbDestinationUDP.TabStop = true;
            this.rbDestinationUDP.Text = "UDP";
            this.rbDestinationUDP.UseVisualStyleBackColor = true;
            // 
            // _connectBtn
            // 
            this._connectBtn.Location = new System.Drawing.Point(12, 181);
            this._connectBtn.Name = "_connectBtn";
            this._connectBtn.Size = new System.Drawing.Size(167, 57);
            this._connectBtn.TabIndex = 2;
            this._connectBtn.Text = "GO";
            this._connectBtn.UseVisualStyleBackColor = true;
            this._connectBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // _disconnetcBtn
            // 
            this._disconnetcBtn.Location = new System.Drawing.Point(610, 181);
            this._disconnetcBtn.Name = "_disconnetcBtn";
            this._disconnetcBtn.Size = new System.Drawing.Size(167, 57);
            this._disconnetcBtn.TabIndex = 3;
            this._disconnetcBtn.Text = "STOP";
            this._disconnetcBtn.UseVisualStyleBackColor = true;
            this._disconnetcBtn.Click += new System.EventHandler(this._disconnetcBtn_Click);
            // 
            // tbPackets
            // 
            this.tbPackets.Location = new System.Drawing.Point(309, 193);
            this.tbPackets.Name = "tbPackets";
            this.tbPackets.Size = new System.Drawing.Size(100, 20);
            this.tbPackets.TabIndex = 4;
            this.tbPackets.Text = "0";
            this.tbPackets.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Routed packets";
            // 
            // tbDebug
            // 
            this.tbDebug.Location = new System.Drawing.Point(12, 244);
            this.tbDebug.Multiline = true;
            this.tbDebug.Name = "tbDebug";
            this.tbDebug.Size = new System.Drawing.Size(765, 117);
            this.tbDebug.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rbAtech
            // 
            this.rbAtech.AutoSize = true;
            this.rbAtech.Checked = true;
            this.rbAtech.Location = new System.Drawing.Point(451, 168);
            this.rbAtech.Name = "rbAtech";
            this.rbAtech.Size = new System.Drawing.Size(61, 17);
            this.rbAtech.TabIndex = 7;
            this.rbAtech.TabStop = true;
            this.rbAtech.Text = "ATECH";
            this.rbAtech.UseVisualStyleBackColor = true;
            // 
            // rbIris
            // 
            this.rbIris.AutoSize = true;
            this.rbIris.Location = new System.Drawing.Point(451, 189);
            this.rbIris.Name = "rbIris";
            this.rbIris.Size = new System.Drawing.Size(46, 17);
            this.rbIris.TabIndex = 8;
            this.rbIris.Text = "IRIS";
            this.rbIris.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(948, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "-2.2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(878, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "UPDATE PARAMETERS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(948, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(66, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "1.35";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(896, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Offset";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(896, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mass";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(896, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Delta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(879, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "K1, L1, Ixy";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(948, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(66, 20);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "0.1";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(948, 76);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(41, 20);
            this.textBox4.TabIndex = 17;
            this.textBox4.Text = "7";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(995, 76);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(41, 20);
            this.textBox5.TabIndex = 18;
            this.textBox5.Text = "18";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1042, 76);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(41, 20);
            this.textBox6.TabIndex = 19;
            this.textBox6.Text = "0.02";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(948, 99);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(41, 20);
            this.textBox7.TabIndex = 22;
            this.textBox7.Text = "70";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(995, 99);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(41, 20);
            this.textBox8.TabIndex = 21;
            this.textBox8.Text = "200";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(1042, 99);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(41, 20);
            this.textBox9.TabIndex = 20;
            this.textBox9.Text = "0.02";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(948, 122);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(41, 20);
            this.textBox10.TabIndex = 25;
            this.textBox10.Text = "2.4";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(995, 122);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(41, 20);
            this.textBox11.TabIndex = 24;
            this.textBox11.Text = "2.3";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(1042, 122);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(41, 20);
            this.textBox12.TabIndex = 23;
            this.textBox12.Text = "2";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(948, 145);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(41, 20);
            this.textBox13.TabIndex = 28;
            this.textBox13.Text = "0.19";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(995, 145);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(41, 20);
            this.textBox14.TabIndex = 27;
            this.textBox14.Text = "0.19";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(1042, 145);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(41, 20);
            this.textBox15.TabIndex = 26;
            this.textBox15.Text = "0.19";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(948, 167);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(41, 20);
            this.textBox16.TabIndex = 31;
            this.textBox16.Text = "0";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(995, 167);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(41, 20);
            this.textBox17.TabIndex = 30;
            this.textBox17.Text = "0";
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(1042, 168);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(41, 20);
            this.textBox18.TabIndex = 29;
            this.textBox18.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(879, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "K2, L2, Iz";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(882, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Kp ATT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(882, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Kd ATT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(886, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Ki ATT";
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(948, 190);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(66, 20);
            this.textBox19.TabIndex = 36;
            this.textBox19.Text = "0";
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(948, 212);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(66, 20);
            this.textBox20.TabIndex = 37;
            this.textBox20.Text = "0.06";
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(948, 234);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(66, 20);
            this.textBox21.TabIndex = 38;
            this.textBox21.Text = "1";
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(948, 254);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(66, 20);
            this.textBox22.TabIndex = 39;
            this.textBox22.Text = "0.0088";
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(948, 275);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(66, 20);
            this.textBox23.TabIndex = 40;
            this.textBox23.Text = "0.0176";
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(948, 296);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(66, 20);
            this.textBox24.TabIndex = 41;
            this.textBox24.Text = "80";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(895, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "GE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(887, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "epsilon";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(887, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "XY_mult";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(903, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Jxy";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(906, 278);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 13);
            this.label14.TabIndex = 46;
            this.label14.Text = "Jz";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(880, 298);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 47;
            this.label15.Text = "offset YAW";
            // 
            // rbOverride
            // 
            this.rbOverride.AutoSize = true;
            this.rbOverride.Location = new System.Drawing.Point(451, 212);
            this.rbOverride.Name = "rbOverride";
            this.rbOverride.Size = new System.Drawing.Size(81, 17);
            this.rbOverride.TabIndex = 48;
            this.rbOverride.Text = "OVERRIDE";
            this.rbOverride.UseVisualStyleBackColor = true;
            this.rbOverride.CheckedChanged += new System.EventHandler(this.rbOverride_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 373);
            this.Controls.Add(this.rbOverride);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox24);
            this.Controls.Add(this.textBox23);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rbIris);
            this.Controls.Add(this.rbAtech);
            this.Controls.Add(this.tbDebug);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPackets);
            this.Controls.Add(this._disconnetcBtn);
            this.Controls.Add(this._connectBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSourceSerial;
        private System.Windows.Forms.RadioButton rbSourceUDP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbDestinationSerial;
        private System.Windows.Forms.RadioButton rbDestinationUDP;
        private System.Windows.Forms.TextBox tbSourceSerial;
        private System.Windows.Forms.TextBox tbSourceUdp;
        private System.Windows.Forms.TextBox tbDestUdp;
        private System.Windows.Forms.TextBox tbDestSerial;
        private System.Windows.Forms.Button _connectBtn;
        private System.Windows.Forms.Button _disconnetcBtn;
        private System.Windows.Forms.TextBox tbPackets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDebug;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rbAtech;
        private System.Windows.Forms.RadioButton rbIris;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton rbOverride;
    }
}


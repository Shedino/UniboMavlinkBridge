namespace MavlinkBridge
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMini = new System.Windows.Forms.CheckBox();
            this.cbUseMavlink = new System.Windows.Forms.CheckBox();
            this.tbSourceMavlinkUdp = new System.Windows.Forms.TextBox();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnMarco = new System.Windows.Forms.Button();
            this.rbSourceMAVLink = new System.Windows.Forms.RadioButton();
            this.rbSourceUNIBO = new System.Windows.Forms.RadioButton();
            this.rbSourceBox = new System.Windows.Forms.GroupBox();
            this.rbUdpAddress1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.rbSourceBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMini);
            this.groupBox1.Controls.Add(this.cbUseMavlink);
            this.groupBox1.Controls.Add(this.tbSourceMavlinkUdp);
            this.groupBox1.Controls.Add(this.tbSourceSerial);
            this.groupBox1.Controls.Add(this.tbSourceUdp);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // cbMini
            // 
            resources.ApplyResources(this.cbMini, "cbMini");
            this.cbMini.Name = "cbMini";
            this.cbMini.UseVisualStyleBackColor = true;
            // 
            // cbUseMavlink
            // 
            resources.ApplyResources(this.cbUseMavlink, "cbUseMavlink");
            this.cbUseMavlink.Name = "cbUseMavlink";
            this.cbUseMavlink.UseVisualStyleBackColor = true;
            // 
            // tbSourceMavlinkUdp
            // 
            resources.ApplyResources(this.tbSourceMavlinkUdp, "tbSourceMavlinkUdp");
            this.tbSourceMavlinkUdp.Name = "tbSourceMavlinkUdp";
            // 
            // tbSourceSerial
            // 
            resources.ApplyResources(this.tbSourceSerial, "tbSourceSerial");
            this.tbSourceSerial.Name = "tbSourceSerial";
            // 
            // tbSourceUdp
            // 
            resources.ApplyResources(this.tbSourceUdp, "tbSourceUdp");
            this.tbSourceUdp.Name = "tbSourceUdp";
            // 
            // rbSourceSerial
            // 
            resources.ApplyResources(this.rbSourceSerial, "rbSourceSerial");
            this.rbSourceSerial.Name = "rbSourceSerial";
            this.rbSourceSerial.TabStop = true;
            this.rbSourceSerial.UseVisualStyleBackColor = true;
            this.rbSourceSerial.CheckedChanged += new System.EventHandler(this.rbSourceSerial_CheckedChanged);
            // 
            // rbSourceUDP
            // 
            resources.ApplyResources(this.rbSourceUDP, "rbSourceUDP");
            this.rbSourceUDP.Checked = true;
            this.rbSourceUDP.Name = "rbSourceUDP";
            this.rbSourceUDP.TabStop = true;
            this.rbSourceUDP.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbDestSerial);
            this.groupBox2.Controls.Add(this.tbDestUdp);
            this.groupBox2.Controls.Add(this.rbDestinationSerial);
            this.groupBox2.Controls.Add(this.rbDestinationUDP);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // tbDestSerial
            // 
            resources.ApplyResources(this.tbDestSerial, "tbDestSerial");
            this.tbDestSerial.Name = "tbDestSerial";
            // 
            // tbDestUdp
            // 
            resources.ApplyResources(this.tbDestUdp, "tbDestUdp");
            this.tbDestUdp.Name = "tbDestUdp";
            // 
            // rbDestinationSerial
            // 
            resources.ApplyResources(this.rbDestinationSerial, "rbDestinationSerial");
            this.rbDestinationSerial.Checked = true;
            this.rbDestinationSerial.Name = "rbDestinationSerial";
            this.rbDestinationSerial.TabStop = true;
            this.rbDestinationSerial.UseVisualStyleBackColor = true;
            // 
            // rbDestinationUDP
            // 
            resources.ApplyResources(this.rbDestinationUDP, "rbDestinationUDP");
            this.rbDestinationUDP.Name = "rbDestinationUDP";
            this.rbDestinationUDP.TabStop = true;
            this.rbDestinationUDP.UseVisualStyleBackColor = true;
            // 
            // _connectBtn
            // 
            resources.ApplyResources(this._connectBtn, "_connectBtn");
            this._connectBtn.Name = "_connectBtn";
            this._connectBtn.UseVisualStyleBackColor = true;
            this._connectBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // _disconnetcBtn
            // 
            resources.ApplyResources(this._disconnetcBtn, "_disconnetcBtn");
            this._disconnetcBtn.Name = "_disconnetcBtn";
            this._disconnetcBtn.UseVisualStyleBackColor = true;
            this._disconnetcBtn.Click += new System.EventHandler(this._disconnetcBtn_Click);
            // 
            // tbPackets
            // 
            resources.ApplyResources(this.tbPackets, "tbPackets");
            this.tbPackets.Name = "tbPackets";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tbDebug
            // 
            resources.ApplyResources(this.tbDebug, "tbDebug");
            this.tbDebug.Name = "tbDebug";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rbAtech
            // 
            resources.ApplyResources(this.rbAtech, "rbAtech");
            this.rbAtech.Checked = true;
            this.rbAtech.Name = "rbAtech";
            this.rbAtech.TabStop = true;
            this.rbAtech.UseVisualStyleBackColor = true;
            // 
            // rbIris
            // 
            resources.ApplyResources(this.rbIris, "rbIris");
            this.rbIris.Name = "rbIris";
            this.rbIris.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            // 
            // textBox6
            // 
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.Name = "textBox6";
            // 
            // textBox7
            // 
            resources.ApplyResources(this.textBox7, "textBox7");
            this.textBox7.Name = "textBox7";
            // 
            // textBox8
            // 
            resources.ApplyResources(this.textBox8, "textBox8");
            this.textBox8.Name = "textBox8";
            // 
            // textBox9
            // 
            resources.ApplyResources(this.textBox9, "textBox9");
            this.textBox9.Name = "textBox9";
            // 
            // textBox10
            // 
            resources.ApplyResources(this.textBox10, "textBox10");
            this.textBox10.Name = "textBox10";
            // 
            // textBox11
            // 
            resources.ApplyResources(this.textBox11, "textBox11");
            this.textBox11.Name = "textBox11";
            // 
            // textBox12
            // 
            resources.ApplyResources(this.textBox12, "textBox12");
            this.textBox12.Name = "textBox12";
            // 
            // textBox13
            // 
            resources.ApplyResources(this.textBox13, "textBox13");
            this.textBox13.Name = "textBox13";
            // 
            // textBox14
            // 
            resources.ApplyResources(this.textBox14, "textBox14");
            this.textBox14.Name = "textBox14";
            // 
            // textBox15
            // 
            resources.ApplyResources(this.textBox15, "textBox15");
            this.textBox15.Name = "textBox15";
            // 
            // textBox16
            // 
            resources.ApplyResources(this.textBox16, "textBox16");
            this.textBox16.Name = "textBox16";
            // 
            // textBox17
            // 
            resources.ApplyResources(this.textBox17, "textBox17");
            this.textBox17.Name = "textBox17";
            // 
            // textBox18
            // 
            resources.ApplyResources(this.textBox18, "textBox18");
            this.textBox18.Name = "textBox18";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // textBox19
            // 
            resources.ApplyResources(this.textBox19, "textBox19");
            this.textBox19.Name = "textBox19";
            // 
            // textBox20
            // 
            resources.ApplyResources(this.textBox20, "textBox20");
            this.textBox20.Name = "textBox20";
            // 
            // textBox21
            // 
            resources.ApplyResources(this.textBox21, "textBox21");
            this.textBox21.Name = "textBox21";
            // 
            // textBox22
            // 
            resources.ApplyResources(this.textBox22, "textBox22");
            this.textBox22.Name = "textBox22";
            // 
            // textBox23
            // 
            resources.ApplyResources(this.textBox23, "textBox23");
            this.textBox23.Name = "textBox23";
            // 
            // textBox24
            // 
            resources.ApplyResources(this.textBox24, "textBox24");
            this.textBox24.Name = "textBox24";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // rbOverride
            // 
            resources.ApplyResources(this.rbOverride, "rbOverride");
            this.rbOverride.Name = "rbOverride";
            this.rbOverride.UseVisualStyleBackColor = true;
            this.rbOverride.CheckedChanged += new System.EventHandler(this.rbOverride_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox24);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox23);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.textBox22);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.textBox21);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.textBox20);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.textBox19);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBox12);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox11);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox15);
            this.groupBox3.Controls.Add(this.textBox16);
            this.groupBox3.Controls.Add(this.textBox14);
            this.groupBox3.Controls.Add(this.textBox17);
            this.groupBox3.Controls.Add(this.textBox13);
            this.groupBox3.Controls.Add(this.textBox18);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnMarco);
            this.groupBox4.Controls.Add(this.rbSourceMAVLink);
            this.groupBox4.Controls.Add(this.rbSourceUNIBO);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // btnMarco
            // 
            resources.ApplyResources(this.btnMarco, "btnMarco");
            this.btnMarco.Name = "btnMarco";
            this.btnMarco.UseVisualStyleBackColor = true;
            this.btnMarco.Click += new System.EventHandler(this.btnMarco_Click);
            // 
            // rbSourceMAVLink
            // 
            resources.ApplyResources(this.rbSourceMAVLink, "rbSourceMAVLink");
            this.rbSourceMAVLink.Name = "rbSourceMAVLink";
            this.rbSourceMAVLink.TabStop = true;
            this.rbSourceMAVLink.UseVisualStyleBackColor = true;
            // 
            // rbSourceUNIBO
            // 
            resources.ApplyResources(this.rbSourceUNIBO, "rbSourceUNIBO");
            this.rbSourceUNIBO.Name = "rbSourceUNIBO";
            this.rbSourceUNIBO.TabStop = true;
            this.rbSourceUNIBO.UseVisualStyleBackColor = true;
            // 
            // rbSourceBox
            // 
            this.rbSourceBox.Controls.Add(this.rbSourceUDP);
            this.rbSourceBox.Controls.Add(this.rbSourceSerial);
            resources.ApplyResources(this.rbSourceBox, "rbSourceBox");
            this.rbSourceBox.Name = "rbSourceBox";
            this.rbSourceBox.TabStop = false;
            this.rbSourceBox.Enter += new System.EventHandler(this.sourceBox_Enter);
            // 
            // rbUdpAddress1
            // 
            resources.ApplyResources(this.rbUdpAddress1, "rbUdpAddress1");
            this.rbUdpAddress1.Name = "rbUdpAddress1";
            this.rbUdpAddress1.TextChanged += new System.EventHandler(this.rbUdpAddress1_TextChanged);
            this.rbUdpAddress1.KeyDown += new System.Windows.Forms.KeyEventHandler(rbUdpAddress1_KeyDownHandle);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbUdpAddress1);
            this.Controls.Add(this.rbSourceBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.rbOverride);
            this.Controls.Add(this.rbIris);
            this.Controls.Add(this.rbAtech);
            this.Controls.Add(this.tbDebug);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPackets);
            this.Controls.Add(this._disconnetcBtn);
            this.Controls.Add(this._connectBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.rbSourceBox.ResumeLayout(false);
            this.rbSourceBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbSourceMAVLink;
        private System.Windows.Forms.RadioButton rbSourceUNIBO;
        private System.Windows.Forms.CheckBox cbUseMavlink;
        private System.Windows.Forms.TextBox tbSourceMavlinkUdp;
        private System.Windows.Forms.CheckBox cbMini;
        private System.Windows.Forms.Button btnMarco;
        private System.Windows.Forms.GroupBox rbSourceBox;
        private System.Windows.Forms.TextBox rbUdpAddress1;
    }
}


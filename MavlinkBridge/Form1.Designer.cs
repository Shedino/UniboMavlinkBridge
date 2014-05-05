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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 373);
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
    }
}


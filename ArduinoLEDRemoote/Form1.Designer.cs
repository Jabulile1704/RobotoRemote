namespace ArduinoLEDRemoote
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblYellow = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.btnRedOn = new System.Windows.Forms.Button();
            this.btnYellowOn = new System.Windows.Forms.Button();
            this.btnGreenOn = new System.Windows.Forms.Button();
            this.btnBlueOn = new System.Windows.Forms.Button();
            this.btnRedOff = new System.Windows.Forms.Button();
            this.btnBlueOff = new System.Windows.Forms.Button();
            this.btnYellowOff = new System.Windows.Forms.Button();
            this.btnGreenOff = new System.Windows.Forms.Button();
            this.btnAllOn = new System.Windows.Forms.Button();
            this.btnAllOff = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.cmbPort);
            this.groupBox1.Controls.Add(this.lblPort);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGreenOff);
            this.groupBox2.Controls.Add(this.btnYellowOff);
            this.groupBox2.Controls.Add(this.btnBlueOff);
            this.groupBox2.Controls.Add(this.btnRedOff);
            this.groupBox2.Controls.Add(this.btnBlueOn);
            this.groupBox2.Controls.Add(this.btnGreenOn);
            this.groupBox2.Controls.Add(this.btnYellowOn);
            this.groupBox2.Controls.Add(this.btnRedOn);
            this.groupBox2.Controls.Add(this.lblBlue);
            this.groupBox2.Controls.Add(this.lblGreen);
            this.groupBox2.Controls.Add(this.lblYellow);
            this.groupBox2.Controls.Add(this.lblRed);
            this.groupBox2.Location = new System.Drawing.Point(12, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 149);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LED Controls";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAllOff);
            this.groupBox3.Controls.Add(this.btnAllOn);
            this.groupBox3.Location = new System.Drawing.Point(12, 319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 66);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "All LEDs";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(26, 29);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(64, 16);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "COM Port";
            this.lblPort.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(118, 26);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(121, 24);
            this.cmbPort.TabIndex = 1;
            this.cmbPort.SelectedIndexChanged += new System.EventHandler(this.cmbPort_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.SystemColors.Info;
            this.btnConnect.Location = new System.Drawing.Point(164, 56);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(26, 72);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(118, 20);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Not connected";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(26, 30);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(41, 20);
            this.lblRed.TabIndex = 4;
            this.lblRed.Text = "Red";
            this.lblRed.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblYellow
            // 
            this.lblYellow.AutoSize = true;
            this.lblYellow.Location = new System.Drawing.Point(26, 61);
            this.lblYellow.Name = "lblYellow";
            this.lblYellow.Size = new System.Drawing.Size(47, 16);
            this.lblYellow.TabIndex = 5;
            this.lblYellow.Text = "Yellow";
            this.lblYellow.Click += new System.EventHandler(this.lblYellow_Click);
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(26, 87);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(44, 16);
            this.lblGreen.TabIndex = 6;
            this.lblGreen.Text = "Green";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(26, 117);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(43, 20);
            this.lblBlue.TabIndex = 7;
            this.lblBlue.Text = "Blue";
            // 
            // btnRedOn
            // 
            this.btnRedOn.Location = new System.Drawing.Point(130, 27);
            this.btnRedOn.Name = "btnRedOn";
            this.btnRedOn.Size = new System.Drawing.Size(75, 23);
            this.btnRedOn.TabIndex = 8;
            this.btnRedOn.Text = "ON";
            this.btnRedOn.UseVisualStyleBackColor = true;
            this.btnRedOn.Click += new System.EventHandler(this.btnRedOn_Click);
            // 
            // btnYellowOn
            // 
            this.btnYellowOn.Location = new System.Drawing.Point(130, 58);
            this.btnYellowOn.Name = "btnYellowOn";
            this.btnYellowOn.Size = new System.Drawing.Size(75, 21);
            this.btnYellowOn.TabIndex = 9;
            this.btnYellowOn.Text = "ON";
            this.btnYellowOn.UseVisualStyleBackColor = true;
            this.btnYellowOn.Click += new System.EventHandler(this.btnYellowOn_Click_1);
            // 
            // btnGreenOn
            // 
            this.btnGreenOn.Location = new System.Drawing.Point(130, 84);
            this.btnGreenOn.Name = "btnGreenOn";
            this.btnGreenOn.Size = new System.Drawing.Size(75, 24);
            this.btnGreenOn.TabIndex = 10;
            this.btnGreenOn.Text = "ON";
            this.btnGreenOn.UseVisualStyleBackColor = true;
            this.btnGreenOn.Click += new System.EventHandler(this.btnGreenOn_Click_1);
            // 
            // btnBlueOn
            // 
            this.btnBlueOn.Location = new System.Drawing.Point(130, 113);
            this.btnBlueOn.Name = "btnBlueOn";
            this.btnBlueOn.Size = new System.Drawing.Size(75, 23);
            this.btnBlueOn.TabIndex = 11;
            this.btnBlueOn.Text = "ON";
            this.btnBlueOn.UseVisualStyleBackColor = true;
            this.btnBlueOn.Click += new System.EventHandler(this.btnBlueOn_Click_1);
            // 
            // btnRedOff
            // 
            this.btnRedOff.Location = new System.Drawing.Point(211, 27);
            this.btnRedOff.Name = "btnRedOff";
            this.btnRedOff.Size = new System.Drawing.Size(75, 23);
            this.btnRedOff.TabIndex = 12;
            this.btnRedOff.Text = "OFF";
            this.btnRedOff.UseVisualStyleBackColor = true;
            this.btnRedOff.Click += new System.EventHandler(this.btnRedOff_Click_1);
            // 
            // btnBlueOff
            // 
            this.btnBlueOff.Location = new System.Drawing.Point(211, 114);
            this.btnBlueOff.Name = "btnBlueOff";
            this.btnBlueOff.Size = new System.Drawing.Size(75, 23);
            this.btnBlueOff.TabIndex = 13;
            this.btnBlueOff.Text = "OFF";
            this.btnBlueOff.UseVisualStyleBackColor = true;
            this.btnBlueOff.Click += new System.EventHandler(this.btnBlueOff_Click_1);
            // 
            // btnYellowOff
            // 
            this.btnYellowOff.Location = new System.Drawing.Point(211, 56);
            this.btnYellowOff.Name = "btnYellowOff";
            this.btnYellowOff.Size = new System.Drawing.Size(75, 23);
            this.btnYellowOff.TabIndex = 13;
            this.btnYellowOff.Text = "OFF";
            this.btnYellowOff.UseVisualStyleBackColor = true;
            this.btnYellowOff.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnGreenOff
            // 
            this.btnGreenOff.Location = new System.Drawing.Point(211, 85);
            this.btnGreenOff.Name = "btnGreenOff";
            this.btnGreenOff.Size = new System.Drawing.Size(75, 23);
            this.btnGreenOff.TabIndex = 14;
            this.btnGreenOff.Text = "OFF";
            this.btnGreenOff.UseVisualStyleBackColor = true;
            this.btnGreenOff.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnAllOn
            // 
            this.btnAllOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAllOn.Location = new System.Drawing.Point(69, 21);
            this.btnAllOn.Name = "btnAllOn";
            this.btnAllOn.Size = new System.Drawing.Size(75, 23);
            this.btnAllOn.TabIndex = 0;
            this.btnAllOn.Text = "ALL ON";
            this.btnAllOn.UseVisualStyleBackColor = false;
            this.btnAllOn.Click += new System.EventHandler(this.btnAllOn_Click_1);
            // 
            // btnAllOff
            // 
            this.btnAllOff.BackColor = System.Drawing.Color.Gray;
            this.btnAllOff.Location = new System.Drawing.Point(180, 21);
            this.btnAllOff.Name = "btnAllOff";
            this.btnAllOff.Size = new System.Drawing.Size(75, 23);
            this.btnAllOff.TabIndex = 1;
            this.btnAllOff.Text = "ALL OFF";
            this.btnAllOff.UseVisualStyleBackColor = false;
            this.btnAllOff.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(348, 456);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduino LED Remote";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblYellow;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Button btnRedOn;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Button btnGreenOff;
        private System.Windows.Forms.Button btnYellowOff;
        private System.Windows.Forms.Button btnBlueOff;
        private System.Windows.Forms.Button btnRedOff;
        private System.Windows.Forms.Button btnBlueOn;
        private System.Windows.Forms.Button btnGreenOn;
        private System.Windows.Forms.Button btnYellowOn;
        private System.Windows.Forms.Button btnAllOn;
        private System.Windows.Forms.Button btnAllOff;
    }
}


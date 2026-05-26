using System;
using System.Drawing;
using System.IO.Ports;

using System.Windows.Forms;

namespace ArduinoLEDRemoote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPort.Items.AddRange(SerialPort.GetPortNames());
            if (cmbPort.Items.Count > 0)
                cmbPort.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void lblYellow_Click(object sender, EventArgs e)
        {

        }

        private void BtnRedOn_Click(object sender, EventArgs e)
        {

        }

        private void cmbPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                btnConnect.Text = "Connect";
                lblStatus.Text = "Disconnected";
                lblStatus.ForeColor = Color.DimGray;
            }
            else
            {
                try
                {
                    serialPort1.PortName = cmbPort.Text;
                    serialPort1.Open();
                    btnConnect.Text = "Disconnect";
                    lblStatus.Text = "Connected to " + cmbPort.Text;
                    lblStatus.ForeColor = Color.Green;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Connection Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }//end btnConnect_Click

        private void SendCommand(string command)
        {
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("Not connected. Please connect first.",
                    "Not Connected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            serialPort1.WriteLine(command);
        }

        private void btnRedOn_Click(object sender, EventArgs e) => SendCommand("RED_ON");
        private void btnRedOff_Click_1(object sender, EventArgs e) => SendCommand("RED_OFF");
        private void btnYellowOn_Click_1(object sender, EventArgs e) => SendCommand("YELLOW_ON");
        private void button6_Click(object sender, EventArgs e) => SendCommand("YELLOW_OFF");
        private void btnGreenOn_Click_1(object sender, EventArgs e) => SendCommand("GREEN_ON");
        private void button7_Click(object sender, EventArgs e) => SendCommand("GREEN_OFF");
        private void btnBlueOn_Click_1(object sender, EventArgs e) => SendCommand("BLUE_ON");
        private void btnBlueOff_Click_1(object sender, EventArgs e) => SendCommand("BLUE_OFF");
        private void btnAllOn_Click_1(object sender, EventArgs e) => SendCommand("ALL_ON");
        private void button1_Click(object sender, EventArgs e) => SendCommand("ALL_OFF"); //ALL OFF

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Open();
        }
    
    }//end class Form1
}//end ArduinoLEDRemoote namespace

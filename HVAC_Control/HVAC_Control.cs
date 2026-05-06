using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HVACSmartHomeController
{
    public partial class HVACSystem : Form
    {
        public HVACSystem()
        {
            Initialize = true;
            InitializeComponent();
            SetDefaults();
            Initialize = false;
        }
        //ISU Color Palette
        Color GrowlGreyLight = Color.FromArgb(230, 231, 232);
        Color GrowlGreyMed = Color.FromArgb(167, 167, 167);
        Color GrowlGrey = Color.FromArgb(130, 130, 130);
        Color Roarange = Color.FromArgb(244, 121, 32);
        Color RoarangeL = Color.FromArgb(246, 146, 64);
        Color BengalBlack = Color.FromArgb(0, 0, 0);
        bool Connect = false;
        bool Initialize = false;
        double Set = 70.0;
        double Change = 0.5;
        string degree = "\u00B0";
        //Program Logic------------------------------------------------------------------------------------------------------------------

        void SetDefaults() 
        {
            ConnectionTextBox.BackColor = GrowlGreyLight;
            ConnectionTextBox.ForeColor = BengalBlack;
            PortComboBox.BackColor = GrowlGreyLight;
            PortComboBox.ForeColor = BengalBlack;
            ExitButton.BackColor = GrowlGreyLight;
            ExitButton.ForeColor = BengalBlack;
            ConnectButton.BackColor = GrowlGreyLight;
            ConnectButton.ForeColor = BengalBlack;
            ClockLabel.ForeColor = BengalBlack;
            ClockLabel.BackColor = GrowlGreyMed;
            ClockLabel.Text = $"{DateTime.Now:t}";
            UpButton.BackColor = Roarange;
            DownButton.BackColor = Roarange;
            SetTempDisplayLabel.ForeColor = BengalBlack;
            SetTempDisplayLabel.BackColor = GrowlGrey;
            if (Set % 2 == 0)
            {
                SetTempDisplayLabel.Text = $"{Set.ToString()}.0{degree}F";
            }
            else if (Set % 1 == 0)
            {
                SetTempDisplayLabel.Text = $"{Set.ToString()}.0{degree}F";
            }
            else
            {
                SetTempDisplayLabel.Text = $"{Set.ToString()}{degree}F";
            }
        }

        void SerialConnect(string name)
        {
            serialPort1.Close();
            serialPort1.BaudRate = 115200;
            serialPort1.PortName = name;
            serialPort1.Parity = System.IO.Ports.Parity.None;
            //serialPort1.StopBits = System.IO.Ports.StopBits.None;
            try
            {
                serialPort1.Open();
                if (serialPort1.IsOpen)
                {
                    ConnectionTextBox.Text = "Connected";
                    ConnectionTextBox.BackColor = RoarangeL;
                    Connect = true;
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            //ConnectButton.Enabled = false;
        }
        byte[] SendData(byte[] data)
        {
            byte[] buffer = new byte[0];
            try
            {

                if (serialPort1.IsOpen)
                {
                    //flush old bytes from buffers
                    serialPort1.DiscardInBuffer();
                    serialPort1.DiscardOutBuffer();

                    //send command
                    serialPort1.Write(data, 0, data.Length);

                    //wait for response
                    Thread.Sleep(50);
                    //make the array the size of the input buffer
                    buffer = new byte[serialPort1.BytesToRead];
                    //actually read the input buffer
                    serialPort1.Read(buffer, 0, buffer.Length);
                }
                return buffer;
            }
            catch
            {
                return buffer;
            }
        }

        void GetQYAtBoards()
        {
            if (Connect == false)
            {
                PortComboBox.Text = "";
                PortComboBox.Items.Clear();
                string[] names = SerialPort.GetPortNames();
                foreach (string name in names)
                {
                    SerialConnect(name);
                    if (IsQYAtBoardCheck())
                    {
                        PortComboBox.Items.Add(name);
                    }
                }
                if (PortComboBox.Items.Count > 0)
                {
                    PortComboBox.SelectedIndex = 0;
                }
                serialPort1.Close();
            }
            else
            {
                if (serialPort1.IsOpen) 
                { 
                    
                }
                else 
                { 
                    Connect = false;
                    ConnectionTextBox.Text = "";
                }
            }
        }

        bool IsQYAtBoardCheck()
        {
            bool QYAt = false;
            byte[] QyAtSettings = { 0xf0 };
            byte[] ReadBuffer = SendData(QyAtSettings);
            if (ReadBuffer.Length == 64 && ReadBuffer[58] == 81 && ReadBuffer[59] == 121 && ReadBuffer[60] == 64)
            {
                //MessageBox.Show($"QY@ Board Connected  to {serialPort1.PortName}");
                QYAt = true;
            }
            return QYAt;
        }
        int ReadAnalogOne()
        {
            byte[] data = { 0x51 };
            byte[] response = SendData(data);
            if (response.Length == 2)
            {
                return (response[0] << 2) + (response[1] >> 6);
            }
            return -1;
        }
        int ReadAnalogTwo()
        {
            byte[] data = { 0x52 };
            byte[] response = SendData(data);
            if (response.Length == 2)
            {
                return (response[0] << 2) + (response[1] >> 6);
            }
            return -1;
        }
        int WriteDigitalOut(byte x)
        {
            byte[] data = { 0x20, x };
            byte[] response = SendData(data);
            if (response.Length == 2)
            {
                return (response[0] << 2) + (response[1] >> 6);
            }
            return -1;
        }
        int ReadDigitalIn()
        {
            byte[] data = { 0x30 };
            byte[] response = SendData(data);
            if (response.Length == 2)
            {
                return (response[0] << 2) + (response[1] >> 6);
            }
            return -1;
        }

        //Event Handlers-----------------------------------------------------------------------------------------------------------------

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QYAT_Timer_Tick(object sender, EventArgs e)
        {
            if (!Initialize)
            {
                GetQYAtBoards();
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                SerialConnect(PortComboBox.SelectedItem.ToString());
            }
            catch 
            { 
            
            }
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            if (!Initialize)
            {
                ClockLabel.Text = $"{DateTime.Now:t}";
            }
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            if (Set < 90) 
            {
                double Val = Set + Change;
                Set = Val;
                if (Set % 2 == 0)
                {
                    SetTempDisplayLabel.Text = $"{Set.ToString()}.0{degree}F";
                }
                else if (Set % 1 == 0) 
                {
                    SetTempDisplayLabel.Text = $"{Set.ToString()}.0{degree}F";
                }
                else 
                {
                    SetTempDisplayLabel.Text = $"{Set.ToString()}{degree}F";
                }
            }
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            if (Set > 50)
            {
                double Val = Set - Change;
                Set = Val;
                if (Set % 2 == 0)
                {
                    SetTempDisplayLabel.Text = $"{Set.ToString()}.0{degree}F";
                }
                else if (Set % 1 == 0)
                {
                    SetTempDisplayLabel.Text = $"{Set.ToString()}.0{degree}F";
                }
                else
                {
                    SetTempDisplayLabel.Text = $"{Set.ToString()}{degree}F";
                }
            }
        }
    }
}

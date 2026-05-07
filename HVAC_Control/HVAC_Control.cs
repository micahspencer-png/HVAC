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
            InitializeComponent();
            SetDefaults();
            GetQYAtBoards();
            try
            {
                if (PortComboBox.SelectedIndex != -1)
                {
                    SerialConnect(PortComboBox.SelectedItem.ToString());
                }
                if (serialPort1.IsOpen)
                {
                    ConnectionTextBox.Text = "Connected";
                    ConnectionTextBox.BackColor = RoarangeL;
                }
            }
            catch (Exception ex) { }
            TimerSet();
            if (serialPort1.IsOpen)
            {
                SensorProcess();
            }
        }
        //ISU Color Palette
        Color GrowlGreyLight = Color.FromArgb(230, 231, 232);
        Color GrowlGreyMed = Color.FromArgb(167, 167, 167);
        Color GrowlGrey = Color.FromArgb(130, 130, 130);
        Color Roarange = Color.FromArgb(244, 121, 32);
        Color RoarangeL = Color.FromArgb(246, 146, 64);
        Color BengalBlack = Color.FromArgb(0, 0, 0);
        double Set = 70.0;
        double Change = 0.5;
        string degree = "\u00B0";
        bool button1;
        bool button2;
        bool button3;
        bool button4;
        bool button5;
        bool fan;
        bool error = false;
        bool heat;
        bool cool;
        //Program Logic------------------------------------------------------------------------------------------------------------------
        void TimerSet() 
        { 
            QYAT_Timer.Enabled = true;
            ClockTimer.Enabled = true;
            ConnectionTimer.Enabled = true;
            AnalogSensorTimer.Enabled = true;
            DigitalTimer.Enabled = true;
            LogicTimer.Enabled = true;
        }
        void SetDefaults() 
        {
            toolStrip.BackColor = RoarangeL;
            ConnectionTextBox.BackColor = GrowlGreyLight;
            ConnectionTextBox.ForeColor = BengalBlack;
            PortComboBox.BackColor = GrowlGreyLight;
            PortComboBox.ForeColor = BengalBlack;
            ExitButton.BackColor = GrowlGreyLight;
            ExitButton.ForeColor = BengalBlack;
            SaveButton.BackColor = GrowlGreyLight;
            SaveButton.ForeColor = BengalBlack;
            ClockLabel.ForeColor = BengalBlack;
            ClockLabel.BackColor = GrowlGreyMed;
            ClockLabel.Text = $"{DateTime.Now:t}";
            UpButton.BackColor = RoarangeL;
            UpButton.ForeColor = GrowlGrey;
            DownButton.BackColor = RoarangeL;
            DownButton.ForeColor = GrowlGrey;
            SetTempDisplayLabel.ForeColor = BengalBlack;
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
            this.BackColor = GrowlGreyMed;
            this.ForeColor = Roarange;
            CurrentTempDisplayLabel.ForeColor = BengalBlack;
            CurrentTempDisplayLabel.Text = $"{Set.ToString()}{degree}F";
            ErrorLabel.ForeColor = BengalBlack;
            ErrorLabel.Text = "";
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
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }
            
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
            return -1;
        }
        byte ReadDigitalIn()
        {
            byte[] data = { 0x30 };
            byte[] response = SendData(data);
            return response[0];
        }

        void SensorProcess() 
        {
            ConnectionTimer.Enabled = false;
            AnalogSensorTimer.Enabled = false;
            DigitalTimer.Enabled = false;
            Timer5Sec.Enabled = false;
            LogicTimer.Enabled = false;
            int homeTemp;
            int unitTemp;
            homeTemp = ReadAnalogOne();
            unitTemp = ReadAnalogTwo();
            double temp1 = 60 * homeTemp / 1023 + 40;
            double temp2 = 60 * unitTemp / 1023 + 40;
            CurrentTempDisplayLabel.Text = $"{temp1.ToString()}{degree}F";
            if (Set>temp1) 
            {
                heat = true;
                cool = false;
            }
            if (Set < temp1)
            {
                heat = false;
                cool = true;
            }
            TimerSet();
        }

        void ButtonProcess() 
        {
            byte process = ReadDigitalIn();
            for (int i = 0; i < 5; i++) 
            {
                bool pressed = (process & ( 1<< i)) == 0;
                switch (i) 
                {
                    case 0 :
                        button1 = pressed;
                        break;
                    case 1:
                        button2 = pressed;
                        break;
                    case 2:
                        button3 = pressed;
                        break;
                    case 3:
                        button4 = pressed;
                        break;
                    case 4:
                        button5 = pressed;
                        break;
                }
            }
        }

        void LogicProcess() 
        {
            ConnectionTimer.Enabled = false;
            AnalogSensorTimer.Enabled = false;
            DigitalTimer.Enabled = false;
            Timer5Sec.Enabled = false;
            LogicTimer.Enabled = false;
            int i;
            if (error == false)
            {
                if (button1 == false)
                {
                    error = true;
                    ErrorLabel.Text = "Error";
                    i = WriteDigitalOut(0x01);
                    
                }
                else if (button1 == true)
                {
                    ErrorLabel.Text = "";
                }
                if (button2 == true && heat == true)
                {
                    i = WriteDigitalOut(0x08);
                    fan = true;
                    Timer5Sec.Enabled = true;
                    do
                    { } while (fan == true);
                    Timer5Sec.Enabled = false;
                    i = WriteDigitalOut(0x0A);
                    cool = false;
                }
                if (button3 == true)
                {
                    if (heat == true)
                    {
                        i = WriteDigitalOut(0x0A);
                    }
                    else if (cool == true)
                    {
                        i = WriteDigitalOut(0x0C);
                    }
                    else
                    {
                        i = WriteDigitalOut(0x08);
                    }
                }
                if (button4 == true)
                {
                    ErrorLabel.Text = "";
                }
                else if (button4 == false) 
                {
                    ErrorLabel.Text = "Error";
                    error = true;
                    i = WriteDigitalOut(0x08);
                    
                }
                if (button5 == true && cool == true)
                {
                    i = WriteDigitalOut(0x08);
                    fan = true;
                    Timer5Sec.Enabled = true;
                    do
                    { } while (fan == true);
                    Timer5Sec.Enabled = false;
                    i = WriteDigitalOut(0x0C);
                    heat = false;
                }
            }
            TimerSet();
        }

        //Event Handlers-----------------------------------------------------------------------------------------------------------------
        private void QYAT_Timer_Tick(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                GetQYAtBoards();
                ConnectionTextBox.BackColor = GrowlGreyMed;
                ConnectionTextBox.Text = "";
            }
        }
        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = $"{DateTime.Now:t}";
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

        private void ConnectionTimer_Tick(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) 
            {
                try
                {
                    if (PortComboBox.SelectedIndex != -1)
                    {
                        SerialConnect(PortComboBox.SelectedItem.ToString());
                    }
                }
                catch (Exception)
                {

                }
                if (serialPort1.IsOpen)
                {
                    ConnectionTextBox.Text = "Connected";
                    ConnectionTextBox.BackColor = RoarangeL;
                    UpButton.Focus();
                }
            }
        }

        private void AnalogSensorTimer_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) 
            {
                SensorProcess();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void DigitalTimer_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                ButtonProcess();
            }
        }

        private void LogicTimer_Tick(object sender, EventArgs e)
        {
            LogicProcess();
        }

        private void Timer5Sec_Tick(object sender, EventArgs e)
        {
            fan = false;
        }
    }
}

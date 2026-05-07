namespace HVACSmartHomeController
{
    partial class HVACSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HVACSystem));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.QYAT_Timer = new System.Windows.Forms.Timer(this.components);
            this.ConnectionTextBox = new System.Windows.Forms.TextBox();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.ClockLabel = new System.Windows.Forms.Label();
            this.UpButton = new System.Windows.Forms.Button();
            this.RoboticsBannerPictureBox = new System.Windows.Forms.PictureBox();
            this.DownButton = new System.Windows.Forms.Button();
            this.SettingLabel = new System.Windows.Forms.Label();
            this.TempLabel = new System.Windows.Forms.Label();
            this.SetTempDisplayLabel = new System.Windows.Forms.Label();
            this.CurrentTempDisplayLabel = new System.Windows.Forms.Label();
            this.FanModeLabel = new System.Windows.Forms.Label();
            this.ConnectionTimer = new System.Windows.Forms.Timer(this.components);
            this.AnalogSensorTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.PortComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.ExitButton = new System.Windows.Forms.ToolStripButton();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.DigitalTimer = new System.Windows.Forms.Timer(this.components);
            this.Timer5Sec = new System.Windows.Forms.Timer(this.components);
            this.LogicTimer = new System.Windows.Forms.Timer(this.components);
            this.FanModeDisplayLabel = new System.Windows.Forms.Label();
            this.FanStatusLabel = new System.Windows.Forms.Label();
            this.FanStatusDisplayLabel = new System.Windows.Forms.Label();
            this.HeatModeLabel = new System.Windows.Forms.Label();
            this.HeatModeDisplayLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RoboticsBannerPictureBox)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // QYAT_Timer
            // 
            this.QYAT_Timer.Interval = 1000;
            this.QYAT_Timer.Tick += new System.EventHandler(this.QYAT_Timer_Tick);
            // 
            // ConnectionTextBox
            // 
            this.ConnectionTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionTextBox.Location = new System.Drawing.Point(0, 39);
            this.ConnectionTextBox.Name = "ConnectionTextBox";
            this.ConnectionTextBox.ReadOnly = true;
            this.ConnectionTextBox.Size = new System.Drawing.Size(114, 30);
            this.ConnectionTextBox.TabIndex = 3;
            // 
            // ClockTimer
            // 
            this.ClockTimer.Interval = 1000;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // ClockLabel
            // 
            this.ClockLabel.AutoSize = true;
            this.ClockLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockLabel.Location = new System.Drawing.Point(499, 36);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(74, 28);
            this.ClockLabel.TabIndex = 6;
            this.ClockLabel.Text = "CLOCK";
            // 
            // UpButton
            // 
            this.UpButton.BackgroundImage = global::HVAC_Control.Properties.Resources.Uparrow;
            this.UpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpButton.Location = new System.Drawing.Point(946, 49);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(146, 128);
            this.UpButton.TabIndex = 7;
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // RoboticsBannerPictureBox
            // 
            this.RoboticsBannerPictureBox.BackgroundImage = global::HVAC_Control.Properties.Resources.ISU_RCET_Horizontal_Logo;
            this.RoboticsBannerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RoboticsBannerPictureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RoboticsBannerPictureBox.InitialImage = null;
            this.RoboticsBannerPictureBox.Location = new System.Drawing.Point(0, 358);
            this.RoboticsBannerPictureBox.Name = "RoboticsBannerPictureBox";
            this.RoboticsBannerPictureBox.Size = new System.Drawing.Size(1104, 171);
            this.RoboticsBannerPictureBox.TabIndex = 4;
            this.RoboticsBannerPictureBox.TabStop = false;
            // 
            // DownButton
            // 
            this.DownButton.BackgroundImage = global::HVAC_Control.Properties.Resources.Downarrow;
            this.DownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DownButton.Location = new System.Drawing.Point(946, 210);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(146, 128);
            this.DownButton.TabIndex = 8;
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // SettingLabel
            // 
            this.SettingLabel.AutoSize = true;
            this.SettingLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingLabel.Location = new System.Drawing.Point(662, 77);
            this.SettingLabel.Name = "SettingLabel";
            this.SettingLabel.Size = new System.Drawing.Size(158, 28);
            this.SettingLabel.TabIndex = 9;
            this.SettingLabel.Text = "Set Temperture";
            // 
            // TempLabel
            // 
            this.TempLabel.AutoSize = true;
            this.TempLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempLabel.Location = new System.Drawing.Point(313, 77);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(199, 28);
            this.TempLabel.TabIndex = 10;
            this.TempLabel.Text = "Current Temperture";
            // 
            // SetTempDisplayLabel
            // 
            this.SetTempDisplayLabel.AutoSize = true;
            this.SetTempDisplayLabel.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetTempDisplayLabel.Location = new System.Drawing.Point(649, 149);
            this.SetTempDisplayLabel.Name = "SetTempDisplayLabel";
            this.SetTempDisplayLabel.Size = new System.Drawing.Size(273, 106);
            this.SetTempDisplayLabel.TabIndex = 11;
            this.SetTempDisplayLabel.Text = "label1";
            // 
            // CurrentTempDisplayLabel
            // 
            this.CurrentTempDisplayLabel.AutoSize = true;
            this.CurrentTempDisplayLabel.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTempDisplayLabel.Location = new System.Drawing.Point(300, 149);
            this.CurrentTempDisplayLabel.Name = "CurrentTempDisplayLabel";
            this.CurrentTempDisplayLabel.Size = new System.Drawing.Size(273, 106);
            this.CurrentTempDisplayLabel.TabIndex = 12;
            this.CurrentTempDisplayLabel.Text = "label1";
            // 
            // FanModeLabel
            // 
            this.FanModeLabel.AutoSize = true;
            this.FanModeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FanModeLabel.Location = new System.Drawing.Point(12, 95);
            this.FanModeLabel.Name = "FanModeLabel";
            this.FanModeLabel.Size = new System.Drawing.Size(104, 28);
            this.FanModeLabel.TabIndex = 13;
            this.FanModeLabel.Text = "Fan Mode";
            // 
            // ConnectionTimer
            // 
            this.ConnectionTimer.Interval = 10000;
            this.ConnectionTimer.Tick += new System.EventHandler(this.ConnectionTimer_Tick);
            // 
            // AnalogSensorTimer
            // 
            this.AnalogSensorTimer.Interval = 30000;
            this.AnalogSensorTimer.Tick += new System.EventHandler(this.AnalogSensorTimer_Tick);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PortComboBox,
            this.ExitButton,
            this.SaveButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1104, 36);
            this.toolStrip.TabIndex = 14;
            this.toolStrip.Text = "toolStrip1";
            // 
            // PortComboBox
            // 
            this.PortComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortComboBox.Name = "PortComboBox";
            this.PortComboBox.Size = new System.Drawing.Size(121, 36);
            // 
            // ExitButton
            // 
            this.ExitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(52, 33);
            this.ExitButton.Text = "E&xit";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(60, 33);
            this.SaveButton.Text = "&Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DigitalTimer
            // 
            this.DigitalTimer.Interval = 500;
            this.DigitalTimer.Tick += new System.EventHandler(this.DigitalTimer_Tick);
            // 
            // Timer5Sec
            // 
            this.Timer5Sec.Interval = 5000;
            this.Timer5Sec.Tick += new System.EventHandler(this.Timer5Sec_Tick);
            // 
            // LogicTimer
            // 
            this.LogicTimer.Interval = 1000;
            this.LogicTimer.Tick += new System.EventHandler(this.LogicTimer_Tick);
            // 
            // FanModeDisplayLabel
            // 
            this.FanModeDisplayLabel.AutoSize = true;
            this.FanModeDisplayLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FanModeDisplayLabel.Location = new System.Drawing.Point(141, 95);
            this.FanModeDisplayLabel.Name = "FanModeDisplayLabel";
            this.FanModeDisplayLabel.Size = new System.Drawing.Size(70, 28);
            this.FanModeDisplayLabel.TabIndex = 15;
            this.FanModeDisplayLabel.Text = "label1";
            // 
            // FanStatusLabel
            // 
            this.FanStatusLabel.AutoSize = true;
            this.FanStatusLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FanStatusLabel.Location = new System.Drawing.Point(12, 138);
            this.FanStatusLabel.Name = "FanStatusLabel";
            this.FanStatusLabel.Size = new System.Drawing.Size(109, 28);
            this.FanStatusLabel.TabIndex = 16;
            this.FanStatusLabel.Text = "Fan Status";
            // 
            // FanStatusDisplayLabel
            // 
            this.FanStatusDisplayLabel.AutoSize = true;
            this.FanStatusDisplayLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FanStatusDisplayLabel.Location = new System.Drawing.Point(141, 138);
            this.FanStatusDisplayLabel.Name = "FanStatusDisplayLabel";
            this.FanStatusDisplayLabel.Size = new System.Drawing.Size(70, 28);
            this.FanStatusDisplayLabel.TabIndex = 17;
            this.FanStatusDisplayLabel.Text = "label1";
            // 
            // HeatModeLabel
            // 
            this.HeatModeLabel.AutoSize = true;
            this.HeatModeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeatModeLabel.Location = new System.Drawing.Point(12, 179);
            this.HeatModeLabel.Name = "HeatModeLabel";
            this.HeatModeLabel.Size = new System.Drawing.Size(66, 28);
            this.HeatModeLabel.TabIndex = 18;
            this.HeatModeLabel.Text = "Mode";
            // 
            // HeatModeDisplayLabel
            // 
            this.HeatModeDisplayLabel.AutoSize = true;
            this.HeatModeDisplayLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeatModeDisplayLabel.Location = new System.Drawing.Point(141, 179);
            this.HeatModeDisplayLabel.Name = "HeatModeDisplayLabel";
            this.HeatModeDisplayLabel.Size = new System.Drawing.Size(70, 28);
            this.HeatModeDisplayLabel.TabIndex = 19;
            this.HeatModeDisplayLabel.Text = "label1";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.Location = new System.Drawing.Point(12, 327);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(70, 28);
            this.ErrorLabel.TabIndex = 20;
            this.ErrorLabel.Text = "label1";
            // 
            // HVACSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 529);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.HeatModeDisplayLabel);
            this.Controls.Add(this.HeatModeLabel);
            this.Controls.Add(this.FanStatusDisplayLabel);
            this.Controls.Add(this.FanStatusLabel);
            this.Controls.Add(this.FanModeDisplayLabel);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.FanModeLabel);
            this.Controls.Add(this.CurrentTempDisplayLabel);
            this.Controls.Add(this.SetTempDisplayLabel);
            this.Controls.Add(this.ConnectionTextBox);
            this.Controls.Add(this.TempLabel);
            this.Controls.Add(this.SettingLabel);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.UpButton);
            this.Controls.Add(this.ClockLabel);
            this.Controls.Add(this.RoboticsBannerPictureBox);
            this.MaximizeBox = false;
            this.Name = "HVACSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HVAC Window";
            ((System.ComponentModel.ISupportInitialize)(this.RoboticsBannerPictureBox)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer QYAT_Timer;
        private System.Windows.Forms.TextBox ConnectionTextBox;
        private System.Windows.Forms.PictureBox RoboticsBannerPictureBox;
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Label SettingLabel;
        private System.Windows.Forms.Label TempLabel;
        private System.Windows.Forms.Label SetTempDisplayLabel;
        private System.Windows.Forms.Label CurrentTempDisplayLabel;
        private System.Windows.Forms.Label FanModeLabel;
        private System.Windows.Forms.Timer ConnectionTimer;
        private System.Windows.Forms.Timer AnalogSensorTimer;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripComboBox PortComboBox;
        private System.Windows.Forms.ToolStripButton ExitButton;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.Timer DigitalTimer;
        private System.Windows.Forms.Timer Timer5Sec;
        private System.Windows.Forms.Timer LogicTimer;
        private System.Windows.Forms.Label FanModeDisplayLabel;
        private System.Windows.Forms.Label FanStatusLabel;
        private System.Windows.Forms.Label FanStatusDisplayLabel;
        private System.Windows.Forms.Label HeatModeLabel;
        private System.Windows.Forms.Label HeatModeDisplayLabel;
        private System.Windows.Forms.Label ErrorLabel;
    }
}


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
            this.ExitButton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.PortComboBox = new System.Windows.Forms.ComboBox();
            this.QYAT_Timer = new System.Windows.Forms.Timer(this.components);
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ConnectionTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.ClockLabel = new System.Windows.Forms.Label();
            this.UpButton = new System.Windows.Forms.Button();
            this.RoboticsBannerPictureBox = new System.Windows.Forms.PictureBox();
            this.DownButton = new System.Windows.Forms.Button();
            this.SettingLabel = new System.Windows.Forms.Label();
            this.TempLabel = new System.Windows.Forms.Label();
            this.SetTempDisplayLabel = new System.Windows.Forms.Label();
            this.CurrentTempDisplayLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoboticsBannerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(6, 21);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(114, 48);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PortComboBox
            // 
            this.PortComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortComboBox.FormattingEnabled = true;
            this.PortComboBox.Location = new System.Drawing.Point(126, 27);
            this.PortComboBox.Name = "PortComboBox";
            this.PortComboBox.Size = new System.Drawing.Size(114, 36);
            this.PortComboBox.TabIndex = 1;
            // 
            // QYAT_Timer
            // 
            this.QYAT_Timer.Enabled = true;
            this.QYAT_Timer.Interval = 1000;
            this.QYAT_Timer.Tick += new System.EventHandler(this.QYAT_Timer_Tick);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButton.Location = new System.Drawing.Point(6, 75);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(114, 48);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "&Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ConnectionTextBox
            // 
            this.ConnectionTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionTextBox.Location = new System.Drawing.Point(126, 85);
            this.ConnectionTextBox.Name = "ConnectionTextBox";
            this.ConnectionTextBox.ReadOnly = true;
            this.ConnectionTextBox.Size = new System.Drawing.Size(114, 30);
            this.ConnectionTextBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExitButton);
            this.groupBox1.Controls.Add(this.PortComboBox);
            this.groupBox1.Controls.Add(this.ConnectionTextBox);
            this.groupBox1.Controls.Add(this.ConnectButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 138);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // ClockTimer
            // 
            this.ClockTimer.Enabled = true;
            this.ClockTimer.Interval = 1000;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // ClockLabel
            // 
            this.ClockLabel.AutoSize = true;
            this.ClockLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockLabel.Location = new System.Drawing.Point(505, 9);
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
            // HVACSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 529);
            this.Controls.Add(this.CurrentTempDisplayLabel);
            this.Controls.Add(this.SetTempDisplayLabel);
            this.Controls.Add(this.TempLabel);
            this.Controls.Add(this.SettingLabel);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.UpButton);
            this.Controls.Add(this.ClockLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RoboticsBannerPictureBox);
            this.MaximizeBox = false;
            this.Name = "HVACSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HVAC Window";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoboticsBannerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox PortComboBox;
        private System.Windows.Forms.Timer QYAT_Timer;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox ConnectionTextBox;
        private System.Windows.Forms.PictureBox RoboticsBannerPictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.Label ClockLabel;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Label SettingLabel;
        private System.Windows.Forms.Label TempLabel;
        private System.Windows.Forms.Label SetTempDisplayLabel;
        private System.Windows.Forms.Label CurrentTempDisplayLabel;
    }
}


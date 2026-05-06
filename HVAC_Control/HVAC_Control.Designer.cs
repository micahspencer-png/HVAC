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
            this.RoboticsBannerPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.RoboticsBannerPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExitButton);
            this.groupBox1.Controls.Add(this.PortComboBox);
            this.groupBox1.Controls.Add(this.ConnectionTextBox);
            this.groupBox1.Controls.Add(this.ConnectButton);
            this.groupBox1.Location = new System.Drawing.Point(853, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 138);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // HVACSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 529);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RoboticsBannerPictureBox);
            this.MaximizeBox = false;
            this.Name = "HVACSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HVAC Window";
            ((System.ComponentModel.ISupportInitialize)(this.RoboticsBannerPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}


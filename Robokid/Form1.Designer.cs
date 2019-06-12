namespace Robokid
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.motion_pan = new System.Windows.Forms.GroupBox();
			this.button6 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbCameraResolution = new System.Windows.Forms.ComboBox();
			this.cmbCameraDevices = new System.Windows.Forms.ComboBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.button5 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.arm_pan = new System.Windows.Forms.GroupBox();
			this.arm = new System.Windows.Forms.GroupBox();
			this.button10 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.gripper = new System.Windows.Forms.GroupBox();
			this.close = new System.Windows.Forms.Button();
			this.open = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.serial_connection = new System.Windows.Forms.GroupBox();
			this.button12 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.lcd_control = new System.Windows.Forms.GroupBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.controlpan = new System.Windows.Forms.GroupBox();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.motion_pan.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.arm_pan.SuspendLayout();
			this.arm.SuspendLayout();
			this.gripper.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.serial_connection.SuspendLayout();
			this.lcd_control.SuspendLayout();
			this.controlpan.SuspendLayout();
			this.SuspendLayout();
			// 
			// motion_pan
			// 
			this.motion_pan.Controls.Add(this.button6);
			this.motion_pan.Controls.Add(this.button11);
			this.motion_pan.Controls.Add(this.label2);
			this.motion_pan.Controls.Add(this.label1);
			this.motion_pan.Controls.Add(this.cmbCameraResolution);
			this.motion_pan.Controls.Add(this.cmbCameraDevices);
			this.motion_pan.Controls.Add(this.pictureBox2);
			this.motion_pan.Controls.Add(this.button5);
			this.motion_pan.Controls.Add(this.button3);
			this.motion_pan.Controls.Add(this.button4);
			this.motion_pan.Location = new System.Drawing.Point(3, 3);
			this.motion_pan.Name = "motion_pan";
			this.motion_pan.Size = new System.Drawing.Size(664, 563);
			this.motion_pan.TabIndex = 0;
			this.motion_pan.TabStop = false;
			this.motion_pan.Text = "Motion";
			this.motion_pan.Enter += new System.EventHandler(this.motion_pan_Enter);
			// 
			// button6
			// 
			this.button6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button6.Location = new System.Drawing.Point(283, 534);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 15;
			this.button6.Text = "\\/";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(551, 494);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(75, 23);
			this.button11.TabIndex = 14;
			this.button11.Text = "Capture";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.button11_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(38, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Resolution";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Camera";
			// 
			// cmbCameraResolution
			// 
			this.cmbCameraResolution.FormattingEnabled = true;
			this.cmbCameraResolution.Location = new System.Drawing.Point(146, 36);
			this.cmbCameraResolution.Name = "cmbCameraResolution";
			this.cmbCameraResolution.Size = new System.Drawing.Size(239, 21);
			this.cmbCameraResolution.TabIndex = 11;
			this.cmbCameraResolution.SelectedIndexChanged += new System.EventHandler(this.cmbCameraResolution_SelectedIndexChanged);
			// 
			// cmbCameraDevices
			// 
			this.cmbCameraDevices.FormattingEnabled = true;
			this.cmbCameraDevices.Location = new System.Drawing.Point(146, 9);
			this.cmbCameraDevices.Name = "cmbCameraDevices";
			this.cmbCameraDevices.Size = new System.Drawing.Size(239, 21);
			this.cmbCameraDevices.TabIndex = 10;
			this.cmbCameraDevices.SelectedIndexChanged += new System.EventHandler(this.cmbCameraDevices_SelectedIndexChanged);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.Location = new System.Drawing.Point(6, 69);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(632, 419);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// button5
			// 
			this.button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button5.Location = new System.Drawing.Point(364, 521);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 8;
			this.button5.Text = ">";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button3
			// 
			this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button3.Location = new System.Drawing.Point(202, 521);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 6;
			this.button3.Text = "<";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button4.Location = new System.Drawing.Point(283, 494);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 7;
			this.button4.Text = "/\\";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// arm_pan
			// 
			this.arm_pan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.arm_pan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.arm_pan.Controls.Add(this.arm);
			this.arm_pan.Controls.Add(this.gripper);
			this.arm_pan.Controls.Add(this.pictureBox1);
			this.arm_pan.Location = new System.Drawing.Point(684, 3);
			this.arm_pan.Name = "arm_pan";
			this.arm_pan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.arm_pan.Size = new System.Drawing.Size(665, 563);
			this.arm_pan.TabIndex = 1;
			this.arm_pan.TabStop = false;
			this.arm_pan.Text = "Arm";
			// 
			// arm
			// 
			this.arm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.arm.Controls.Add(this.button10);
			this.arm.Controls.Add(this.button9);
			this.arm.Location = new System.Drawing.Point(337, 502);
			this.arm.Name = "arm";
			this.arm.Size = new System.Drawing.Size(184, 49);
			this.arm.TabIndex = 11;
			this.arm.TabStop = false;
			this.arm.Text = "Arm";
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(104, 15);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(67, 23);
			this.button10.TabIndex = 11;
			this.button10.Text = "Shrink";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(16, 15);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(67, 23);
			this.button9.TabIndex = 10;
			this.button9.Text = "Stretch";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// gripper
			// 
			this.gripper.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.gripper.Controls.Add(this.close);
			this.gripper.Controls.Add(this.open);
			this.gripper.Location = new System.Drawing.Point(150, 502);
			this.gripper.Name = "gripper";
			this.gripper.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.gripper.Size = new System.Drawing.Size(181, 50);
			this.gripper.TabIndex = 10;
			this.gripper.TabStop = false;
			this.gripper.Text = "Gripper";
			// 
			// close
			// 
			this.close.Location = new System.Drawing.Point(101, 15);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(74, 23);
			this.close.TabIndex = 9;
			this.close.Text = "Close";
			this.close.UseVisualStyleBackColor = true;
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// open
			// 
			this.open.Location = new System.Drawing.Point(4, 15);
			this.open.Name = "open";
			this.open.Size = new System.Drawing.Size(74, 23);
			this.open.TabIndex = 8;
			this.open.Text = "Open";
			this.open.UseVisualStyleBackColor = true;
			this.open.Click += new System.EventHandler(this.open_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Location = new System.Drawing.Point(40, 69);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(602, 412);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// serial_connection
			// 
			this.serial_connection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.serial_connection.Controls.Add(this.button12);
			this.serial_connection.Controls.Add(this.comboBox1);
			this.serial_connection.Controls.Add(this.button1);
			this.serial_connection.ForeColor = System.Drawing.Color.Gray;
			this.serial_connection.Location = new System.Drawing.Point(3, 599);
			this.serial_connection.Name = "serial_connection";
			this.serial_connection.Size = new System.Drawing.Size(346, 100);
			this.serial_connection.TabIndex = 2;
			this.serial_connection.TabStop = false;
			this.serial_connection.Text = "Serial Connection";
			// 
			// button12
			// 
			this.button12.ForeColor = System.Drawing.Color.Black;
			this.button12.Location = new System.Drawing.Point(12, 68);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(83, 23);
			this.button12.TabIndex = 6;
			this.button12.Text = "Serial Monitor";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.button12_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(101, 41);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(232, 21);
			this.comboBox1.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(12, 39);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(83, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Connect";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lcd_control
			// 
			this.lcd_control.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lcd_control.Controls.Add(this.textBox1);
			this.lcd_control.Controls.Add(this.button2);
			this.lcd_control.Location = new System.Drawing.Point(918, 599);
			this.lcd_control.Name = "lcd_control";
			this.lcd_control.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lcd_control.Size = new System.Drawing.Size(431, 100);
			this.lcd_control.TabIndex = 3;
			this.lcd_control.TabStop = false;
			this.lcd_control.Text = "LCD 16×2 Control";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(6, 19);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(332, 63);
			this.textBox1.TabIndex = 6;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(344, 45);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Send";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// controlpan
			// 
			this.controlpan.Controls.Add(this.button8);
			this.controlpan.Controls.Add(this.button7);
			this.controlpan.ForeColor = System.Drawing.Color.Gray;
			this.controlpan.Location = new System.Drawing.Point(411, 599);
			this.controlpan.Name = "controlpan";
			this.controlpan.Size = new System.Drawing.Size(441, 100);
			this.controlpan.TabIndex = 4;
			this.controlpan.TabStop = false;
			this.controlpan.Text = "Control";
			// 
			// button8
			// 
			this.button8.ForeColor = System.Drawing.Color.Black;
			this.button8.Location = new System.Drawing.Point(254, 19);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(162, 63);
			this.button8.TabIndex = 1;
			this.button8.Text = "Autonomous";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button7
			// 
			this.button7.ForeColor = System.Drawing.Color.Black;
			this.button7.Location = new System.Drawing.Point(36, 19);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(162, 63);
			this.button7.TabIndex = 0;
			this.button7.Text = "Manual";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Robokid.Properties.Resources.back;
			this.ClientSize = new System.Drawing.Size(1350, 711);
			this.Controls.Add(this.controlpan);
			this.Controls.Add(this.arm_pan);
			this.Controls.Add(this.serial_connection);
			this.Controls.Add(this.lcd_control);
			this.Controls.Add(this.motion_pan);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Robokid";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Shown += new System.EventHandler(this.Form1_Shown);
			this.Click += new System.EventHandler(this.Form1_Click);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			this.motion_pan.ResumeLayout(false);
			this.motion_pan.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.arm_pan.ResumeLayout(false);
			this.arm.ResumeLayout(false);
			this.gripper.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.serial_connection.ResumeLayout(false);
			this.lcd_control.ResumeLayout(false);
			this.lcd_control.PerformLayout();
			this.controlpan.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox motion_pan;
        private System.Windows.Forms.GroupBox arm_pan;
        private System.Windows.Forms.GroupBox serial_connection;
        private System.Windows.Forms.GroupBox lcd_control;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCameraResolution;
        private System.Windows.Forms.ComboBox cmbCameraDevices;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.GroupBox arm;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox gripper;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.GroupBox controlpan;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button12;
    }
}


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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.arm = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.gripper = new System.Windows.Forms.GroupBox();
            this.close = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.serial_connection = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.controlpan = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.arm.SuspendLayout();
            this.gripper.SuspendLayout();
            this.serial_connection.SuspendLayout();
            this.controlpan.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Location = new System.Drawing.Point(484, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Megnets";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(332, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Box 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(192, 78);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(52, 17);
            this.radioButton5.TabIndex = 16;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Box 5";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(48, 78);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(52, 17);
            this.radioButton6.TabIndex = 17;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Box 6";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(192, 28);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Box 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(48, 28);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 17);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Box 3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(332, 78);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(52, 17);
            this.radioButton4.TabIndex = 15;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Box 4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // arm
            // 
            this.arm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.arm.Controls.Add(this.button10);
            this.arm.Controls.Add(this.button9);
            this.arm.Location = new System.Drawing.Point(446, 108);
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
            this.gripper.Location = new System.Drawing.Point(442, 24);
            this.gripper.Name = "gripper";
            this.gripper.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gripper.Size = new System.Drawing.Size(181, 50);
            this.gripper.TabIndex = 10;
            this.gripper.TabStop = false;
            this.gripper.Text = "Gripper";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(92, 15);
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
            // serial_connection
            // 
            this.serial_connection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.serial_connection.Controls.Add(this.button12);
            this.serial_connection.Controls.Add(this.comboBox1);
            this.serial_connection.Controls.Add(this.button1);
            this.serial_connection.Location = new System.Drawing.Point(12, 12);
            this.serial_connection.Name = "serial_connection";
            this.serial_connection.Size = new System.Drawing.Size(346, 100);
            this.serial_connection.TabIndex = 2;
            this.serial_connection.TabStop = false;
            this.serial_connection.Text = "Serial Connection";
            // 
            // button12
            // 
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
            this.button1.Location = new System.Drawing.Point(12, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // controlpan
            // 
            this.controlpan.Controls.Add(this.button8);
            this.controlpan.Controls.Add(this.button7);
            this.controlpan.Location = new System.Drawing.Point(12, 174);
            this.controlpan.Name = "controlpan";
            this.controlpan.Size = new System.Drawing.Size(441, 100);
            this.controlpan.TabIndex = 4;
            this.controlpan.TabStop = false;
            this.controlpan.Text = "Control";
            // 
            // button8
            // 
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
            this.ClientSize = new System.Drawing.Size(934, 288);
            this.Controls.Add(this.arm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gripper);
            this.Controls.Add(this.controlpan);
            this.Controls.Add(this.serial_connection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robokid";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.arm.ResumeLayout(false);
            this.gripper.ResumeLayout(false);
            this.serial_connection.ResumeLayout(false);
            this.controlpan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox serial_connection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox arm;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox gripper;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.GroupBox controlpan;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}


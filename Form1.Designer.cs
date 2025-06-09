namespace PassGen
{
    partial class PassGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassGen));
            this.StartButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDigit = new System.Windows.Forms.CheckBox();
            this.cbUpper = new System.Windows.Forms.CheckBox();
            this.cbSpecial = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.CopyPassword = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.DeletePassword = new System.Windows.Forms.Button();
            this.FullReset = new System.Windows.Forms.Button();
            this.lengthField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbLower = new System.Windows.Forms.CheckBox();
            this.isCopied = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartButton.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.StartButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StartButton.Location = new System.Drawing.Point(538, 374);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(188, 43);
            this.StartButton.TabIndex = 18;
            this.StartButton.Text = "Create password";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(94, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 53);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password Generator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AccessibleName = "";
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(31, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "1. Enter the length in digits (max 999):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AccessibleName = "";
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RosyBrown;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "2. Is it needed in the password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AccessibleName = "";
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Your password:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AccessibleName = "";
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.BurlyWood;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(155, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "uppercase";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AccessibleName = "";
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.BurlyWood;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(463, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "special characters";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AccessibleName = "";
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.BurlyWood;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(56, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "digits";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cbDigit
            // 
            this.cbDigit.AutoSize = true;
            this.cbDigit.BackColor = System.Drawing.Color.Transparent;
            this.cbDigit.Location = new System.Drawing.Point(129, 191);
            this.cbDigit.Name = "cbDigit";
            this.cbDigit.Size = new System.Drawing.Size(15, 14);
            this.cbDigit.TabIndex = 8;
            this.cbDigit.UseVisualStyleBackColor = false;
            this.cbDigit.CheckedChanged += new System.EventHandler(this.cbDigit_CheckedChanged_1);
            // 
            // cbUpper
            // 
            this.cbUpper.AutoSize = true;
            this.cbUpper.BackColor = System.Drawing.Color.Transparent;
            this.cbUpper.Location = new System.Drawing.Point(284, 192);
            this.cbUpper.Name = "cbUpper";
            this.cbUpper.Size = new System.Drawing.Size(15, 14);
            this.cbUpper.TabIndex = 9;
            this.cbUpper.UseVisualStyleBackColor = false;
            this.cbUpper.CheckedChanged += new System.EventHandler(this.cbUpper_CheckedChanged);
            // 
            // cbSpecial
            // 
            this.cbSpecial.AutoSize = true;
            this.cbSpecial.BackColor = System.Drawing.Color.Transparent;
            this.cbSpecial.Location = new System.Drawing.Point(683, 193);
            this.cbSpecial.Name = "cbSpecial";
            this.cbSpecial.Size = new System.Drawing.Size(15, 14);
            this.cbSpecial.TabIndex = 10;
            this.cbSpecial.UseVisualStyleBackColor = false;
            this.cbSpecial.CheckedChanged += new System.EventHandler(this.cbSpecial_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PassGen.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(20, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // passwordField
            // 
            this.passwordField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.passwordField.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.passwordField.Location = new System.Drawing.Point(216, 239);
            this.passwordField.MaxLength = 999;
            this.passwordField.Name = "passwordField";
            this.passwordField.ReadOnly = true;
            this.passwordField.Size = new System.Drawing.Size(510, 32);
            this.passwordField.TabIndex = 13;
            this.passwordField.TextChanged += new System.EventHandler(this.passwordField_TextChanged);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Location = new System.Drawing.Point(20, 374);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(175, 43);
            this.CloseButton.TabIndex = 14;
            this.CloseButton.Text = "Exit";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CopyPassword
            // 
            this.CopyPassword.BackColor = System.Drawing.Color.LightSeaGreen;
            this.CopyPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CopyPassword.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.CopyPassword.Location = new System.Drawing.Point(543, 283);
            this.CopyPassword.Name = "CopyPassword";
            this.CopyPassword.Size = new System.Drawing.Size(183, 43);
            this.CopyPassword.TabIndex = 15;
            this.CopyPassword.Text = "Copy password";
            this.CopyPassword.UseVisualStyleBackColor = false;
            this.CopyPassword.Click += new System.EventHandler(this.CopyPassword_Click);
            // 
            // label8
            // 
            this.label8.AccessibleName = "";
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(28, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(509, 33);
            this.label8.TabIndex = 16;
            this.label8.Text = "Fast password copying (button on the right):";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // DeletePassword
            // 
            this.DeletePassword.BackColor = System.Drawing.Color.LightSeaGreen;
            this.DeletePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeletePassword.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.DeletePassword.Location = new System.Drawing.Point(278, 374);
            this.DeletePassword.Name = "DeletePassword";
            this.DeletePassword.Size = new System.Drawing.Size(190, 43);
            this.DeletePassword.TabIndex = 17;
            this.DeletePassword.Text = "Delete password";
            this.DeletePassword.UseVisualStyleBackColor = false;
            this.DeletePassword.Click += new System.EventHandler(this.DeletePassword_Click);
            // 
            // FullReset
            // 
            this.FullReset.BackColor = System.Drawing.Color.LightSeaGreen;
            this.FullReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FullReset.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.FullReset.Location = new System.Drawing.Point(582, 12);
            this.FullReset.Name = "FullReset";
            this.FullReset.Size = new System.Drawing.Size(144, 43);
            this.FullReset.TabIndex = 18;
            this.FullReset.Text = "Reset all";
            this.FullReset.UseVisualStyleBackColor = false;
            this.FullReset.Click += new System.EventHandler(this.FullReset_Click);
            // 
            // lengthField
            // 
            this.lengthField.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lengthField.Location = new System.Drawing.Point(485, 86);
            this.lengthField.MaxLength = 3;
            this.lengthField.Name = "lengthField";
            this.lengthField.Size = new System.Drawing.Size(46, 32);
            this.lengthField.TabIndex = 19;
            this.lengthField.TextChanged += new System.EventHandler(this.lengthField_TextChanged_1);
            // 
            // label9
            // 
            this.label9.AccessibleName = "";
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.BurlyWood;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(310, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 33);
            this.label9.TabIndex = 20;
            this.label9.Text = "lowercase";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cbLower
            // 
            this.cbLower.AutoSize = true;
            this.cbLower.BackColor = System.Drawing.Color.Transparent;
            this.cbLower.Location = new System.Drawing.Point(437, 193);
            this.cbLower.Name = "cbLower";
            this.cbLower.Size = new System.Drawing.Size(15, 14);
            this.cbLower.TabIndex = 21;
            this.cbLower.UseVisualStyleBackColor = false;
            this.cbLower.CheckedChanged += new System.EventHandler(this.cbLower_CheckedChanged);
            // 
            // isCopied
            // 
            this.isCopied.AccessibleName = "";
            this.isCopied.AutoSize = true;
            this.isCopied.BackColor = System.Drawing.Color.RosyBrown;
            this.isCopied.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.isCopied.ForeColor = System.Drawing.Color.Black;
            this.isCopied.Location = new System.Drawing.Point(603, 329);
            this.isCopied.Name = "isCopied";
            this.isCopied.Size = new System.Drawing.Size(71, 23);
            this.isCopied.TabIndex = 22;
            this.isCopied.Text = "(Copied)";
            this.isCopied.Click += new System.EventHandler(this.isCopied_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(123)))), ((int)(((byte)(145)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.isCopied);
            this.panel1.Controls.Add(this.cbLower);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lengthField);
            this.panel1.Controls.Add(this.FullReset);
            this.panel1.Controls.Add(this.DeletePassword);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.CopyPassword);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.passwordField);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cbSpecial);
            this.panel1.Controls.Add(this.cbUpper);
            this.panel1.Controls.Add(this.cbDigit);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.StartButton);
            this.panel1.Location = new System.Drawing.Point(-11, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 759);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PassGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 426);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PassGen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbDigit;
        private System.Windows.Forms.CheckBox cbUpper;
        private System.Windows.Forms.CheckBox cbSpecial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button CopyPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button DeletePassword;
        private System.Windows.Forms.Button FullReset;
        private System.Windows.Forms.TextBox lengthField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbLower;
        private System.Windows.Forms.Label isCopied;
        private System.Windows.Forms.Panel panel1;
    }
}


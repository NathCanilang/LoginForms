﻿namespace LoginForms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.UsernameTxtbox = new System.Windows.Forms.TextBox();
            this.PasswordTxtbox = new System.Windows.Forms.TextBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.RememberCheckBox = new System.Windows.Forms.CheckBox();
            this.ForPasslbl = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CreateLbl = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.PictureBox();
            this.Show = new System.Windows.Forms.PictureBox();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.BackgroundPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(87)))), ((int)(((byte)(85)))));
            this.Loginbtn.Font = new System.Drawing.Font("Simple Handmade", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.Color.White;
            this.Loginbtn.Location = new System.Drawing.Point(92, 266);
            this.Loginbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(157, 40);
            this.Loginbtn.TabIndex = 4;
            this.Loginbtn.Text = "Log-In";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(87)))), ((int)(((byte)(85)))));
            this.Clearbtn.Font = new System.Drawing.Font("Simple Handmade", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbtn.ForeColor = System.Drawing.Color.White;
            this.Clearbtn.Location = new System.Drawing.Point(20, 214);
            this.Clearbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(60, 22);
            this.Clearbtn.TabIndex = 5;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = false;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // UsernameTxtbox
            // 
            this.UsernameTxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(87)))), ((int)(((byte)(85)))));
            this.UsernameTxtbox.Font = new System.Drawing.Font("Simple Handmade", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxtbox.ForeColor = System.Drawing.Color.White;
            this.UsernameTxtbox.Location = new System.Drawing.Point(20, 84);
            this.UsernameTxtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsernameTxtbox.Multiline = true;
            this.UsernameTxtbox.Name = "UsernameTxtbox";
            this.UsernameTxtbox.Size = new System.Drawing.Size(203, 28);
            this.UsernameTxtbox.TabIndex = 0;
            //this.UsernameTxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PasswordTxtbox
            // 
            this.PasswordTxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(87)))), ((int)(((byte)(85)))));
            this.PasswordTxtbox.Font = new System.Drawing.Font("Simple Handmade", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxtbox.ForeColor = System.Drawing.Color.White;
            this.PasswordTxtbox.Location = new System.Drawing.Point(20, 160);
            this.PasswordTxtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordTxtbox.Multiline = true;
            this.PasswordTxtbox.Name = "PasswordTxtbox";
            this.PasswordTxtbox.PasswordChar = '*';
            this.PasswordTxtbox.Size = new System.Drawing.Size(203, 28);
            this.PasswordTxtbox.TabIndex = 1;
           
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Font = new System.Drawing.Font("Simple Handmade", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLbl.ForeColor = System.Drawing.Color.White;
            this.UsernameLbl.Location = new System.Drawing.Point(16, 62);
            this.UsernameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(93, 23);
            this.UsernameLbl.TabIndex = 2;
            this.UsernameLbl.Text = "Username";
           // this.UsernameLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Simple Handmade", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.ForeColor = System.Drawing.Color.White;
            this.PasswordLbl.Location = new System.Drawing.Point(16, 137);
            this.PasswordLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(91, 23);
            this.PasswordLbl.TabIndex = 3;
            this.PasswordLbl.Text = "Password";
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(87)))), ((int)(((byte)(85)))));
            this.BackgroundPanel.Controls.Add(this.RememberCheckBox);
            this.BackgroundPanel.Controls.Add(this.ForPasslbl);
            this.BackgroundPanel.Controls.Add(this.panel1);
            this.BackgroundPanel.Controls.Add(this.Close);
            this.BackgroundPanel.Controls.Add(this.Show);
            this.BackgroundPanel.Controls.Add(this.Loginbtn);
            this.BackgroundPanel.Controls.Add(this.Clearbtn);
            this.BackgroundPanel.Controls.Add(this.UsernameTxtbox);
            this.BackgroundPanel.Controls.Add(this.UsernameLbl);
            this.BackgroundPanel.Controls.Add(this.PasswordLbl);
            this.BackgroundPanel.Controls.Add(this.PasswordTxtbox);
            this.BackgroundPanel.Location = new System.Drawing.Point(416, 0);
            this.BackgroundPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(338, 393);
            this.BackgroundPanel.TabIndex = 12;
          //  this.BackgroundPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BackgroundPanel_Paint);
            // 
            // ForPasslbl
            // 
            this.ForPasslbl.AutoSize = true;
            this.ForPasslbl.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForPasslbl.Location = new System.Drawing.Point(129, 189);
            this.ForPasslbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ForPasslbl.Name = "ForPasslbl";
            this.ForPasslbl.Size = new System.Drawing.Size(107, 13);
            this.ForPasslbl.TabIndex = 12;
            this.ForPasslbl.TabStop = true;
            this.ForPasslbl.Text = "Forgot Password?";
            this.ForPasslbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForPasslbl_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.CreateLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 358);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 32);
            this.panel1.TabIndex = 11;
            // 
            // CreateLbl
            // 
            this.CreateLbl.AutoSize = true;
            this.CreateLbl.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateLbl.Location = new System.Drawing.Point(165, 0);
            this.CreateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CreateLbl.Name = "CreateLbl";
            this.CreateLbl.Size = new System.Drawing.Size(116, 17);
            this.CreateLbl.TabIndex = 1;
            this.CreateLbl.TabStop = true;
            this.CreateLbl.Text = "Create Account";
            this.CreateLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateLbl_LinkClicked);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Account?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Close
            // 
            this.Close.Image = global::LoginForms.Properties.Resources.ClosePassword;
            this.Close.Location = new System.Drawing.Point(226, 160);
            this.Close.Margin = new System.Windows.Forms.Padding(2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(33, 28);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close.TabIndex = 10;
            this.Close.TabStop = false;
            this.Close.Visible = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Show
            // 
            this.Show.Image = global::LoginForms.Properties.Resources.ShowPassword;
            this.Show.Location = new System.Drawing.Point(225, 160);
            this.Show.Margin = new System.Windows.Forms.Padding(2);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(34, 28);
            this.Show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Show.TabIndex = 9;
            this.Show.TabStop = false;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // LogoPicture
            // 
            this.LogoPicture.Image = global::LoginForms.Properties.Resources.Moonbase_login3;
            this.LogoPicture.Location = new System.Drawing.Point(0, 0);
            this.LogoPicture.Margin = new System.Windows.Forms.Padding(2);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(418, 393);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPicture.TabIndex = 11;
            this.LogoPicture.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 388);
            this.Controls.Add(this.BackgroundPanel);
            this.Controls.Add(this.LogoPicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Login Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTxtbox;
        private System.Windows.Forms.TextBox PasswordTxtbox;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox Show;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel CreateLbl;
        private System.Windows.Forms.LinkLabel ForPasslbl;
        private System.Windows.Forms.CheckBox RememberCheckBox;
    }
}


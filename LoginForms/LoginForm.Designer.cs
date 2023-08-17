namespace LoginForms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.PictureBox();
            this.Show = new System.Windows.Forms.PictureBox();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.CreateLbl = new System.Windows.Forms.LinkLabel();
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
            this.Loginbtn.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.Color.White;
            this.Loginbtn.Location = new System.Drawing.Point(120, 311);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(209, 49);
            this.Loginbtn.TabIndex = 4;
            this.Loginbtn.Text = "Log-In";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(87)))), ((int)(((byte)(85)))));
            this.Clearbtn.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbtn.ForeColor = System.Drawing.Color.White;
            this.Clearbtn.Location = new System.Drawing.Point(27, 237);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(80, 27);
            this.Clearbtn.TabIndex = 5;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = false;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // UsernameTxtbox
            // 
            this.UsernameTxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(87)))), ((int)(((byte)(85)))));
            this.UsernameTxtbox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxtbox.ForeColor = System.Drawing.Color.White;
            this.UsernameTxtbox.Location = new System.Drawing.Point(27, 104);
            this.UsernameTxtbox.Multiline = true;
            this.UsernameTxtbox.Name = "UsernameTxtbox";
            this.UsernameTxtbox.Size = new System.Drawing.Size(269, 34);
            this.UsernameTxtbox.TabIndex = 0;
            this.UsernameTxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PasswordTxtbox
            // 
            this.PasswordTxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(87)))), ((int)(((byte)(85)))));
            this.PasswordTxtbox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxtbox.ForeColor = System.Drawing.Color.White;
            this.PasswordTxtbox.Location = new System.Drawing.Point(27, 197);
            this.PasswordTxtbox.Multiline = true;
            this.PasswordTxtbox.Name = "PasswordTxtbox";
            this.PasswordTxtbox.PasswordChar = '*';
            this.PasswordTxtbox.Size = new System.Drawing.Size(269, 34);
            this.PasswordTxtbox.TabIndex = 1;
            this.PasswordTxtbox.TextChanged += new System.EventHandler(this.Passwordtxtbox_TextChanged);
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLbl.ForeColor = System.Drawing.Color.White;
            this.UsernameLbl.Location = new System.Drawing.Point(22, 76);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(124, 25);
            this.UsernameLbl.TabIndex = 2;
            this.UsernameLbl.Text = "Username";
            this.UsernameLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.ForeColor = System.Drawing.Color.White;
            this.PasswordLbl.Location = new System.Drawing.Point(22, 169);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(122, 25);
            this.PasswordLbl.TabIndex = 3;
            this.PasswordLbl.Text = "Password";
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(87)))), ((int)(((byte)(85)))));
            this.BackgroundPanel.Controls.Add(this.panel1);
            this.BackgroundPanel.Controls.Add(this.Close);
            this.BackgroundPanel.Controls.Add(this.Show);
            this.BackgroundPanel.Controls.Add(this.Loginbtn);
            this.BackgroundPanel.Controls.Add(this.Clearbtn);
            this.BackgroundPanel.Controls.Add(this.UsernameTxtbox);
            this.BackgroundPanel.Controls.Add(this.UsernameLbl);
            this.BackgroundPanel.Controls.Add(this.PasswordLbl);
            this.BackgroundPanel.Controls.Add(this.PasswordTxtbox);
            this.BackgroundPanel.Location = new System.Drawing.Point(554, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(451, 484);
            this.BackgroundPanel.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.CreateLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 441);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 40);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Account?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Close
            // 
            this.Close.Image = global::LoginForms.Properties.Resources.ClosePassword;
            this.Close.Location = new System.Drawing.Point(302, 197);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(44, 34);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close.TabIndex = 10;
            this.Close.TabStop = false;
            this.Close.Visible = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Show
            // 
            this.Show.Image = global::LoginForms.Properties.Resources.ShowPassword;
            this.Show.Location = new System.Drawing.Point(300, 197);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(46, 34);
            this.Show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Show.TabIndex = 9;
            this.Show.TabStop = false;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // LogoPicture
            // 
            this.LogoPicture.Image = global::LoginForms.Properties.Resources.Moonbase_login3;
            this.LogoPicture.Location = new System.Drawing.Point(0, 0);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(558, 484);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPicture.TabIndex = 11;
            this.LogoPicture.TabStop = false;
            // 
            // CreateLbl
            // 
            this.CreateLbl.AutoSize = true;
            this.CreateLbl.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateLbl.Location = new System.Drawing.Point(220, 0);
            this.CreateLbl.Name = "CreateLbl";
            this.CreateLbl.Size = new System.Drawing.Size(140, 20);
            this.CreateLbl.TabIndex = 1;
            this.CreateLbl.TabStop = true;
            this.CreateLbl.Text = "Create Account";
            this.CreateLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateLbl_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 477);
            this.Controls.Add(this.BackgroundPanel);
            this.Controls.Add(this.LogoPicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}


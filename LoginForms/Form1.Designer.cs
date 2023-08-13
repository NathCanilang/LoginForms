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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.UsernameTxtbox = new System.Windows.Forms.TextBox();
            this.PasswordTxtbox = new System.Windows.Forms.TextBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.PictureBox();
            this.Show = new System.Windows.Forms.PictureBox();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.BackgroundPanel.SuspendLayout();
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
            this.Loginbtn.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.Location = new System.Drawing.Point(128, 381);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(209, 49);
            this.Loginbtn.TabIndex = 4;
            this.Loginbtn.Text = "Log-In";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbtn.Location = new System.Drawing.Point(26, 296);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(80, 27);
            this.Clearbtn.TabIndex = 5;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // UsernameTxtbox
            // 
            this.UsernameTxtbox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxtbox.Location = new System.Drawing.Point(26, 163);
            this.UsernameTxtbox.Multiline = true;
            this.UsernameTxtbox.Name = "UsernameTxtbox";
            this.UsernameTxtbox.Size = new System.Drawing.Size(269, 34);
            this.UsernameTxtbox.TabIndex = 0;
            this.UsernameTxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PasswordTxtbox
            // 
            this.PasswordTxtbox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxtbox.Location = new System.Drawing.Point(26, 256);
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
            this.UsernameLbl.Location = new System.Drawing.Point(21, 135);
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
            this.PasswordLbl.Location = new System.Drawing.Point(21, 228);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(122, 25);
            this.PasswordLbl.TabIndex = 3;
            this.PasswordLbl.Text = "Password";
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(92)))));
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
            this.BackgroundPanel.Size = new System.Drawing.Size(451, 475);
            this.BackgroundPanel.TabIndex = 12;
            // 
            // Close
            // 
            this.Close.Image = global::LoginForms.Properties.Resources.ClosePassword;
            this.Close.Location = new System.Drawing.Point(302, 256);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(45, 34);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close.TabIndex = 10;
            this.Close.TabStop = false;
            this.Close.Visible = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Show
            // 
            this.Show.Image = global::LoginForms.Properties.Resources.ShowPassword;
            this.Show.Location = new System.Drawing.Point(301, 256);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(46, 34);
            this.Show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Show.TabIndex = 9;
            this.Show.TabStop = false;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // LogoPicture
            // 
            this.LogoPicture.Image = global::LoginForms.Properties.Resources.Moonbase_login1;
            this.LogoPicture.Location = new System.Drawing.Point(0, 0);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(558, 484);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPicture.TabIndex = 11;
            this.LogoPicture.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 477);
            this.Controls.Add(this.BackgroundPanel);
            this.Controls.Add(this.LogoPicture);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Login Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
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
        private new System.Windows.Forms.PictureBox Close;
        private new System.Windows.Forms.PictureBox Show;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Panel BackgroundPanel;
    }
}


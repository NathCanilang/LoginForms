namespace LoginForms
{
    partial class CreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateForm));
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.Usernamelbl = new System.Windows.Forms.Label();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.MPINBox = new System.Windows.Forms.TextBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameBox
            // 
            this.UsernameBox.BackColor = System.Drawing.Color.Tomato;
            this.UsernameBox.Font = new System.Drawing.Font("Simple Handmade", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameBox.Location = new System.Drawing.Point(126, 214);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsernameBox.Multiline = true;
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(237, 35);
            this.UsernameBox.TabIndex = 0;
            this.UsernameBox.TextChanged += new System.EventHandler(this.UsernameBox_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.Color.Tomato;
            this.PasswordBox.Font = new System.Drawing.Font("Simple Handmade", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(126, 259);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordBox.Multiline = true;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(237, 35);
            this.PasswordBox.TabIndex = 1;
            // 
            // Usernamelbl
            // 
            this.Usernamelbl.AutoSize = true;
            this.Usernamelbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(87)))), ((int)(((byte)(85)))));
            this.Usernamelbl.Font = new System.Drawing.Font("Simple Handmade", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernamelbl.ForeColor = System.Drawing.Color.White;
            this.Usernamelbl.Location = new System.Drawing.Point(31, 221);
            this.Usernamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(93, 23);
            this.Usernamelbl.TabIndex = 2;
            this.Usernamelbl.Text = "Username";
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(87)))), ((int)(((byte)(85)))));
            this.Passwordlbl.Font = new System.Drawing.Font("Simple Handmade", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlbl.ForeColor = System.Drawing.Color.White;
            this.Passwordlbl.Location = new System.Drawing.Point(33, 265);
            this.Passwordlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(91, 23);
            this.Passwordlbl.TabIndex = 3;
            this.Passwordlbl.Text = "Password";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(68, 357);
            this.CreateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(86, 20);
            this.CreateBtn.TabIndex = 4;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(268, 341);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(56, 19);
            this.BackBtn.TabIndex = 5;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click_1);
            // 
            // MPINBox
            // 
            this.MPINBox.BackColor = System.Drawing.Color.Tomato;
            this.MPINBox.Font = new System.Drawing.Font("Simple Handmade", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MPINBox.Location = new System.Drawing.Point(126, 302);
            this.MPINBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MPINBox.Multiline = true;
            this.MPINBox.Name = "MPINBox";
            this.MPINBox.Size = new System.Drawing.Size(237, 35);
            this.MPINBox.TabIndex = 6;
            this.MPINBox.TextChanged += new System.EventHandler(this.MPINBox_TextChanged);
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(87)))), ((int)(((byte)(85)))));
            this.EmailLbl.Font = new System.Drawing.Font("Simple Handmade", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLbl.ForeColor = System.Drawing.Color.White;
            this.EmailLbl.Location = new System.Drawing.Point(64, 309);
            this.EmailLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(60, 23);
            this.EmailLbl.TabIndex = 7;
            this.EmailLbl.Text = "E-mail";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoginForms.Properties.Resources.TUBA_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 392);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 388);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.MPINBox);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.Passwordlbl);
            this.Controls.Add(this.Usernamelbl);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "CreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label Usernamelbl;
        private System.Windows.Forms.Label Passwordlbl;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TextBox MPINBox;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
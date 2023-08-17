namespace LoginForms
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.Usernamelbl = new System.Windows.Forms.Label();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(220, 117);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(186, 22);
            this.UsernameBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(220, 191);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(186, 22);
            this.PasswordBox.TabIndex = 1;
            // 
            // Usernamelbl
            // 
            this.Usernamelbl.AutoSize = true;
            this.Usernamelbl.Location = new System.Drawing.Point(217, 98);
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(70, 16);
            this.Usernamelbl.TabIndex = 2;
            this.Usernamelbl.Text = "Username";
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.Location = new System.Drawing.Point(217, 172);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(67, 16);
            this.Passwordlbl.TabIndex = 3;
            this.Passwordlbl.Text = "Password";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(246, 272);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(114, 25);
            this.CreateBtn.TabIndex = 4;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(288, 377);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 5;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 506);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.Passwordlbl);
            this.Controls.Add(this.Usernamelbl);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Form2_Load);
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
    }
}
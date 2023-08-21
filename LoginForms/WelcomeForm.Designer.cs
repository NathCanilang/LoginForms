namespace LoginForms
{
    partial class miscellaneous
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(miscellaneous));
            this.BackBtn = new System.Windows.Forms.Button();
            this.welcomeFormBackPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.welcomeFormBackPic)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(21)))), ((int)(((byte)(49)))));
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Simple Handmade", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(0, 103);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(108, 44);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // welcomeFormBackPic
            // 
            this.welcomeFormBackPic.Image = global::LoginForms.Properties.Resources.TUBA_Greetings;
            this.welcomeFormBackPic.Location = new System.Drawing.Point(0, 0);
            this.welcomeFormBackPic.Name = "welcomeFormBackPic";
            this.welcomeFormBackPic.Size = new System.Drawing.Size(859, 483);
            this.welcomeFormBackPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.welcomeFormBackPic.TabIndex = 1;
            this.welcomeFormBackPic.TabStop = false;
            // 
            // miscellaneous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 478);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.welcomeFormBackPic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "miscellaneous";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.miscellaneous_Load);
            ((System.ComponentModel.ISupportInitialize)(this.welcomeFormBackPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.PictureBox welcomeFormBackPic;
    }
}
namespace LoginForms
{
    partial class TableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableForm));
            this.ApproveBtn = new System.Windows.Forms.Button();
            this.RejectBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ApprovalTable = new System.Windows.Forms.DataGridView();
            this.UsernameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableFormBackPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ApprovalTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableFormBackPic)).BeginInit();
            this.SuspendLayout();
            // 
            // ApproveBtn
            // 
            this.ApproveBtn.BackColor = System.Drawing.Color.Black;
            this.ApproveBtn.FlatAppearance.BorderSize = 2;
            this.ApproveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApproveBtn.Font = new System.Drawing.Font("Simple Handmade", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApproveBtn.ForeColor = System.Drawing.Color.White;
            this.ApproveBtn.Location = new System.Drawing.Point(619, 60);
            this.ApproveBtn.Name = "ApproveBtn";
            this.ApproveBtn.Size = new System.Drawing.Size(118, 40);
            this.ApproveBtn.TabIndex = 1;
            this.ApproveBtn.Text = "Approve";
            this.ApproveBtn.UseVisualStyleBackColor = false;
            this.ApproveBtn.Click += new System.EventHandler(this.ApproveBtn_Click);
            // 
            // RejectBtn
            // 
            this.RejectBtn.BackColor = System.Drawing.Color.Black;
            this.RejectBtn.FlatAppearance.BorderSize = 2;
            this.RejectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RejectBtn.Font = new System.Drawing.Font("Simple Handmade", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RejectBtn.ForeColor = System.Drawing.Color.White;
            this.RejectBtn.Location = new System.Drawing.Point(619, 147);
            this.RejectBtn.Name = "RejectBtn";
            this.RejectBtn.Size = new System.Drawing.Size(118, 40);
            this.RejectBtn.TabIndex = 2;
            this.RejectBtn.Text = "Reject";
            this.RejectBtn.UseVisualStyleBackColor = false;
            this.RejectBtn.Click += new System.EventHandler(this.RejectBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Black;
            this.BackBtn.FlatAppearance.BorderSize = 2;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Simple Handmade", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(619, 239);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(118, 40);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ApprovalTable
            // 
            this.ApprovalTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ApprovalTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApprovalTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsernameCol,
            this.PasswordCol,
            this.EmailCol});
            this.ApprovalTable.Location = new System.Drawing.Point(119, 60);
            this.ApprovalTable.Name = "ApprovalTable";
            this.ApprovalTable.ReadOnly = true;
            this.ApprovalTable.RowHeadersWidth = 51;
            this.ApprovalTable.RowTemplate.Height = 24;
            this.ApprovalTable.Size = new System.Drawing.Size(494, 219);
            this.ApprovalTable.TabIndex = 4;
            // 
            // UsernameCol
            // 
            this.UsernameCol.HeaderText = "Username";
            this.UsernameCol.MinimumWidth = 6;
            this.UsernameCol.Name = "UsernameCol";
            this.UsernameCol.ReadOnly = true;
            // 
            // PasswordCol
            // 
            this.PasswordCol.HeaderText = "Password";
            this.PasswordCol.MinimumWidth = 6;
            this.PasswordCol.Name = "PasswordCol";
            this.PasswordCol.ReadOnly = true;
            // 
            // EmailCol
            // 
            this.EmailCol.HeaderText = "E-mail";
            this.EmailCol.MinimumWidth = 6;
            this.EmailCol.Name = "EmailCol";
            this.EmailCol.ReadOnly = true;
            // 
            // tableFormBackPic
            // 
            this.tableFormBackPic.Image = global::LoginForms.Properties.Resources.TUBA_OuterSpace;
            this.tableFormBackPic.Location = new System.Drawing.Point(0, 0);
            this.tableFormBackPic.Name = "tableFormBackPic";
            this.tableFormBackPic.Size = new System.Drawing.Size(865, 358);
            this.tableFormBackPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tableFormBackPic.TabIndex = 5;
            this.tableFormBackPic.TabStop = false;
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 357);
            this.Controls.Add(this.ApprovalTable);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.RejectBtn);
            this.Controls.Add(this.ApproveBtn);
            this.Controls.Add(this.tableFormBackPic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Approval";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ApprovalTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableFormBackPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ApproveBtn;
        private System.Windows.Forms.Button RejectBtn;
        private System.Windows.Forms.Button BackBtn;
        public System.Windows.Forms.DataGridView ApprovalTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsernameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailCol;
        private System.Windows.Forms.PictureBox tableFormBackPic;
    }
}
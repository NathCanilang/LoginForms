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
            this.ApproveBtn = new System.Windows.Forms.Button();
            this.RejectBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ApprovalTable = new System.Windows.Forms.DataGridView();
            this.UsernameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackupTable = new System.Windows.Forms.DataGridView();
            this.UsernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ApprovalTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackupTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ApproveBtn
            // 
            this.ApproveBtn.Location = new System.Drawing.Point(151, 283);
            this.ApproveBtn.Name = "ApproveBtn";
            this.ApproveBtn.Size = new System.Drawing.Size(75, 23);
            this.ApproveBtn.TabIndex = 1;
            this.ApproveBtn.Text = "Approve";
            this.ApproveBtn.UseVisualStyleBackColor = true;
            this.ApproveBtn.Click += new System.EventHandler(this.ApproveBtn_Click);
            // 
            // RejectBtn
            // 
            this.RejectBtn.Location = new System.Drawing.Point(273, 283);
            this.RejectBtn.Name = "RejectBtn";
            this.RejectBtn.Size = new System.Drawing.Size(75, 23);
            this.RejectBtn.TabIndex = 2;
            this.RejectBtn.Text = "Reject";
            this.RejectBtn.UseVisualStyleBackColor = true;
            this.RejectBtn.Click += new System.EventHandler(this.RejectBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(400, 283);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
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
            this.ApprovalTable.Location = new System.Drawing.Point(137, 57);
            this.ApprovalTable.Name = "ApprovalTable";
            this.ApprovalTable.RowHeadersWidth = 51;
            this.ApprovalTable.RowTemplate.Height = 24;
            this.ApprovalTable.Size = new System.Drawing.Size(354, 203);
            this.ApprovalTable.TabIndex = 4;
            this.ApprovalTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ApporvalTable_CellContentClick);
            // 
            // UsernameCol
            // 
            this.UsernameCol.HeaderText = "Username";
            this.UsernameCol.MinimumWidth = 6;
            this.UsernameCol.Name = "UsernameCol";
            // 
            // PasswordCol
            // 
            this.PasswordCol.HeaderText = "Password";
            this.PasswordCol.MinimumWidth = 6;
            this.PasswordCol.Name = "PasswordCol";
            // 
            // EmailCol
            // 
            this.EmailCol.HeaderText = "E-mail";
            this.EmailCol.MinimumWidth = 6;
            this.EmailCol.Name = "EmailCol";
            // 
            // BackupTable
            // 
            this.BackupTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BackupTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsernameColumn,
            this.Password,
            this.Email});
            this.BackupTable.Location = new System.Drawing.Point(541, 57);
            this.BackupTable.Name = "BackupTable";
            this.BackupTable.RowHeadersWidth = 51;
            this.BackupTable.RowTemplate.Height = 24;
            this.BackupTable.Size = new System.Drawing.Size(93, 203);
            this.BackupTable.TabIndex = 5;
            // 
            // UsernameColumn
            // 
            this.UsernameColumn.HeaderText = "Username";
            this.UsernameColumn.MinimumWidth = 6;
            this.UsernameColumn.Name = "UsernameColumn";
            this.UsernameColumn.Width = 125;
            // 
            // Password
            // 
            this.Password.HeaderText = "PasswordColumn";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "EmailColumn";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 357);
            this.Controls.Add(this.BackupTable);
            this.Controls.Add(this.ApprovalTable);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.RejectBtn);
            this.Controls.Add(this.ApproveBtn);
            this.Name = "TableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ApprovalTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackupTable)).EndInit();
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
        private System.Windows.Forms.DataGridView BackupTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsernameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}
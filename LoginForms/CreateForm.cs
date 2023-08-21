using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace LoginForms

{
    public partial class CreateForm : Form
    {
        public static CreateForm instance;
        
        
        public string  user, pass;
        
        public CreateForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            bool usernameExists = false;

            foreach (DataGridViewRow row in TableForm.instance.ApprovalTable.Rows)
            {
                string rowUsername = row.Cells["UsernameCol"].Value?.ToString();
                if (rowUsername == UsernameBox.Text)
                {
                    usernameExists = true;
                    MessageBox.Show("Username Already Exists", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }

            if (string.IsNullOrEmpty(UsernameBox.Text) || string.IsNullOrEmpty(PasswordBox.Text) || string.IsNullOrEmpty(MPINBox.Text))
            {
                MessageBox.Show("Missing Information!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!usernameExists) 
            {
                string gmailAttatch = MPINBox.Text + "@gmail.com";
                TableForm.instance.AddUser(UsernameBox.Text, PasswordBox.Text, gmailAttatch);
                MessageBox.Show("Account Created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            UsernameBox.Clear();
            PasswordBox.Clear();
            MPINBox.Clear();
        }

        private void BackBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MPINBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Passwordlbl_Click(object sender, EventArgs e)
        {

        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

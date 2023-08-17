using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace LoginForms

{
    public partial class CreateForm : Form
    {
    public Dictionary<string, string> AccountsIdentity = new Dictionary<string, string>();
        TableForm tableForm;    
        
       
        public CreateForm(TableForm TF)
        {
            InitializeComponent();
            this.tableForm = TF;
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
            if (string.IsNullOrEmpty(UsernameBox.Text) || string.IsNullOrEmpty(PasswordBox.Text))
            {
                MessageBox.Show("Missing Information!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string hashedPassword = HashPassword(PasswordBox.Text);
               
                AccountsIdentity[UsernameBox.Text] = hashedPassword;
                MessageBox.Show("Account Created", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BackBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashBytes);
            }
        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

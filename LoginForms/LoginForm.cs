using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForms
{
    public partial class LoginForm : Form
    {
        string[] Username = { "Admin1", "Admin2" };
        string[] Password = { "admin123", "admin456" };
        Form loginForm = null;

        

        CreateForm form2 = new CreateForm();
        TableForm form3 = new TableForm();

        
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTxtbox.Text;
            string password = PasswordTxtbox.Text;
            CreateForm form = new CreateForm();
            TableForm tableForm = new TableForm();


            for (int i = 0; i < Username.Length; i++)
            {
                if (UsernameTxtbox.Text == Username[i] && PasswordTxtbox.Text == Password[i])
                {

                    if (i == 0 || i == 1) // Assuming Admin1 and Admin2 are admin users
                    {
                        loginForm = new TableForm();
                         tableForm = loginForm as TableForm;
                        if (tableForm != null)
                        {
                            tableForm.SetCreateFormInstance(form2);
                        }
                    }

                    break;
                    /*if (i == 0)
                    {
                        loginForm = new TableForm();
                        ///
                        tableForm = loginForm as TableForm;
                    }
                    else if (i == 1)
                    {
                        loginForm = new TableForm(); 
                    }
                    else if(tableForm != null)
                    {
                        tableForm.SetCreateFormInstance(form2);
                    }

                    break;*/
                }
            }

            if (loginForm != null)
            {
                MessageBox.Show("Login Complete.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.WindowState = FormWindowState.Minimized;
                loginForm.Show();
                this.WindowState = FormWindowState.Normal;
            }

            else if (Authenticate(username, password))
            {
                MessageBox.Show("Login Complete.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.WindowState = FormWindowState.Minimized;
                form2.Show();
                this.WindowState = FormWindowState.Normal;
            }
           
            else
            {
                MessageBox.Show("Invalid Credentials!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            UsernameTxtbox.Clear();
            PasswordTxtbox.Clear();
        }

        private void Passwordtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Show_Click(object sender, EventArgs e)
        {
            if (Close.Visible == false)
            {
                Show.Visible = false;
                Close.Visible = true;
                PasswordTxtbox.PasswordChar = '\0';
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            if (Show.Visible == false)
            {
                Close.Visible = false;
                Show.Visible = true;
                PasswordTxtbox.PasswordChar = '*';
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void CreateLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            form2 = new CreateForm();
            form2.ShowDialog();
            this.WindowState = FormWindowState.Normal;
        }
        private bool Authenticate(string username, string password)
        {
            if (form2.AccountsIdentity.TryGetValue(username, out string hashedPassword))
            {
                return VerifyPassword(password, hashedPassword);
            }
            return false;
        }
        private bool VerifyPassword(string password, string hashedPassword)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                string hashedInputPassword = Convert.ToBase64String(hashBytes);
                return hashedPassword == hashedInputPassword;
            }
        }

        private void BackgroundPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

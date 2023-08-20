using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForms
{
    public partial class LoginForm : Form
    {
        public static LoginForm instance;
        public Dictionary<string, string> AccountsIdentity = new Dictionary<string, string>();
        string[] adminUsernames = { "Admin1", "Admin2" };
        string[] adminPasswords = { "admin123", "admin456" };
        miscellaneous missform = new miscellaneous();
        CreateForm form2 = new CreateForm();
        TableForm form3 = new TableForm();
       
        //
         int attempts = 3;
         bool accessGranted = false;
        object lockObject = new object();

        public LoginForm()
        {
            InitializeComponent();
            instance = this;
            
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

            if (accessGranted)
            {
                MessageBox.Show("Access Granted!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form nextForm = form3; 
                this.WindowState = FormWindowState.Minimized;
                nextForm.ShowDialog();
                this.WindowState = FormWindowState.Normal;

                return;
            }

            for (int i = 0; i < adminUsernames.Length; i++)
            {
                if (username == adminUsernames[i] && password == adminPasswords[i])
                {
                    MessageBox.Show("Login Complete.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form nextForm;
                    if (i == 0)
                    {
                        nextForm = form3;
                    }
                    else
                    {
                        nextForm = missform;
                        missform.ShowDialog();
                    }

                    this.WindowState = FormWindowState.Minimized;
                    nextForm.ShowDialog();
                    this.WindowState = FormWindowState.Normal;

                    return;
                }
            }

            if (AccountsIdentity.TryGetValue(username, out string storedPassword))
            {
                if (password == storedPassword)
                {
                    MessageBox.Show("Login Complete.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.WindowState = FormWindowState.Minimized;
                    missform.Show();
                    this.WindowState = FormWindowState.Normal;
                }
                else
                {
                    MessageBox.Show("Invalid Credentials.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AttemptFailure();
                }
            }
            else
            {
                MessageBox.Show("Invalid Credentials!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AttemptFailure();
            }
        }

        private void AttemptFailure()
        {
            lock (lockObject)
            {
                attempts--;
                if (attempts > 0)
                {
                    MessageBox.Show($"Access Denied! Try again. {attempts} {(attempts > 1 ? "attempts" : "attempt")} remaining.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("No more attempts remaining.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Loginbtn.Enabled = false;
                }
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
       
        private void BackgroundPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void AddUserToDictionary(string username, string password)
        {

          AccountsIdentity.Add(username, password);

        }

        private void ForPasslbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.WindowState = FormWindowState.Minimized;
            ForgetPasswordForm forgetpasswordform = new ForgetPasswordForm();
            forgetpasswordform.ShowDialog();
            this.WindowState = FormWindowState.Normal;
        }
    }
}

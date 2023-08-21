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
        
        private System.Windows.Forms.Timer cooldownTimer;

        string[] adminUsernames = { "Admin1", "Admin2" };
        string[] adminPasswords = { "admin123", "admin456" };

        miscellaneous missform = new miscellaneous();
        CreateForm form2 = new CreateForm();
        TableForm form3 = new TableForm();
       
        int attempts = 3;
        bool accessGranted = false;
        object lockObject = new object();
        bool cooldownActive = false;

        public LoginForm()
        {
            InitializeComponent();
            instance = this;
            
            cooldownTimer = new System.Windows.Forms.Timer();
            cooldownTimer.Interval = 10000; 
            cooldownTimer.Tick += CooldownTimer_Tick; 

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (cooldownActive)
            {
                MessageBox.Show("Cooldown period active. Please wait.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = UsernameTxtbox.Text;
            string password = PasswordTxtbox.Text;

            UsernameTxtbox.Clear();
            PasswordTxtbox.Clear();

            if (accessGranted)
            {
                MessageBox.Show("Access Granted!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form nextForm = form3;
                this.WindowState = FormWindowState.Minimized;
                nextForm.ShowDialog();
                this.WindowState = FormWindowState.Normal;

                return;
            }

            bool usernameCorrect = false;
            bool passwordCorrect = false;

            for (int i = 0; i < adminUsernames.Length; i++)
            {
                if (username == adminUsernames[i])
                {
                    usernameCorrect = true;
                    if (password == adminPasswords[i])
                    {
                        passwordCorrect = true;

                        MessageBox.Show("Login Complete.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Form nextForm;
                        if (i == 0)
                        {
                            nextForm = form3;
                        }
                        else
                        {
                            nextForm = missform;
                        }

                        this.WindowState = FormWindowState.Minimized;
                        nextForm.ShowDialog();
                        this.WindowState = FormWindowState.Normal;

                        return;
                    }
                    break;
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

                    return;
                }
                else
                {
                    MessageBox.Show("Invalid Password.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AttemptFailure();
                }
                return;
            }

                 if (!usernameCorrect && !passwordCorrect)
                {
                    MessageBox.Show("Invalid Username and Password.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AttemptFailure();
                    return;
                }
               else if (!usernameCorrect)
                {
                    MessageBox.Show("Invalid Credentials.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AttemptFailure();
                    return;
                }
                else if (!passwordCorrect)
                {
                    MessageBox.Show("Invalid Password.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AttemptFailure();
                    return;
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
                    MessageBox.Show("No more attempts remaining. 10 Seoconds Cooldown activated.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    StartCooldownTimer();
                }
            }
        }

        private void StartCooldownTimer()
        {
            cooldownActive = true;
            cooldownTimer.Start();
        }

        private void CooldownTimer_Tick(object sender, EventArgs e)
        {
            cooldownActive = false;
            cooldownTimer.Stop();
            attempts = 3; 
            MessageBox.Show("Cooldown period ended. You can try again now.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);  
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            UsernameTxtbox.Clear();
            PasswordTxtbox.Clear();
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
        
        private void CreateLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            form2 = new CreateForm();
            form2.ShowDialog();
            this.WindowState = FormWindowState.Normal;
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

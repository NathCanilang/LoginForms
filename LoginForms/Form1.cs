using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForms
{

    public partial class LoginForm : Form
    {
        string[] Username = { "Admin", "Host" };
        string[] Password = { "admin123", "host123" };

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
            
            bool isLoginSuccessful = false;

            for (int i = 0; i < Username.Length; i++)
            {
                if (UsernameTxtbox.Text == Username[i] && PasswordTxtbox.Text == Password[i])
                {
                    isLoginSuccessful = true;
                    break; 
                }
            }

            if (isLoginSuccessful)
            {
                MessageBox.Show("Login Complete.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form2 form = new Form2();
                form.ShowDialog();
                this.Close();
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

        private void BackgroundPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

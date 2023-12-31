﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForms
{
    public partial class ForgetPasswordForm : Form
    {
        public ForgetPasswordForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string VerifyUsername = UsernameVerificationBox.Text;
            string VerifyEmail = EmailVerificationBox.Text;

            TableForm.instance.CheckCredentials(VerifyUsername, VerifyEmail);

            UsernameVerificationBox.Clear();
            EmailVerificationBox.Clear();
        }

        private void ForgetPasswordForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

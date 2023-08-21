using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForms
{

    public partial class TableForm : Form
    {
        public static TableForm instance;

        public CreateForm createForms;

        string rowUsername;
        string rowPassword; 

        public TableForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void RejectBtn_Click(object sender, EventArgs e)
        {
            if (ApprovalTable.SelectedRows.Count > 0)
            {
                int selectedIndex = ApprovalTable.SelectedRows[0].Index;
                ApprovalTable.Rows.RemoveAt(selectedIndex);
            }
           
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void AddUser(string username, string password, string Email)
        {
            ApprovalTable.Rows.Add(username, password, Email);
        }

        private void ApproveBtn_Click(object sender, EventArgs e)
        {
            int selectedRowCount = ApprovalTable.SelectedRows.Count;

            if (selectedRowCount > 0)
            {
                foreach (DataGridViewRow selectedRow in ApprovalTable.SelectedRows)
                {
                    string selectedUsername = (string)selectedRow.Cells["UsernameCol"].Value;

                    if (LoginForm.instance.AccountsIdentity.ContainsKey(selectedUsername))
                    {
                        MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        LoginForm.instance.AddUserToDictionary(selectedUsername, (string)selectedRow.Cells["PasswordCol"].Value);
                        MessageBox.Show("Account Approved", "Approval", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        selectedRow.Visible = false; 
                    }
                }
            }
        }

        public void CheckCredentials(string username, string Email)
        {
            bool credentialsFound = false;
            string foundPassword = "";

            foreach (DataGridViewRow row in ApprovalTable.Rows)
            {
                string rowUsername = row.Cells["UsernameCol"].Value?.ToString();
                string rowEmail = row.Cells["EmailCol"].Value?.ToString();

                if (rowUsername == username && rowEmail == Email)
                {
                    credentialsFound = true;
                    foundPassword = row.Cells["PasswordCol"].Value.ToString();
                    break;
                }
            }

            if (credentialsFound)
            {
                MessageBox.Show("Your Password is: " + foundPassword, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid credentials.");
            }
        }
    }
}

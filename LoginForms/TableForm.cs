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
        private CreateForm createFormInstance;
        public CreateForm createForms;
        public TableForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        

        private void RejectBtn_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ApporvalTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void AddUser(string username, string password)
        {
            ApprovalTable.Rows.Add(username, password);
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            if (createForms != null)
            {
            ApprovalTable.DataSource = new BindingSource(createFormInstance.AccountsIdentity, null);
            }
        }
        public void SetCreateFormInstance(CreateForm form)
        {
            createFormInstance = form;
        }
    }
}

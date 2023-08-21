using System;
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
    public partial class miscellaneous : Form
    {
        public miscellaneous()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void miscellaneous_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
    }
}

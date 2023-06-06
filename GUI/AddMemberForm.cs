using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class AddMemberForm : Form
    {
        public AddMemberForm()
        {
            InitializeComponent();
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;
            this.Reset();
            this.Hide();
        }

        private void Reset()
        {
            TextBoxFirstname.Text = string.Empty;
            TextBoxLastname.Text = string.Empty;
        }
    }
}

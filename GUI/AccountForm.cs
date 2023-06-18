using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
        }


        private void AccountForm_SizeChanged(object sender, EventArgs e)
        {
            PanelLeft.Size = new Size(this.Width / 2, this.Height - 87);
            PanelLeft.Location = new Point(0, 87);

            PanelRight.Size = new Size(this.Width / 2, this.Height - 87);
            PanelRight.Location = new Point(this.Width / 2, 87);

            PanelUsername.Location = new Point(((this.Width / 2) - (PanelUsername.Width)) / 2, 0);

            PanelPassword.Location = new Point(((this.Width / 2) - (PanelPassword.Width)) / 2,0 );


        }

        private void PanelPassword_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

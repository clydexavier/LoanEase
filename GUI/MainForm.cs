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
    public partial class MainForm : Form
    {
        private LoginForm loginForm;
        public MainForm(LoginForm parent)
        {
            this.loginForm = parent;
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();
        }
    }
}

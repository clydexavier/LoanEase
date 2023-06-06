using LoanEase;
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
    public partial class BorrowerEditForm : Form
    {
        private Borrower selectedBorrower;
        public BorrowerEditForm()
        {
            InitializeComponent();
            foreach(Borrower b in Database.borrowers)
            {
                
            }
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            this.Reset();
            this.Hide();

        }

        private void Reset()
        {
            this.TextBoxFirstname.Text = string.Empty;
            this.TextBoxLastname.Text = string.Empty;
            this.ComboBoxIsMember.SelectedIndex = -1;
        }
    }
}

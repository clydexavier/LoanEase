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
    public partial class BorrowerAddForm : Form
    {
        public event EventHandler? AddBorrower;

        public BorrowerAddForm()
        {
            InitializeComponent();
            this.ComboBoxIsMember.SelectedIndex = 1;
           
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            Decimal amount;
            if(!decimal.TryParse(TextBoxAmount.Text, out amount)) 
            {
                MessageBox.Show("Invalid input");
            }

            Borrower b = new Borrower(TextBoxFirstname.Text, TextBoxLastname.Text, ComboBoxIsMember.SelectedIndex == 0, amount);

            Database.borrowers.Add(b);
            this.DialogResult = DialogResult.OK;
            AddBorrower?.Invoke(this, new EventArgs());
            this.Reset();
            this.Hide();
        }

        private void Reset()
        {
            TextBoxFirstname.Text= string.Empty;
            TextBoxLastname.Text= string.Empty;
            TextBoxAmount.Text= string.Empty;
            this.ComboBoxIsMember.SelectedIndex = 1;
        }

    }
}

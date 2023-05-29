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

namespace NewGUI
{
    public partial class AddLoanForm : Form
    {
        public event EventHandler AddLoan;
        public AddLoanForm()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(TextBoxFirstName.Text) || string.IsNullOrWhiteSpace(TextBoxLastname.Text) || string.IsNullOrWhiteSpace(TextBoxAmount.Text) || ComboBoxIsMember.SelectedIndex == -1)
            {
                MessageBox.Show("Input all the empty fields.");
                return;
            }
            bool isMember = ComboBoxIsMember.SelectedIndex == 0;
            Decimal amount;
            if(!decimal.TryParse(TextBoxAmount.Text, out amount ))
            {
                MessageBox.Show("Enter a valid amount");
                return;
            }
            Borrower b = new Borrower(TextBoxFirstName.Text, isMember, amount);
            Database.borrowers.Add(b);

            AddLoan?.Invoke(this, new EventArgs());

            this.Close();
        }
    }
}

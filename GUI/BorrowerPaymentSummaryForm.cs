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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GUI
{
    public partial class BorrowerPaymentSummaryForm : Form
    {
        public BorrowerPayForm ParentForm;

        public Borrower SelectedBorrower;

        
        public event EventHandler? PayBorrower;

        public BorrowerPaymentSummaryForm(BorrowerPayForm parent)
        {
            InitializeComponent();
            this.ParentForm = parent;

        }

        public void PopulateControls()
        {

            this.SelectedBorrower = ParentForm.selectedBorrower;
            LabelBorrowerName.Text = SelectedBorrower.FirstName + " " + SelectedBorrower.LastName;
            LabelCurrentBalance.Text = SelectedBorrower.loan.ToString("0.00");
            LabelPaymentAmount.Text = ParentForm.AmountPayed.ToString();
           
            ButtonPay.Text = "Pay PHP " + ParentForm.AmountPayed.ToString();

            if (ParentForm.AmountPayed > SelectedBorrower.loan)
            {
                LabelChange.Text = (ParentForm.AmountPayed - SelectedBorrower.loan).ToString();
                LabelAfterPaymentBalance.Text = "0.00";
            }
            else
            {
                LabelChange.Text = "0.00";
                LabelAfterPaymentBalance.Text = (SelectedBorrower.loan - ParentForm.AmountPayed).ToString("0.00");
            }
        }

        private void ButtonPay_Click(object sender, EventArgs e)
        {
            decimal previous_loan = SelectedBorrower.loan;
            decimal amount = ParentForm.AmountPayed;
            SelectedBorrower.pay(amount);

            Payment p = new Payment(SelectedBorrower.FirstName + " " + SelectedBorrower.LastName, DateTime.Now, previous_loan - SelectedBorrower.loan, SelectedBorrower.isMember);
            Database.Payments.Add(p);

            if (SelectedBorrower.loan <= 0)
            {
                Database.payed_borrowers.Add(SelectedBorrower);
                Database.borrowers.Remove(SelectedBorrower);
                SelectedBorrower = null;
            }

            
            
            PayBorrower?.Invoke(this, new EventArgs());

            this.DialogResult= DialogResult.OK;
            this.Reset();
            this.Hide();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            this.Reset();
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void Reset()
        {
            this.SelectedBorrower = null;
            LabelBorrowerName.Text = string.Empty;
            LabelCurrentBalance.Text = string.Empty;
            LabelPaymentAmount.Text = string.Empty;
            LabelAfterPaymentBalance.Text = string.Empty;
            LabelChange.Text = string.Empty;
            ButtonPay.Text = string.Empty;
        }
    }
}

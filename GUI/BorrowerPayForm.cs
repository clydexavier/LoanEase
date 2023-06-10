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
    public partial class BorrowerPayForm : Form
    {
        private static BorrowerPaymentSummaryForm BorrowerPaymentSummaryForm;

        private BorrowerForm? ParentForm;
        public event EventHandler? EditBorrower;
        public event EventHandler? PayBorrower;
        
        
        public  Borrower selectedBorrower;
        public Decimal AmountPayed; 

        public BorrowerPayForm(BorrowerForm parent)
        {
            InitializeComponent();
            BorrowerPaymentSummaryForm = new BorrowerPaymentSummaryForm(this);


            BorrowerPaymentSummaryForm.PayBorrower += PayBorrowerEvent;
            this.ParentForm = parent;
        }

        private void PayBorrowerEvent(object? sender, EventArgs e)
        {
            PayBorrower?.Invoke(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!decimal.TryParse(TextBoxAmount.Text, out AmountPayed) || AmountPayed < 0)
            {
                MessageBox.Show("Invalid amount entered");
                TextBoxAmount.Text = string.Empty;
                return;
            }

            selectedBorrower = ParentForm.selectedBorrower;

            
            BorrowerPaymentSummaryForm.PopulateControls();

            
            
            TextBoxAmount.Text = string.Empty;
            this.DialogResult= DialogResult.OK;
            this.Hide();
            BorrowerPaymentSummaryForm.ShowDialog();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            TextBoxAmount.Text = string.Empty;
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }
    }
}

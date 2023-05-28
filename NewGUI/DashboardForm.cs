using LoanEase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewGUI
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            Database.Init();

            //name, is member, borrowed time, loan, monthly
            DataGridViewBorrowers.Columns.Add("Name", "Name");
            DataGridViewBorrowers.Columns.Add("Is Member", "Is Member");
            DataGridViewBorrowers.Columns.Add("Date Borrowed", "Date Borrowed");
            DataGridViewBorrowers.Columns.Add("Loan Amount", "Loan Amount");
            DataGridViewBorrowers.Columns.Add("Monthly Interest", "Monthly Interest");

            populateBorrowers();
            
            //DataGridViewBorrowers.DataSource = Database.borrowers;
            
            //DataGridViewBorrowers.DataBind();
        }

        public void populateBorrowers()
        {
            DataGridViewBorrowers.Rows.Clear();
            foreach (Borrower b in Database.borrowers)
            {
                DataGridViewBorrowers.Rows.Add(b.name, b.isMember.ToString(), b.BorrowedTime, b.loan, b.monthlyInterest);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Form child = new AddLoanForm();
            child.Show();
            //this.Hide();
            
            
            
        }

        private void ButtonPay_Click(object sender, EventArgs e)
        {
            this.populateBorrowers();
        }
    }
}

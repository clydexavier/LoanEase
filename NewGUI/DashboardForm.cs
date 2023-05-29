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

        AddLoanForm child = new AddLoanForm();
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

            child.AddLoan += Trigger_Populate;
            
        }

        private void Trigger_Populate(object? sender, EventArgs e)
        {
            DataGridViewBorrowers.Rows.Clear();
            foreach (Borrower b in Database.borrowers)
            {
                DataGridViewBorrowers.Rows.Add(b.name, b.isMember.ToString(), b.BorrowedTime, b.loan, b.monthlyInterest);
            }
        }

        private void populateBorrowers()
        {
            DataGridViewBorrowers.Rows.Clear();
            foreach (Borrower b in Database.borrowers)
            {
                DataGridViewBorrowers.Rows.Add(b.name, b.isMember.ToString(), b.BorrowedTime, b.loan, b.monthlyInterest);
            }
        }

  

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            child.Show();
            //this.Hide();
            
            
            
        }

        private void ButtonPay_Click(object sender, EventArgs e)
        {
            this.populateBorrowers();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string search = TextBoxSearch.Text.ToLower();
            DataGridViewBorrowers.ClearSelection(); //clear previous selections

            foreach(DataGridViewRow row in DataGridViewBorrowers.Rows) 
            {
                string cellName = row.Cells[0].Value?.ToString().ToLower();

                if (cellName != null && cellName.Contains(search))
                {
                    foreach(DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.Yellow;
                        cell.Style.ForeColor = Color.Black;
                    }                   
                }
                else
                {
                    foreach(DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = DataGridViewBorrowers.DefaultCellStyle.BackColor;
                        cell.Style.ForeColor = DataGridViewBorrowers.DefaultCellStyle.ForeColor;
                    }
                }
            }
        }
    }
}

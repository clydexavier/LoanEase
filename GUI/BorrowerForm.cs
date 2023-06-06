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
    public partial class BorrowerForm : Form
    {
        
        //Forms
        public static BorrowerAddForm addBorrowerForm = new BorrowerAddForm();
        public static BorrowerEditForm editBorrowerForm = new BorrowerEditForm();

        public BorrowerForm()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            

            this.PopulateDataGrid();

            addBorrowerForm.AddBorrower += Add_PopulateDataGrid;

        }

        private void Add_PopulateDataGrid(object? sender, EventArgs e)
        {
            this.DGVBorrowers.Rows.Clear();
            foreach (Borrower b in Database.borrowers)
            {
                
                this.DGVBorrowers.Rows.Add(b.FirstName + " " + b.LastName, b.isMember ? "Yes" : "No", b.BorrowedTime.ToString("MMMM d, yyyy"), "PHP " + b.loan.ToString("0.00"), "PHP " + b.monthlyInterest.ToString("0.00"));
            }
        }
        private void PopulateDataGrid()
        {
            this.DGVBorrowers.Rows.Clear();
            foreach (Borrower b in Database.borrowers)
            {
                this.DGVBorrowers.Rows.Add(b.FirstName + " "+ b.LastName, b.isMember ? "Yes" : "No", b.BorrowedTime.ToString("MMMM d, yyyy"), "PHP " + b.loan.ToString("0.00"), "PHP " + b.monthlyInterest.ToString("0.00"));
            }
        }

        private void ButtonAddBorrower_Click(object sender, EventArgs e)
        {
            addBorrowerForm.Show();
           
        }

        private void DGVBorrowers_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if(e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.edit.Width;
                var h = Properties.Resources.edit.Height;

                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.edit, new Rectangle(x, y, h, w));
                e.Handled = true;
            }
            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.hand.Width;
                var h = Properties.Resources.hand.Height;

                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.hand, new Rectangle(x, y, h, w));
                e.Handled = true;
            }

        }

        private void DGVBorrowers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if(e.ColumnIndex == 5)
            {
                string[] name = DGVBorrowers.Rows[e.RowIndex].Cells[0].Value.ToString().Split(' ');

                editBorrowerForm.TextBoxFirstname.Text = string.Join(" ", name, 0, name.Length - 1);
                editBorrowerForm.TextBoxLastname.Text = name[name.Length - 1];
                editBorrowerForm.ComboBoxIsMember.SelectedIndex = DGVBorrowers.Rows[e.RowIndex].Cells[3].Value.ToString() == "Member"? 0: 1;
                editBorrowerForm.Show();
            }
            else if (e.ColumnIndex == 6) 
            {
                MessageBox.Show("Click Pay\n" + DGVBorrowers.Rows[e.RowIndex].Cells[0].Value);
            }
        }
    }
}

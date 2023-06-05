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
        public BorrowerForm()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            foreach(Borrower b in Database.borrowers)
            {
                this.DGVBorrowers.Rows.Add(b.name, b.isMember? "Yes": "No", b.BorrowedTime.ToString("MMMM d, yyyy"), "PHP "+ b.loan.ToString("0.00"), "PHP " + b.monthlyInterest.ToString("0.00"));
            }
        }

        private void ButtonAddBorrower_Click(object sender, EventArgs e)
        {
            
           
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
    }
}

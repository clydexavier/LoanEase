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
    public partial class MembersForm : Form
    {
        private static AddMemberForm addMemberForm = new AddMemberForm();
        public MembersForm()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            foreach(Borrower b in Database.borrowers)
            {
                if (!b.isMember) continue;

                this.DGVMembers.Rows.Add(b.FirstName + " " + b.LastName, b.BorrowedTime.ToString("MMMM d, yyyy"), "PHP " + b.loan.ToString("0.00"), "PHP " + b.monthlyInterest.ToString("0.00"));
            }
        }

        private void DGVMembers_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 4)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.edit.Width;
                var h = Properties.Resources.edit.Height;

                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;


                e.Graphics.DrawImage(Properties.Resources.edit, new Rectangle(x, y, h, w));
                e.Handled = true;
            }
        }

        private void ButtonAddMember_Click(object sender, EventArgs e)
        {
            addMemberForm.Show();

        }

        private void DGVMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 4)
            {
                MessageBox.Show("Click Edit\n" + DGVMembers.Rows[e.RowIndex].Cells[0].Value);
            }
            
        }
    }
}

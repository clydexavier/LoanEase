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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock= DockStyle.Fill;
            PopulateDueDate();
        }

        public void PopulateDueDate()
        {
            this.DGVBorrowers.Rows.Clear();
            var sortedBorrowers = Database.borrowers.OrderBy(obj => obj.BorrowedTime).ToList();
            foreach (Borrower b in sortedBorrowers)
            {
                this.DGVBorrowers.Rows.Add(b.FirstName + " " + b.LastName, b.isMember ? "Yes" : "No", b.BorrowedTime.AddDays(30).ToString("MMMM d, yyyy"), "PHP " + b.loan.ToString("0.00"), "PHP " + b.monthlyInterest.ToString("0.00"));
            }
            this.LabelBorrowers.Text = Database.borrowers.Count.ToString();
            this.LabelPayments.Text = "PHP " + Database.TotalPayments.ToString("0.00");
            this.LabelLended.Text = "PHP " + Database.TotalLended.ToString("0.00");
        }

        private void panel2_SizeChanged(object sender, EventArgs e)
        {
            this.LabelDueDate.Location = new Point((this.panel2.Width / 2) - (this.LabelDueDate.Width / 2), this.LabelDueDate.Location.Y);
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            int width = panel1.Width - 24;
            int interval = width / 3;

            //
            this.PanelBorrowers.Size = new Size((int)(panel1.Width / 3.573), (int)(panel1.Height / 2.29));
            this.PanelPayments.Size = new Size((int)(panel1.Width / 3.573) + 20,(int) (panel1.Height / 2.29));
            this.PanelLended.Size = new Size((int)(panel1.Width / 3.573), (int)(panel1.Height / 2.29));

            this.label1.Location = new Point((PanelBorrowers.Width / 2) - (label1.Width / 2),this.label1.Location.Y);
            this.LabelBorrowers.Location = new Point((PanelBorrowers.Width / 2) - (LabelBorrowers.Width / 2), this.LabelBorrowers.Location.Y);

            this.label4.Location = new Point((PanelPayments.Width / 2) - (label4.Width / 2), this.label4.Location.Y);
            this.LabelPayments.Location = new Point((PanelPayments.Width / 2) - (LabelPayments.Width / 2), this.LabelPayments.Location.Y);

            this.label6.Location = new Point((PanelLended.Width / 2) - (label6.Width / 2), this.label6.Location.Y);
            this.LabelLended.Location = new Point((PanelLended.Width / 2) - (LabelLended.Width / 2), this.LabelLended.Location.Y);



            //left side most
            this.PanelBorrowers.Location = new Point(24, this.PanelBorrowers.Location.Y);

            //middle
            this.PanelPayments.Location = new Point((panel1.Width/2)- (this.PanelPayments.Width / 2) , this.PanelPayments.Location.Y);

            //right side most
            this.PanelLended.Location = new Point(panel1.Width - this.PanelLended.Width - 24, this.PanelLended.Location.Y);



        }
    }
}

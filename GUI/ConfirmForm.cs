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

using BCryptNet = BCrypt.Net.BCrypt;

namespace GUI
{
    public partial class ConfirmForm : Form
    {
        public event EventHandler? DeleteBorrower;
        public ConfirmForm(Form parent)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!BCryptNet.Verify(TextBoxAmount.Text, Database.Lender.password) )
            {
                this.DialogResult = DialogResult.Cancel;
                MessageBox.Show("Incorrect password.");

                TextBoxAmount.Text = string.Empty;
                return;
            }

            this.DialogResult = DialogResult.OK;
            DeleteBorrower?.Invoke(this, new EventArgs());
            MessageBox.Show("Successfully deleted.");

            TextBoxAmount.Text = string.Empty;
            this.Hide();
            
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            TextBoxAmount.Text = string.Empty;
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void TextBoxAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
            {
                button1_Click(sender, e);
                return;
            }
        }
    }
}

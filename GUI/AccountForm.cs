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
    public partial class AccountForm : Form
    {
        public event EventHandler ChangePass;
        public AccountForm()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            
            pictureBox1.Image = Properties.Resources.password;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }


        private void AccountForm_SizeChanged(object sender, EventArgs e)
        {
            PanelLeft.Size = new Size(this.Width / 2, this.Height - 87);
            PanelLeft.Location = new Point(0, 87);

            PanelRight.Size = new Size(this.Width / 2, this.Height - 87);
            PanelRight.Location = new Point(this.Width / 2, 87);


            PanelPassword.Location = new Point(((this.Width / 2) - (PanelPassword.Width)) / 2,0 );


        }

        private void PanelPassword_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxCurrent.Text) || string.IsNullOrWhiteSpace(TextBoxNew.Text) || string.IsNullOrWhiteSpace(TextBoxConfirm.Text))
            {
                MessageBox.Show("Fill empty fields.");
                return;
            }

            if (!VerifyPassword(TextBoxCurrent.Text, Database.Lender.password))
            {
                MessageBox.Show("Current password is incorrect.");
                return;
            }

            if (!TextBoxNew.Text.Equals(TextBoxConfirm.Text))
            {
                MessageBox.Show("New password does not match.");
                return;
            }

            if(TextBoxConfirm.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters.");
                return;
            }

            string salt = BCryptNet.GenerateSalt();
            string newPass = BCryptNet.HashPassword(TextBoxNew.Text, salt);
            Database.Lender.password = newPass;
            Database.Save();
            ResetTextBox();
            MessageBox.Show("Successfully changed password. Restarting app.");
            ChangePass.Invoke(this, new EventArgs());

        }
        private void ResetTextBox()
        {
            TextBoxNew.Text = string.Empty; 
            TextBoxCurrent.Text = string.Empty;
            TextBoxConfirm.Text = string.Empty; 
        }

        private string HashPassword(string password)
        {
            string salt = BCryptNet.GenerateSalt();
            string hashedPassword = BCryptNet.HashPassword(password, salt);

            return hashedPassword;

        }

        private bool VerifyPassword(string password, string hashedPassword)
        {
            // Check if the provided password matches the stored hashed password
            bool isPasswordValid = BCryptNet.Verify(password, hashedPassword);
            return isPasswordValid;
        }
    }
}

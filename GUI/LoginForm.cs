using LoanEase;
using System.Diagnostics;
using System.Net.Http.Headers;
using BCryptNet = BCrypt.Net.BCrypt;

namespace GUI
{
    public partial class LoginForm : Form
    {
        public static MainForm mainForm;

        public event EventHandler Login;

        public LoginForm()
        {
            InitializeComponent();
            mainForm = new MainForm(this);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text.TrimEnd() != Database.Lender.username || !VerifyPassword(PasswordTextBox.Text.TrimEnd(), Database.Lender.password))
            {
                MessageBox.Show("Invalid username and password.");
                return;
            }
            this.UsernameTextBox.Text = string.Empty;
            this.PasswordTextBox.Text = string.Empty;

            Login.Invoke(this, new EventArgs());
            mainForm.Show();
            this.Hide();
        }

        private void ForgotPasswordLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("GOOD JOB SMARTASS!");
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
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


        private void UsernameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton_Click(sender, e);
                return;
            }
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton_Click(sender, e);
                return;
            }
        }
    }
}
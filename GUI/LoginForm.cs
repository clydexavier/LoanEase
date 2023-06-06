using System.Net.Http.Headers;

namespace GUI
{
    public partial class LoginForm : Form
    {
        public static MainForm mainForm;
        public LoginForm()
        {
            InitializeComponent();
            mainForm = new MainForm(this);

            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
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
    }
}
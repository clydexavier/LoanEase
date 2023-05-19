using System.Net.Http.Headers;

namespace GUI
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();

            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            MainForm admin = new MainForm(this);
            admin.Show();
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
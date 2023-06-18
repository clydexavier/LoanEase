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
    public partial class MainForm : Form
    {
        private LoginForm loginForm;

        private static BorrowerForm borrowerForm = new BorrowerForm();
        public static HomeForm homeForm = new HomeForm();
        private static MembersForm membersForm = new MembersForm();
        private static HistoryForm historyForm = new HistoryForm();
        private static AccountForm accountForm = new AccountForm();
        
        Form? ActiveForm = homeForm;
        public MainForm(LoginForm parent)
        {
            Database.Init();
            this.loginForm = parent;
            parent.Login += ButtonHome_Click;
            accountForm.ChangePass += ButtonExit_Click;
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Database.Save();
            this.Hide();
            ActiveForm = homeForm;
            loginForm.Show();
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            if (this.ActiveForm != null)
            {
                this.ActiveForm.Hide();
                this.ActiveForm = homeForm;
            }
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(homeForm);
            homeForm.PopulateDueDate();
            homeForm.Show();
        }


        private void ButtonMembers_Click(object sender, EventArgs e)
        {
            if (this.ActiveForm != null)
            {
                this.ActiveForm.Hide();
                this.ActiveForm = membersForm;
            }
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(membersForm);
            membersForm.Show();

        }

        private void ButtonLoans_Click(object sender, EventArgs e)
        {
            if(this.ActiveForm!= null) 
            {
                this.ActiveForm.Hide();
                this.ActiveForm = borrowerForm;
            }
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(borrowerForm);
            borrowerForm.Show();
        }

        private void ButtonHistory_Click(object sender, EventArgs e)
        {
            if (this.ActiveForm != null)
            {
                this.ActiveForm.Hide();
                this.ActiveForm = historyForm;
            }
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(historyForm);
            historyForm.PopulatePayments();
            historyForm.Show();
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            if (this.ActiveForm != null)
            {
                this.ActiveForm.Hide();
                this.ActiveForm = accountForm;
            }
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(accountForm);
            accountForm.Show();
        }
    }
}

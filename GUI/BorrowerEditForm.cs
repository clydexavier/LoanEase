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
    public partial class BorrowerEditForm : Form
    {

        private BorrowerForm ParentForm;
        public event EventHandler? EditBorrower;
        public BorrowerEditForm(BorrowerForm parentForm)
        {
            this.ParentForm = parentForm;
            InitializeComponent();
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            this.ParentForm.selectedBorrower.FirstName = TextBoxFirstname.Text;
            this.ParentForm.selectedBorrower.LastName = TextBoxLastname.Text;
            this.ParentForm.selectedBorrower.isMember = ComboBoxIsMember.SelectedIndex == 0 ? true : false;
            
            //Comunicated the edit event to the parent form
            //DataGridView will be refreshed with the new value of the edited borrower
            EditBorrower?.Invoke(this, new EventArgs());

            this.DialogResult = DialogResult.OK;
            this.Reset();

            this.Hide();
            Database.Save();
        }

        private void Reset()
        {
            this.TextBoxFirstname.Text = string.Empty;
            this.TextBoxLastname.Text = string.Empty;
            this.ComboBoxIsMember.SelectedIndex = -1;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Reset();
            this.DialogResult|= DialogResult.Cancel;
            return;
        }
    }
}

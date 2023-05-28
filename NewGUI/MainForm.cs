using System.Security.Cryptography;

namespace NewGUI
{
    public partial class MainForm : Form
    {
        private Button? currentButton;
        private Form? activeForm;
        private Random random;
        private int tempIndex;
        public MainForm()
        {
            InitializeComponent();
            ButtonHome.Visible = false;
            this.random = new Random();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object sender) 
        {
            //Never nester :)
            if (sender == null) return;
            if (currentButton == (Button)sender) return;

            /*
             * highlight currentButton
             * change title bar
             * change logo
             * 
             */

            DisableButton();
            Color color = SelectThemeColor();
            currentButton = (Button)sender;
            currentButton.BackColor = color;
            currentButton.ForeColor = Color.White;
            currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            PanelTitleBar.BackColor = color;
            PanelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
            ThemeColor.PrimaryColor = color;
            ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
            ButtonHome.Visible = true;
            
        }

        private void DisableButton()
        {
            foreach(Control buttons in PanelMenu.Controls)
            {
                if (buttons.GetType() != typeof(Button)) continue;

                /*  SET TO DEFAULT
                 * buttons.BackColor
                 * buttons.ForeColor
                 * buttons.Font
                 */
                buttons.BackColor = Color.FromArgb(51, 51, 76);
                buttons.ForeColor = Color.Gainsboro;
                buttons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                
            }
        }

        private void OpenChildForm(Form childForm, object sender)
        {
            if (activeForm != null)
                activeForm.Close();

            ActivateButton(sender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PanelChildForm.Controls.Add(childForm);
            this.PanelChildForm.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();
            LabelTitle.Text = childForm.Text;
        }

        private void reset()
        {
            DisableButton();
            LabelTitle.Text = "HOME";
            PanelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            PanelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            ButtonHome.Visible = false;
        }

        private void ButtonDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DashboardForm(), sender);   
        }

        private void ButtonMember_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MembersForm(), sender);
        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        


        private void ButtonReport_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {

        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            if(activeForm!= null) 
            {
                activeForm.Close();
            }
            reset();
        }
    }
}
namespace NewGUI
{
    public partial class MainForm : Form
    {
        private Button? currentButton;
        private Form? activeForm;
        public MainForm()
        {
            InitializeComponent();
        }


        private void ActivateButton(object sender) 
        {
            //Never nester :)
            if (sender == null) return;
            if (currentButton == (Button)sender) return;

            DisableButton();
            /*
             * highlight currentButton
             * change title bar
             * change logo
             * 
             */

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
            }
        }
        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
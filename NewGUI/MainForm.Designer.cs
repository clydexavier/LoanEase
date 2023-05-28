namespace NewGUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.ButtonReport = new System.Windows.Forms.Button();
            this.ButtonMember = new System.Windows.Forms.Button();
            this.ButtonDashboard = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.LabelLogo = new System.Windows.Forms.Label();
            this.PanelTitleBar = new System.Windows.Forms.Panel();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.PanelChildForm = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            this.PanelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PanelMenu.Controls.Add(this.ButtonSettings);
            this.PanelMenu.Controls.Add(this.ButtonReport);
            this.PanelMenu.Controls.Add(this.ButtonMember);
            this.PanelMenu.Controls.Add(this.ButtonDashboard);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(220, 620);
            this.PanelMenu.TabIndex = 0;
            this.PanelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenu_Paint);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSettings.Location = new System.Drawing.Point(0, 260);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.ButtonSettings.Size = new System.Drawing.Size(220, 60);
            this.ButtonSettings.TabIndex = 4;
            this.ButtonSettings.Text = "Settings";
            this.ButtonSettings.UseVisualStyleBackColor = true;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // ButtonReport
            // 
            this.ButtonReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonReport.Location = new System.Drawing.Point(0, 200);
            this.ButtonReport.Name = "ButtonReport";
            this.ButtonReport.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.ButtonReport.Size = new System.Drawing.Size(220, 60);
            this.ButtonReport.TabIndex = 3;
            this.ButtonReport.Text = "Report";
            this.ButtonReport.UseVisualStyleBackColor = true;
            this.ButtonReport.Click += new System.EventHandler(this.ButtonReport_Click);
            // 
            // ButtonMember
            // 
            this.ButtonMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonMember.Location = new System.Drawing.Point(0, 140);
            this.ButtonMember.Name = "ButtonMember";
            this.ButtonMember.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.ButtonMember.Size = new System.Drawing.Size(220, 60);
            this.ButtonMember.TabIndex = 2;
            this.ButtonMember.Text = "Member";
            this.ButtonMember.UseVisualStyleBackColor = true;
            this.ButtonMember.Click += new System.EventHandler(this.ButtonMember_Click);
            // 
            // ButtonDashboard
            // 
            this.ButtonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDashboard.Location = new System.Drawing.Point(0, 80);
            this.ButtonDashboard.Name = "ButtonDashboard";
            this.ButtonDashboard.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.ButtonDashboard.Size = new System.Drawing.Size(220, 60);
            this.ButtonDashboard.TabIndex = 1;
            this.ButtonDashboard.Text = "Dashboard";
            this.ButtonDashboard.UseVisualStyleBackColor = true;
            this.ButtonDashboard.Click += new System.EventHandler(this.ButtonDashboard_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelLogo.Controls.Add(this.LabelLogo);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(220, 80);
            this.PanelLogo.TabIndex = 0;
            // 
            // LabelLogo
            // 
            this.LabelLogo.AutoSize = true;
            this.LabelLogo.Location = new System.Drawing.Point(83, 23);
            this.LabelLogo.Name = "LabelLogo";
            this.LabelLogo.Size = new System.Drawing.Size(34, 15);
            this.LabelLogo.TabIndex = 0;
            this.LabelLogo.Text = "Logo";
            // 
            // PanelTitleBar
            // 
            this.PanelTitleBar.Controls.Add(this.ButtonHome);
            this.PanelTitleBar.Controls.Add(this.LabelTitle);
            this.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.PanelTitleBar.Name = "PanelTitleBar";
            this.PanelTitleBar.Size = new System.Drawing.Size(847, 80);
            this.PanelTitleBar.TabIndex = 1;
            // 
            // ButtonHome
            // 
            this.ButtonHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonHome.Location = new System.Drawing.Point(0, 0);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(75, 80);
            this.ButtonHome.TabIndex = 1;
            this.ButtonHome.Text = "Home";
            this.ButtonHome.UseVisualStyleBackColor = true;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // LabelTitle
            // 
            this.LabelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Location = new System.Drawing.Point(413, 32);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(29, 15);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Title";
            // 
            // PanelChildForm
            // 
            this.PanelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelChildForm.Location = new System.Drawing.Point(220, 80);
            this.PanelChildForm.Name = "PanelChildForm";
            this.PanelChildForm.Size = new System.Drawing.Size(847, 540);
            this.PanelChildForm.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 620);
            this.Controls.Add(this.PanelChildForm);
            this.Controls.Add(this.PanelTitleBar);
            this.Controls.Add(this.PanelMenu);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.PanelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            this.PanelLogo.PerformLayout();
            this.PanelTitleBar.ResumeLayout(false);
            this.PanelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelMenu;
        private Button ButtonSettings;
        private Button ButtonReport;
        private Button ButtonMember;
        private Button ButtonDashboard;
        private Panel PanelLogo;
        private Label LabelLogo;
        private Panel PanelTitleBar;
        private Label LabelTitle;
        private Panel PanelChildForm;
        private Button ButtonHome;
    }
}
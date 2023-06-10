namespace GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeadingContainer = new System.Windows.Forms.Panel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.ButtonMembers = new System.Windows.Forms.Button();
            this.ButtonLoans = new System.Windows.Forms.Button();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ButtonHistory = new System.Windows.Forms.Button();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadingContainer
            // 
            this.HeadingContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(78)))), ((int)(((byte)(92)))));
            this.HeadingContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadingContainer.Location = new System.Drawing.Point(0, 0);
            this.HeadingContainer.Name = "HeadingContainer";
            this.HeadingContainer.Size = new System.Drawing.Size(1440, 77);
            this.HeadingContainer.TabIndex = 0;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.ButtonHistory);
            this.ButtonPanel.Controls.Add(this.ButtonMembers);
            this.ButtonPanel.Controls.Add(this.ButtonLoans);
            this.ButtonPanel.Controls.Add(this.ButtonSettings);
            this.ButtonPanel.Controls.Add(this.ButtonExit);
            this.ButtonPanel.Controls.Add(this.ButtonHome);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 77);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(300, 659);
            this.ButtonPanel.TabIndex = 3;
            // 
            // ButtonMembers
            // 
            this.ButtonMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(18)))), ((int)(((byte)(89)))));
            this.ButtonMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonMembers.FlatAppearance.BorderSize = 0;
            this.ButtonMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonMembers.Image = global::GUI.Properties.Resources.woman;
            this.ButtonMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonMembers.Location = new System.Drawing.Point(0, 130);
            this.ButtonMembers.Name = "ButtonMembers";
            this.ButtonMembers.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ButtonMembers.Size = new System.Drawing.Size(300, 65);
            this.ButtonMembers.TabIndex = 14;
            this.ButtonMembers.Text = "Members";
            this.ButtonMembers.UseVisualStyleBackColor = false;
            this.ButtonMembers.Click += new System.EventHandler(this.ButtonMembers_Click);
            // 
            // ButtonLoans
            // 
            this.ButtonLoans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(18)))), ((int)(((byte)(89)))));
            this.ButtonLoans.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonLoans.FlatAppearance.BorderSize = 0;
            this.ButtonLoans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLoans.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonLoans.Image = global::GUI.Properties.Resources.loan;
            this.ButtonLoans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonLoans.Location = new System.Drawing.Point(0, 65);
            this.ButtonLoans.Name = "ButtonLoans";
            this.ButtonLoans.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ButtonLoans.Size = new System.Drawing.Size(300, 65);
            this.ButtonLoans.TabIndex = 13;
            this.ButtonLoans.Text = "Loans";
            this.ButtonLoans.UseVisualStyleBackColor = false;
            this.ButtonLoans.Click += new System.EventHandler(this.ButtonLoans_Click);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonSettings.FlatAppearance.BorderSize = 0;
            this.ButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSettings.ForeColor = System.Drawing.Color.Black;
            this.ButtonSettings.Image = global::GUI.Properties.Resources.browser;
            this.ButtonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSettings.Location = new System.Drawing.Point(0, 529);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ButtonSettings.Size = new System.Drawing.Size(300, 65);
            this.ButtonSettings.TabIndex = 12;
            this.ButtonSettings.Text = "Settings";
            this.ButtonSettings.UseVisualStyleBackColor = false;
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonExit.FlatAppearance.BorderSize = 0;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonExit.ForeColor = System.Drawing.Color.Black;
            this.ButtonExit.Image = global::GUI.Properties.Resources.logout;
            this.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonExit.Location = new System.Drawing.Point(0, 594);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ButtonExit.Size = new System.Drawing.Size(300, 65);
            this.ButtonExit.TabIndex = 11;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonHome
            // 
            this.ButtonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(18)))), ((int)(((byte)(89)))));
            this.ButtonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonHome.FlatAppearance.BorderSize = 0;
            this.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonHome.Image = global::GUI.Properties.Resources.home__1_;
            this.ButtonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonHome.Location = new System.Drawing.Point(0, 0);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ButtonHome.Size = new System.Drawing.Size(300, 65);
            this.ButtonHome.TabIndex = 8;
            this.ButtonHome.Text = "Home\r\n";
            this.ButtonHome.UseVisualStyleBackColor = false;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            this.ButtonHome.MouseEnter += new System.EventHandler(this.ButtonHome_MouseEnter);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(300, 77);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1140, 659);
            this.MainPanel.TabIndex = 4;
            // 
            // ButtonHistory
            // 
            this.ButtonHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(18)))), ((int)(((byte)(89)))));
            this.ButtonHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonHistory.FlatAppearance.BorderSize = 0;
            this.ButtonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonHistory.Image = global::GUI.Properties.Resources.history;
            this.ButtonHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonHistory.Location = new System.Drawing.Point(0, 195);
            this.ButtonHistory.Name = "ButtonHistory";
            this.ButtonHistory.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ButtonHistory.Size = new System.Drawing.Size(300, 65);
            this.ButtonHistory.TabIndex = 15;
            this.ButtonHistory.Text = "History";
            this.ButtonHistory.UseVisualStyleBackColor = false;
            this.ButtonHistory.Click += new System.EventHandler(this.ButtonHistory_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1440, 736);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.HeadingContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel HeadingContainer;
        private Panel ButtonPanel;
        private Button ButtonSettings;
        private Button ButtonExit;
        private Button ButtonHome;
        private Button ButtonMembers;
        private Button ButtonLoans;
        private Panel MainPanel;
        private Button ButtonHistory;
    }
}
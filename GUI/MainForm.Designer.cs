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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.BtnContestant = new System.Windows.Forms.Button();
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
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainPanel.Location = new System.Drawing.Point(300, 77);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1140, 947);
            this.MainPanel.TabIndex = 2;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.ButtonSettings);
            this.ButtonPanel.Controls.Add(this.ButtonExit);
            this.ButtonPanel.Controls.Add(this.BtnContestant);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 77);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(300, 947);
            this.ButtonPanel.TabIndex = 3;
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
            this.ButtonSettings.Location = new System.Drawing.Point(0, 817);
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
            this.ButtonExit.Location = new System.Drawing.Point(0, 882);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ButtonExit.Size = new System.Drawing.Size(300, 65);
            this.ButtonExit.TabIndex = 11;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // BtnContestant
            // 
            this.BtnContestant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(18)))), ((int)(((byte)(89)))));
            this.BtnContestant.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnContestant.FlatAppearance.BorderSize = 0;
            this.BtnContestant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContestant.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnContestant.Image = global::GUI.Properties.Resources.woman;
            this.BtnContestant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnContestant.Location = new System.Drawing.Point(0, 0);
            this.BtnContestant.Name = "BtnContestant";
            this.BtnContestant.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnContestant.Size = new System.Drawing.Size(300, 65);
            this.BtnContestant.TabIndex = 8;
            this.BtnContestant.Text = "Borrowers";
            this.BtnContestant.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1440, 1024);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.MainPanel);
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
        private Panel MainPanel;
        private Panel ButtonPanel;
        private Button ButtonSettings;
        private Button ButtonExit;
        private Button BtnContestant;
    }
}
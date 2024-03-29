﻿namespace GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.HeadingContainer = new System.Windows.Forms.Panel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.ButtonHistory = new System.Windows.Forms.Button();
            this.ButtonLoans = new System.Windows.Forms.Button();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.HeadingContainer.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadingContainer
            // 
            this.HeadingContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(61)))), ((int)(((byte)(142)))));
            this.HeadingContainer.Controls.Add(this.label1);
            this.HeadingContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadingContainer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HeadingContainer.Location = new System.Drawing.Point(0, 0);
            this.HeadingContainer.Name = "HeadingContainer";
            this.HeadingContainer.Size = new System.Drawing.Size(1420, 77);
            this.HeadingContainer.TabIndex = 0;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(92)))), ((int)(((byte)(214)))));
            this.ButtonPanel.Controls.Add(this.ButtonHistory);
            this.ButtonPanel.Controls.Add(this.ButtonLoans);
            this.ButtonPanel.Controls.Add(this.ButtonSettings);
            this.ButtonPanel.Controls.Add(this.ButtonExit);
            this.ButtonPanel.Controls.Add(this.ButtonHome);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 77);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(300, 600);
            this.ButtonPanel.TabIndex = 3;
            // 
            // ButtonHistory
            // 
            this.ButtonHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(92)))), ((int)(((byte)(214)))));
            this.ButtonHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonHistory.FlatAppearance.BorderSize = 0;
            this.ButtonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonHistory.ForeColor = System.Drawing.Color.White;
            this.ButtonHistory.Image = global::GUI.Properties.Resources.history_white;
            this.ButtonHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonHistory.Location = new System.Drawing.Point(0, 130);
            this.ButtonHistory.Name = "ButtonHistory";
            this.ButtonHistory.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ButtonHistory.Size = new System.Drawing.Size(300, 65);
            this.ButtonHistory.TabIndex = 15;
            this.ButtonHistory.Text = "History";
            this.ButtonHistory.UseVisualStyleBackColor = false;
            this.ButtonHistory.Click += new System.EventHandler(this.ButtonHistory_Click);
            // 
            // ButtonLoans
            // 
            this.ButtonLoans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(92)))), ((int)(((byte)(214)))));
            this.ButtonLoans.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonLoans.FlatAppearance.BorderSize = 0;
            this.ButtonLoans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLoans.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonLoans.ForeColor = System.Drawing.Color.White;
            this.ButtonLoans.Image = global::GUI.Properties.Resources.payment_white;
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
            this.ButtonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(92)))), ((int)(((byte)(214)))));
            this.ButtonSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonSettings.FlatAppearance.BorderSize = 0;
            this.ButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSettings.ForeColor = System.Drawing.Color.White;
            this.ButtonSettings.Image = global::GUI.Properties.Resources.settings_white;
            this.ButtonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSettings.Location = new System.Drawing.Point(0, 470);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ButtonSettings.Size = new System.Drawing.Size(300, 65);
            this.ButtonSettings.TabIndex = 12;
            this.ButtonSettings.Text = "Account";
            this.ButtonSettings.UseVisualStyleBackColor = false;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(92)))), ((int)(((byte)(214)))));
            this.ButtonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonExit.FlatAppearance.BorderSize = 0;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonExit.ForeColor = System.Drawing.Color.White;
            this.ButtonExit.Image = global::GUI.Properties.Resources.exit_white;
            this.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonExit.Location = new System.Drawing.Point(0, 535);
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
            this.ButtonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(92)))), ((int)(((byte)(214)))));
            this.ButtonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonHome.FlatAppearance.BorderSize = 0;
            this.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonHome.ForeColor = System.Drawing.Color.White;
            this.ButtonHome.Image = global::GUI.Properties.Resources.home_white;
            this.ButtonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonHome.Location = new System.Drawing.Point(0, 0);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ButtonHome.Size = new System.Drawing.Size(300, 65);
            this.ButtonHome.TabIndex = 8;
            this.ButtonHome.Text = "Home\r\n";
            this.ButtonHome.UseVisualStyleBackColor = false;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(300, 77);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1120, 600);
            this.MainPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "LoanEase";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1420, 677);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.HeadingContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1440, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Ease";
            this.HeadingContainer.ResumeLayout(false);
            this.HeadingContainer.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel HeadingContainer;
        private Panel ButtonPanel;
        private Button ButtonSettings;
        private Button ButtonExit;
        private Button ButtonHome;
        private Button ButtonLoans;
        private Button ButtonHistory;
        public Panel MainPanel;
        private Label label1;
    }
}
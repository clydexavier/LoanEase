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
            this.components = new System.ComponentModel.Container();
            this.HeadingContainer = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.BtnAllResult = new System.Windows.Forms.Button();
            this.BtnResult = new System.Windows.Forms.Button();
            this.BtnJudge = new System.Windows.Forms.Button();
            this.BtnContestant = new System.Windows.Forms.Button();
            this.BtnCriteria = new System.Windows.Forms.Button();
            this.BtnEvent = new System.Windows.Forms.Button();
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
            // SideBarTimer
            // 
            this.SideBarTimer.Interval = 10;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.ButtonSettings);
            this.ButtonPanel.Controls.Add(this.ButtonExit);
            this.ButtonPanel.Controls.Add(this.BtnAllResult);
            this.ButtonPanel.Controls.Add(this.BtnResult);
            this.ButtonPanel.Controls.Add(this.BtnJudge);
            this.ButtonPanel.Controls.Add(this.BtnContestant);
            this.ButtonPanel.Controls.Add(this.BtnCriteria);
            this.ButtonPanel.Controls.Add(this.BtnEvent);
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
            // BtnAllResult
            // 
            this.BtnAllResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(18)))), ((int)(((byte)(89)))));
            this.BtnAllResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAllResult.FlatAppearance.BorderSize = 0;
            this.BtnAllResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAllResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAllResult.Image = global::GUI.Properties.Resources.calendar__1_;
            this.BtnAllResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAllResult.Location = new System.Drawing.Point(0, 325);
            this.BtnAllResult.Name = "BtnAllResult";
            this.BtnAllResult.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnAllResult.Size = new System.Drawing.Size(300, 65);
            this.BtnAllResult.TabIndex = 7;
            this.BtnAllResult.Text = "All Events";
            this.BtnAllResult.UseVisualStyleBackColor = false;
            // 
            // BtnResult
            // 
            this.BtnResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(18)))), ((int)(((byte)(89)))));
            this.BtnResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnResult.FlatAppearance.BorderSize = 0;
            this.BtnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnResult.Image = global::GUI.Properties.Resources.research;
            this.BtnResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnResult.Location = new System.Drawing.Point(0, 260);
            this.BtnResult.Name = "BtnResult";
            this.BtnResult.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnResult.Size = new System.Drawing.Size(300, 65);
            this.BtnResult.TabIndex = 10;
            this.BtnResult.Text = "Result";
            this.BtnResult.UseVisualStyleBackColor = false;
            // 
            // BtnJudge
            // 
            this.BtnJudge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(18)))), ((int)(((byte)(89)))));
            this.BtnJudge.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnJudge.FlatAppearance.BorderSize = 0;
            this.BtnJudge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnJudge.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnJudge.Image = global::GUI.Properties.Resources.hammer;
            this.BtnJudge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnJudge.Location = new System.Drawing.Point(0, 195);
            this.BtnJudge.Name = "BtnJudge";
            this.BtnJudge.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnJudge.Size = new System.Drawing.Size(300, 65);
            this.BtnJudge.TabIndex = 9;
            this.BtnJudge.Text = "Judge";
            this.BtnJudge.UseVisualStyleBackColor = false;
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
            this.BtnContestant.Location = new System.Drawing.Point(0, 130);
            this.BtnContestant.Name = "BtnContestant";
            this.BtnContestant.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnContestant.Size = new System.Drawing.Size(300, 65);
            this.BtnContestant.TabIndex = 8;
            this.BtnContestant.Text = "Contestant";
            this.BtnContestant.UseVisualStyleBackColor = false;
            // 
            // BtnCriteria
            // 
            this.BtnCriteria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(18)))), ((int)(((byte)(89)))));
            this.BtnCriteria.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCriteria.FlatAppearance.BorderSize = 0;
            this.BtnCriteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCriteria.Image = global::GUI.Properties.Resources.list;
            this.BtnCriteria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCriteria.Location = new System.Drawing.Point(0, 65);
            this.BtnCriteria.Name = "BtnCriteria";
            this.BtnCriteria.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnCriteria.Size = new System.Drawing.Size(300, 65);
            this.BtnCriteria.TabIndex = 6;
            this.BtnCriteria.Text = "Criteria";
            this.BtnCriteria.UseVisualStyleBackColor = false;
            // 
            // BtnEvent
            // 
            this.BtnEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(18)))), ((int)(((byte)(89)))));
            this.BtnEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEvent.FlatAppearance.BorderSize = 0;
            this.BtnEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEvent.Image = global::GUI.Properties.Resources.calendar__1_;
            this.BtnEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEvent.Location = new System.Drawing.Point(0, 0);
            this.BtnEvent.Name = "BtnEvent";
            this.BtnEvent.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnEvent.Size = new System.Drawing.Size(300, 65);
            this.BtnEvent.TabIndex = 5;
            this.BtnEvent.Text = "Event";
            this.BtnEvent.UseVisualStyleBackColor = false;
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
        private System.Windows.Forms.Timer SideBarTimer;
        private Panel ButtonPanel;
        private Button ButtonSettings;
        private Button ButtonExit;
        private Button BtnAllResult;
        private Button BtnResult;
        private Button BtnJudge;
        private Button BtnContestant;
        private Button BtnCriteria;
        private Button BtnEvent;
    }
}
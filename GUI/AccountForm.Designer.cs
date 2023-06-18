namespace GUI
{
    partial class AccountForm
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
            this.LabelOverview = new System.Windows.Forms.Label();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelRight = new System.Windows.Forms.Panel();
            this.PanelPassword = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBoxConfirm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TextBoxNew = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordPanel = new System.Windows.Forms.Panel();
            this.TextBoxCurrent = new System.Windows.Forms.TextBox();
            this.LabelCurrentPassword = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SetNewPassword = new System.Windows.Forms.Label();
            this.PanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelRight.SuspendLayout();
            this.PanelPassword.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PasswordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelOverview
            // 
            this.LabelOverview.AutoSize = true;
            this.LabelOverview.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelOverview.Location = new System.Drawing.Point(33, 30);
            this.LabelOverview.Name = "LabelOverview";
            this.LabelOverview.Size = new System.Drawing.Size(144, 37);
            this.LabelOverview.TabIndex = 78;
            this.LabelOverview.Text = "Account";
            // 
            // PanelLeft
            // 
            this.PanelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelLeft.Controls.Add(this.pictureBox1);
            this.PanelLeft.Location = new System.Drawing.Point(0, 87);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(582, 504);
            this.PanelLeft.TabIndex = 79;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(582, 504);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelRight
            // 
            this.PanelRight.BackColor = System.Drawing.Color.White;
            this.PanelRight.Controls.Add(this.PanelPassword);
            this.PanelRight.Location = new System.Drawing.Point(580, 87);
            this.PanelRight.Name = "PanelRight";
            this.PanelRight.Size = new System.Drawing.Size(544, 490);
            this.PanelRight.TabIndex = 80;
            // 
            // PanelPassword
            // 
            this.PanelPassword.Controls.Add(this.button1);
            this.PanelPassword.Controls.Add(this.panel2);
            this.PanelPassword.Controls.Add(this.label6);
            this.PanelPassword.Controls.Add(this.panel3);
            this.PanelPassword.Controls.Add(this.label4);
            this.PanelPassword.Controls.Add(this.PasswordPanel);
            this.PanelPassword.Controls.Add(this.LabelCurrentPassword);
            this.PanelPassword.Controls.Add(this.label3);
            this.PanelPassword.Controls.Add(this.label2);
            this.PanelPassword.Controls.Add(this.SetNewPassword);
            this.PanelPassword.Location = new System.Drawing.Point(123, 16);
            this.PanelPassword.Name = "PanelPassword";
            this.PanelPassword.Size = new System.Drawing.Size(372, 462);
            this.PanelPassword.TabIndex = 117;
            this.PanelPassword.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPassword_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(92)))), ((int)(((byte)(214)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(59, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 37);
            this.button1.TabIndex = 126;
            this.button1.Text = "Reset Password";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TextBoxConfirm);
            this.panel2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel2.Location = new System.Drawing.Point(59, 299);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.MaximumSize = new System.Drawing.Size(236, 41);
            this.panel2.MinimumSize = new System.Drawing.Size(236, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 41);
            this.panel2.TabIndex = 124;
            this.panel2.TabStop = true;
            // 
            // TextBoxConfirm
            // 
            this.TextBoxConfirm.BackColor = System.Drawing.Color.White;
            this.TextBoxConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxConfirm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxConfirm.Location = new System.Drawing.Point(11, 13);
            this.TextBoxConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxConfirm.MaxLength = 25;
            this.TextBoxConfirm.Name = "TextBoxConfirm";
            this.TextBoxConfirm.PlaceholderText = "Password";
            this.TextBoxConfirm.Size = new System.Drawing.Size(227, 14);
            this.TextBoxConfirm.TabIndex = 2;
            this.TextBoxConfirm.UseSystemPasswordChar = true;
            this.TextBoxConfirm.WordWrap = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(78)))), ((int)(((byte)(92)))));
            this.label6.Location = new System.Drawing.Point(59, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 22);
            this.label6.TabIndex = 125;
            this.label6.Text = "Confirm Password";
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.TextBoxNew);
            this.panel3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panel3.Location = new System.Drawing.Point(59, 224);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.MaximumSize = new System.Drawing.Size(236, 41);
            this.panel3.MinimumSize = new System.Drawing.Size(236, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 41);
            this.panel3.TabIndex = 122;
            this.panel3.TabStop = true;
            // 
            // TextBoxNew
            // 
            this.TextBoxNew.BackColor = System.Drawing.Color.White;
            this.TextBoxNew.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxNew.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxNew.Location = new System.Drawing.Point(11, 14);
            this.TextBoxNew.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxNew.MaxLength = 25;
            this.TextBoxNew.Name = "TextBoxNew";
            this.TextBoxNew.PlaceholderText = "Password";
            this.TextBoxNew.Size = new System.Drawing.Size(227, 14);
            this.TextBoxNew.TabIndex = 2;
            this.TextBoxNew.UseSystemPasswordChar = true;
            this.TextBoxNew.WordWrap = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(78)))), ((int)(((byte)(92)))));
            this.label4.Location = new System.Drawing.Point(59, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 22);
            this.label4.TabIndex = 123;
            this.label4.Text = "New Password";
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PasswordPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordPanel.Controls.Add(this.TextBoxCurrent);
            this.PasswordPanel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PasswordPanel.Location = new System.Drawing.Point(59, 135);
            this.PasswordPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordPanel.MaximumSize = new System.Drawing.Size(238, 41);
            this.PasswordPanel.MinimumSize = new System.Drawing.Size(238, 41);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(238, 41);
            this.PasswordPanel.TabIndex = 120;
            this.PasswordPanel.TabStop = true;
            // 
            // TextBoxCurrent
            // 
            this.TextBoxCurrent.BackColor = System.Drawing.Color.White;
            this.TextBoxCurrent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxCurrent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBoxCurrent.Location = new System.Drawing.Point(9, 15);
            this.TextBoxCurrent.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxCurrent.MaxLength = 25;
            this.TextBoxCurrent.Name = "TextBoxCurrent";
            this.TextBoxCurrent.PlaceholderText = "Current Password";
            this.TextBoxCurrent.Size = new System.Drawing.Size(227, 14);
            this.TextBoxCurrent.TabIndex = 2;
            this.TextBoxCurrent.UseSystemPasswordChar = true;
            this.TextBoxCurrent.WordWrap = false;
            // 
            // LabelCurrentPassword
            // 
            this.LabelCurrentPassword.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(78)))), ((int)(((byte)(92)))));
            this.LabelCurrentPassword.Location = new System.Drawing.Point(59, 111);
            this.LabelCurrentPassword.Name = "LabelCurrentPassword";
            this.LabelCurrentPassword.Size = new System.Drawing.Size(148, 22);
            this.LabelCurrentPassword.TabIndex = 121;
            this.LabelCurrentPassword.Text = "Current Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(93, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 18);
            this.label3.TabIndex = 119;
            this.label3.Text = "currenty used password.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(42, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 18);
            this.label2.TabIndex = 118;
            this.label2.Text = "Your new password must be different to ";
            // 
            // SetNewPassword
            // 
            this.SetNewPassword.AutoSize = true;
            this.SetNewPassword.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SetNewPassword.Location = new System.Drawing.Point(80, 11);
            this.SetNewPassword.Name = "SetNewPassword";
            this.SetNewPassword.Size = new System.Drawing.Size(183, 24);
            this.SetNewPassword.TabIndex = 117;
            this.SetNewPassword.Text = "Set new password";
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1124, 577);
            this.Controls.Add(this.PanelRight);
            this.Controls.Add(this.PanelLeft);
            this.Controls.Add(this.LabelOverview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountForm";
            this.Text = "SettingsForm";
            this.SizeChanged += new System.EventHandler(this.AccountForm_SizeChanged);
            this.PanelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelRight.ResumeLayout(false);
            this.PanelPassword.ResumeLayout(false);
            this.PanelPassword.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PasswordPanel.ResumeLayout(false);
            this.PasswordPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label LabelOverview;
        private Panel PanelLeft;
        private Panel PanelRight;
        private Panel PanelPassword;
        private Button button1;
        private Panel panel2;
        private TextBox TextBoxConfirm;
        private Label label6;
        private Panel panel3;
        private TextBox TextBoxNew;
        private Label label4;
        private Panel PasswordPanel;
        private TextBox TextBoxCurrent;
        private Label LabelCurrentPassword;
        private Label label3;
        private Label label2;
        private Label SetNewPassword;
        private PictureBox pictureBox1;
    }
}
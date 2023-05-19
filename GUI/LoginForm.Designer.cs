namespace GUI
{
    partial class LoginForm
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
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.PasswordPanel = new System.Windows.Forms.Panel();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernamePanel = new System.Windows.Forms.Panel();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.ForgotPasswordLabel = new System.Windows.Forms.LinkLabel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.Asterisk2 = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.Asterisk1 = new System.Windows.Forms.Label();
            this.SignupLabel = new System.Windows.Forms.LinkLabel();
            this.NoAccountLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.LoginPanel.SuspendLayout();
            this.PasswordPanel.SuspendLayout();
            this.UsernamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.AutoSize = true;
            this.LoginPanel.BackColor = System.Drawing.Color.White;
            this.LoginPanel.Controls.Add(this.ButtonExit);
            this.LoginPanel.Controls.Add(this.PasswordPanel);
            this.LoginPanel.Controls.Add(this.UsernamePanel);
            this.LoginPanel.Controls.Add(this.ForgotPasswordLabel);
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Controls.Add(this.PasswordLabel);
            this.LoginPanel.Controls.Add(this.Asterisk2);
            this.LoginPanel.Controls.Add(this.UsernameLabel);
            this.LoginPanel.Controls.Add(this.Asterisk1);
            this.LoginPanel.Controls.Add(this.SignupLabel);
            this.LoginPanel.Controls.Add(this.NoAccountLabel);
            this.LoginPanel.Controls.Add(this.LoginLabel);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPanel.ImeMode = System.Windows.Forms.ImeMode.On;
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(600, 450);
            this.LoginPanel.TabIndex = 0;
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PasswordPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordPanel.Controls.Add(this.PasswordTextBox);
            this.PasswordPanel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordPanel.Location = new System.Drawing.Point(55, 257);
            this.PasswordPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(490, 50);
            this.PasswordPanel.TabIndex = 2;
            this.PasswordPanel.TabStop = true;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.White;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PasswordTextBox.Location = new System.Drawing.Point(14, 14);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.PasswordTextBox.MaxLength = 25;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PlaceholderText = "Password";
            this.PasswordTextBox.Size = new System.Drawing.Size(406, 21);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.WordWrap = false;
            // 
            // UsernamePanel
            // 
            this.UsernamePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UsernamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernamePanel.Controls.Add(this.UsernameTextBox);
            this.UsernamePanel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernamePanel.Location = new System.Drawing.Point(55, 154);
            this.UsernamePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernamePanel.Name = "UsernamePanel";
            this.UsernamePanel.Size = new System.Drawing.Size(490, 50);
            this.UsernamePanel.TabIndex = 1;
            this.UsernamePanel.TabStop = true;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.Color.White;
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UsernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.UsernameTextBox.Location = new System.Drawing.Point(14, 14);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernameTextBox.MaxLength = 25;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.PlaceholderText = "Username";
            this.UsernameTextBox.Size = new System.Drawing.Size(339, 21);
            this.UsernameTextBox.TabIndex = 1;
            this.UsernameTextBox.WordWrap = false;
            // 
            // ForgotPasswordLabel
            // 
            this.ForgotPasswordLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForgotPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(91)))), ((int)(((byte)(254)))));
            this.ForgotPasswordLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ForgotPasswordLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            this.ForgotPasswordLabel.Location = new System.Drawing.Point(373, 379);
            this.ForgotPasswordLabel.Name = "ForgotPasswordLabel";
            this.ForgotPasswordLabel.Size = new System.Drawing.Size(172, 17);
            this.ForgotPasswordLabel.TabIndex = 5;
            this.ForgotPasswordLabel.TabStop = true;
            this.ForgotPasswordLabel.Text = "Forgot your password?";
            this.ForgotPasswordLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotPasswordLabel_LinkClicked);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(18)))), ((int)(((byte)(89)))));
            this.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(55, 360);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(0);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(112, 50);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(78)))), ((int)(((byte)(92)))));
            this.PasswordLabel.Location = new System.Drawing.Point(66, 225);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(92, 22);
            this.PasswordLabel.TabIndex = 69;
            this.PasswordLabel.Text = "Password";
            // 
            // Asterisk2
            // 
            this.Asterisk2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Asterisk2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.Asterisk2.Location = new System.Drawing.Point(55, 225);
            this.Asterisk2.Name = "Asterisk2";
            this.Asterisk2.Size = new System.Drawing.Size(16, 22);
            this.Asterisk2.TabIndex = 69;
            this.Asterisk2.Text = "*";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(78)))), ((int)(((byte)(92)))));
            this.UsernameLabel.Location = new System.Drawing.Point(66, 122);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(92, 22);
            this.UsernameLabel.TabIndex = 69;
            this.UsernameLabel.Text = "Username";
            // 
            // Asterisk1
            // 
            this.Asterisk1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Asterisk1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(57)))), ((int)(((byte)(73)))));
            this.Asterisk1.Location = new System.Drawing.Point(55, 122);
            this.Asterisk1.Name = "Asterisk1";
            this.Asterisk1.Size = new System.Drawing.Size(14, 16);
            this.Asterisk1.TabIndex = 69;
            this.Asterisk1.Text = "*";
            // 
            // SignupLabel
            // 
            this.SignupLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SignupLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.SignupLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(117)))), ((int)(((byte)(150)))));
            this.SignupLabel.Location = new System.Drawing.Point(252, 94);
            this.SignupLabel.Name = "SignupLabel";
            this.SignupLabel.Size = new System.Drawing.Size(54, 18);
            this.SignupLabel.TabIndex = 0;
            this.SignupLabel.TabStop = true;
            this.SignupLabel.Text = "Signup";
            // 
            // NoAccountLabel
            // 
            this.NoAccountLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.NoAccountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(98)))), ((int)(((byte)(114)))));
            this.NoAccountLabel.Location = new System.Drawing.Point(55, 94);
            this.NoAccountLabel.Name = "NoAccountLabel";
            this.NoAccountLabel.Size = new System.Drawing.Size(202, 17);
            this.NoAccountLabel.TabIndex = 69;
            this.NoAccountLabel.Text = "Don\'t have an account yet?";
            // 
            // LoginLabel
            // 
            this.LoginLabel.Font = new System.Drawing.Font("Arial", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(78)))), ((int)(((byte)(92)))));
            this.LoginLabel.Location = new System.Drawing.Point(47, 40);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(164, 54);
            this.LoginLabel.TabIndex = 69;
            this.LoginLabel.Text = "LOGIN";
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(18)))), ((int)(((byte)(89)))));
            this.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ButtonExit.ForeColor = System.Drawing.Color.White;
            this.ButtonExit.Location = new System.Drawing.Point(194, 360);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(112, 50);
            this.ButtonExit.TabIndex = 70;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.LoginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.LoginPanel.ResumeLayout(false);
            this.PasswordPanel.ResumeLayout(false);
            this.PasswordPanel.PerformLayout();
            this.UsernamePanel.ResumeLayout(false);
            this.UsernamePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel LoginPanel;
        private Label LoginLabel;
        private Label UsernameLabel;
        private Label Asterisk1;
        private TextBox PasswordTextBox;
        private TextBox UsernameTextBox;
        private LinkLabel ForgotPasswordLabel;
        private Button LoginButton;
        private Label PasswordLabel;
        private Label Asterisk2;
        private Panel PasswordPanel;
        private Panel UsernamePanel;
        private LinkLabel SignupLabel;
        private Label NoAccountLabel;
        private Button ButtonExit;
    }
}
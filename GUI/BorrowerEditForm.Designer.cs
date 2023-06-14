namespace GUI
{
    partial class BorrowerEditForm
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
            this.ButtonConfirm = new System.Windows.Forms.Button();
            this.ComboBoxIsMember = new System.Windows.Forms.ComboBox();
            this.TextBoxLastname = new System.Windows.Forms.TextBox();
            this.TextBoxFirstname = new System.Windows.Forms.TextBox();
            this.LabelEditBorrower = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonConfirm
            // 
            this.ButtonConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ButtonConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(92)))), ((int)(((byte)(214)))));
            this.ButtonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonConfirm.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ButtonConfirm.ForeColor = System.Drawing.Color.White;
            this.ButtonConfirm.Location = new System.Drawing.Point(51, 307);
            this.ButtonConfirm.Name = "ButtonConfirm";
            this.ButtonConfirm.Size = new System.Drawing.Size(97, 44);
            this.ButtonConfirm.TabIndex = 11;
            this.ButtonConfirm.Text = "Confirm";
            this.ButtonConfirm.UseVisualStyleBackColor = false;
            this.ButtonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // ComboBoxIsMember
            // 
            this.ComboBoxIsMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ComboBoxIsMember.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBoxIsMember.FormattingEnabled = true;
            this.ComboBoxIsMember.Items.AddRange(new object[] {
            "Member",
            "Not Member"});
            this.ComboBoxIsMember.Location = new System.Drawing.Point(51, 241);
            this.ComboBoxIsMember.Name = "ComboBoxIsMember";
            this.ComboBoxIsMember.Size = new System.Drawing.Size(121, 26);
            this.ComboBoxIsMember.TabIndex = 10;
            // 
            // TextBoxLastname
            // 
            this.TextBoxLastname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextBoxLastname.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxLastname.Location = new System.Drawing.Point(51, 183);
            this.TextBoxLastname.Name = "TextBoxLastname";
            this.TextBoxLastname.PlaceholderText = "Last Name";
            this.TextBoxLastname.Size = new System.Drawing.Size(266, 26);
            this.TextBoxLastname.TabIndex = 8;
            // 
            // TextBoxFirstname
            // 
            this.TextBoxFirstname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextBoxFirstname.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxFirstname.Location = new System.Drawing.Point(51, 125);
            this.TextBoxFirstname.Name = "TextBoxFirstname";
            this.TextBoxFirstname.PlaceholderText = "First Name";
            this.TextBoxFirstname.Size = new System.Drawing.Size(266, 26);
            this.TextBoxFirstname.TabIndex = 7;
            // 
            // LabelEditBorrower
            // 
            this.LabelEditBorrower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LabelEditBorrower.AutoSize = true;
            this.LabelEditBorrower.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelEditBorrower.Location = new System.Drawing.Point(51, 58);
            this.LabelEditBorrower.Name = "LabelEditBorrower";
            this.LabelEditBorrower.Size = new System.Drawing.Size(229, 37);
            this.LabelEditBorrower.TabIndex = 6;
            this.LabelEditBorrower.Text = "Edit Borrower";
            // 
            // BorrowerEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 426);
            this.Controls.Add(this.ButtonConfirm);
            this.Controls.Add(this.ComboBoxIsMember);
            this.Controls.Add(this.TextBoxLastname);
            this.Controls.Add(this.TextBoxFirstname);
            this.Controls.Add(this.LabelEditBorrower);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(427, 426);
            this.MinimumSize = new System.Drawing.Size(427, 426);
            this.Name = "BorrowerEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorrowerEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonConfirm;
        private Label LabelEditBorrower;
        public ComboBox ComboBoxIsMember;
        public TextBox TextBoxLastname;
        public TextBox TextBoxFirstname;
    }
}
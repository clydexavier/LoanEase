namespace GUI
{
    partial class AddBorrowerForm
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
            this.PanelAddBorrower = new System.Windows.Forms.Panel();
            this.ButtonConfirm = new System.Windows.Forms.Button();
            this.ComboBoxIsMember = new System.Windows.Forms.ComboBox();
            this.TextBoxAmount = new System.Windows.Forms.TextBox();
            this.TextBoxLastname = new System.Windows.Forms.TextBox();
            this.TextBoxFirstname = new System.Windows.Forms.TextBox();
            this.LabelAddBorrower = new System.Windows.Forms.Label();
            this.PanelAddBorrower.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelAddBorrower
            // 
            this.PanelAddBorrower.Controls.Add(this.ButtonConfirm);
            this.PanelAddBorrower.Controls.Add(this.ComboBoxIsMember);
            this.PanelAddBorrower.Controls.Add(this.TextBoxAmount);
            this.PanelAddBorrower.Controls.Add(this.TextBoxLastname);
            this.PanelAddBorrower.Controls.Add(this.TextBoxFirstname);
            this.PanelAddBorrower.Controls.Add(this.LabelAddBorrower);
            this.PanelAddBorrower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAddBorrower.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PanelAddBorrower.Location = new System.Drawing.Point(0, 0);
            this.PanelAddBorrower.Name = "PanelAddBorrower";
            this.PanelAddBorrower.Size = new System.Drawing.Size(427, 426);
            this.PanelAddBorrower.TabIndex = 0;
            // ButtonConfirm
            // 
            this.ButtonConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ButtonConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(189)))));
            this.ButtonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonConfirm.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ButtonConfirm.ForeColor = System.Drawing.Color.White;
            this.ButtonConfirm.Location = new System.Drawing.Point(51, 355);
            this.ButtonConfirm.Name = "ButtonConfirm";
            this.ButtonConfirm.Size = new System.Drawing.Size(97, 44);
            this.ButtonConfirm.TabIndex = 5;
            this.ButtonConfirm.Text = "Confirm";
            this.ButtonConfirm.UseVisualStyleBackColor = false;
            this.ButtonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // ComboBoxIsMember
            // 
            this.ComboBoxIsMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ComboBoxIsMember.FormattingEnabled = true;
            this.ComboBoxIsMember.Items.AddRange(new object[] {
            "Member",
            "Not Member"});
            this.ComboBoxIsMember.Location = new System.Drawing.Point(51, 295);
            this.ComboBoxIsMember.Name = "ComboBoxIsMember";
            this.ComboBoxIsMember.Size = new System.Drawing.Size(121, 29);
            this.ComboBoxIsMember.TabIndex = 4;
            // 
            // TextBoxAmount
            // 
            this.TextBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextBoxAmount.Location = new System.Drawing.Point(51, 240);
            this.TextBoxAmount.Name = "TextBoxAmount";
            this.TextBoxAmount.PlaceholderText = "Amount";
            this.TextBoxAmount.Size = new System.Drawing.Size(266, 29);
            this.TextBoxAmount.TabIndex = 3;
            // 
            // TextBoxLastname
            // 
            this.TextBoxLastname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextBoxLastname.Location = new System.Drawing.Point(51, 185);
            this.TextBoxLastname.Name = "TextBoxLastname";
            this.TextBoxLastname.PlaceholderText = "Last Name";
            this.TextBoxLastname.Size = new System.Drawing.Size(266, 29);
            this.TextBoxLastname.TabIndex = 2;
            // 
            // TextBoxFirstname
            // 
            this.TextBoxFirstname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextBoxFirstname.Location = new System.Drawing.Point(51, 125);
            this.TextBoxFirstname.Name = "TextBoxFirstname";
            this.TextBoxFirstname.PlaceholderText = "First Name";
            this.TextBoxFirstname.Size = new System.Drawing.Size(266, 29);
            this.TextBoxFirstname.TabIndex = 1;
            // 
            // LabelAddBorrower
            // 
            this.LabelAddBorrower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LabelAddBorrower.AutoSize = true;
            this.LabelAddBorrower.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelAddBorrower.Location = new System.Drawing.Point(51, 58);
            this.LabelAddBorrower.Name = "LabelAddBorrower";
            this.LabelAddBorrower.Size = new System.Drawing.Size(229, 37);
            this.LabelAddBorrower.TabIndex = 0;
            this.LabelAddBorrower.Text = "Add Borrower";
            // 
            // AddBorrowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 426);
            this.Controls.Add(this.PanelAddBorrower);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(427, 426);
            this.MinimumSize = new System.Drawing.Size(427, 426);
            this.Name = "AddBorrowerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBorrower";
            this.PanelAddBorrower.ResumeLayout(false);
            this.PanelAddBorrower.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelAddBorrower;
        private Label LabelAddBorrower;
        private ComboBox ComboBoxIsMember;
        private TextBox TextBoxAmount;
        private TextBox TextBoxLastname;
        private TextBox TextBoxFirstname;
        private Button ButtonConfirm;
    }
}
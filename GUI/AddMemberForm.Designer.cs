﻿namespace GUI
{
    partial class AddMemberForm
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
            this.TextBoxLastname = new System.Windows.Forms.TextBox();
            this.TextBoxFirstname = new System.Windows.Forms.TextBox();
            this.LabelAddMember = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonConfirm
            // 
            this.ButtonConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ButtonConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(189)))));
            this.ButtonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonConfirm.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ButtonConfirm.ForeColor = System.Drawing.Color.White;
            this.ButtonConfirm.Location = new System.Drawing.Point(37, 220);
            this.ButtonConfirm.Name = "ButtonConfirm";
            this.ButtonConfirm.Size = new System.Drawing.Size(97, 41);
            this.ButtonConfirm.TabIndex = 11;
            this.ButtonConfirm.Text = "Confirm";
            this.ButtonConfirm.UseVisualStyleBackColor = false;
            this.ButtonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // TextBoxLastname
            // 
            this.TextBoxLastname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextBoxLastname.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxLastname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TextBoxLastname.Location = new System.Drawing.Point(37, 161);
            this.TextBoxLastname.Name = "TextBoxLastname";
            this.TextBoxLastname.PlaceholderText = "Last Name";
            this.TextBoxLastname.Size = new System.Drawing.Size(266, 26);
            this.TextBoxLastname.TabIndex = 8;
            // 
            // TextBoxFirstname
            // 
            this.TextBoxFirstname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextBoxFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxFirstname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TextBoxFirstname.Location = new System.Drawing.Point(37, 104);
            this.TextBoxFirstname.Name = "TextBoxFirstname";
            this.TextBoxFirstname.PlaceholderText = "First Name";
            this.TextBoxFirstname.Size = new System.Drawing.Size(266, 26);
            this.TextBoxFirstname.TabIndex = 7;
            // 
            // LabelAddMember
            // 
            this.LabelAddMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LabelAddMember.AutoSize = true;
            this.LabelAddMember.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelAddMember.Location = new System.Drawing.Point(37, 43);
            this.LabelAddMember.Name = "LabelAddMember";
            this.LabelAddMember.Size = new System.Drawing.Size(210, 37);
            this.LabelAddMember.TabIndex = 6;
            this.LabelAddMember.Text = "Add Member";
            // 
            // AddMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 304);
            this.Controls.Add(this.ButtonConfirm);
            this.Controls.Add(this.TextBoxLastname);
            this.Controls.Add(this.TextBoxFirstname);
            this.Controls.Add(this.LabelAddMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(359, 304);
            this.MinimumSize = new System.Drawing.Size(359, 304);
            this.Name = "AddMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMemberForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonConfirm;
        private TextBox TextBoxLastname;
        private TextBox TextBoxFirstname;
        private Label LabelAddMember;
    }
}
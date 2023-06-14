namespace GUI
{
    partial class BorrowerPayForm
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
            this.LabelPayBorrower = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxAmount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelPayBorrower
            // 
            this.LabelPayBorrower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LabelPayBorrower.AutoSize = true;
            this.LabelPayBorrower.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelPayBorrower.Location = new System.Drawing.Point(88, 42);
            this.LabelPayBorrower.Name = "LabelPayBorrower";
            this.LabelPayBorrower.Size = new System.Drawing.Size(299, 37);
            this.LabelPayBorrower.TabIndex = 7;
            this.LabelPayBorrower.Text = "Borrower Payment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(55, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Amount : ";
            // 
            // TextBoxAmount
            // 
            this.TextBoxAmount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxAmount.Location = new System.Drawing.Point(212, 116);
            this.TextBoxAmount.Name = "TextBoxAmount";
            this.TextBoxAmount.Size = new System.Drawing.Size(194, 29);
            this.TextBoxAmount.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(92)))), ((int)(((byte)(214)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(55, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(351, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "CONFIRM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.FlatAppearance.BorderSize = 0;
            this.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBack.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonBack.Image = global::GUI.Properties.Resources.close;
            this.ButtonBack.Location = new System.Drawing.Point(437, 0);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(40, 40);
            this.ButtonBack.TabIndex = 11;
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // BorrowerPayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 241);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBoxAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelPayBorrower);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(477, 241);
            this.MinimumSize = new System.Drawing.Size(477, 241);
            this.Name = "BorrowerPayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorrowerPayForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelPayBorrower;
        private Label label1;
        private TextBox TextBoxAmount;
        private Button button1;
        private Button ButtonBack;
    }
}
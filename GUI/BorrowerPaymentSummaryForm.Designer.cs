namespace GUI
{
    partial class BorrowerPaymentSummaryForm
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
            this.LabelCurrentBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelBorrowerName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelPaymentAmount = new System.Windows.Forms.Label();
            this.LabelAfterPaymentBalance = new System.Windows.Forms.Label();
            this.ButtonPay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelPayBorrower
            // 
            this.LabelPayBorrower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LabelPayBorrower.AutoSize = true;
            this.LabelPayBorrower.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelPayBorrower.Location = new System.Drawing.Point(70, 37);
            this.LabelPayBorrower.Name = "LabelPayBorrower";
            this.LabelPayBorrower.Size = new System.Drawing.Size(301, 37);
            this.LabelPayBorrower.TabIndex = 7;
            this.LabelPayBorrower.Text = "Payment Summary";
            // 
            // LabelCurrentBalance
            // 
            this.LabelCurrentBalance.AutoSize = true;
            this.LabelCurrentBalance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelCurrentBalance.Location = new System.Drawing.Point(283, 155);
            this.LabelCurrentBalance.Name = "LabelCurrentBalance";
            this.LabelCurrentBalance.Size = new System.Drawing.Size(52, 21);
            this.LabelCurrentBalance.TabIndex = 9;
            this.LabelCurrentBalance.Text = "label1";
            this.LabelCurrentBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(51, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Current Balance : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(51, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "After Payment Balance :  ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelBorrowerName
            // 
            this.LabelBorrowerName.AutoSize = true;
            this.LabelBorrowerName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelBorrowerName.Location = new System.Drawing.Point(283, 118);
            this.LabelBorrowerName.Name = "LabelBorrowerName";
            this.LabelBorrowerName.Size = new System.Drawing.Size(52, 21);
            this.LabelBorrowerName.TabIndex = 13;
            this.LabelBorrowerName.Text = "label1";
            this.LabelBorrowerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(51, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Name of Borrower : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(51, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Payment Amount :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelPaymentAmount
            // 
            this.LabelPaymentAmount.AutoSize = true;
            this.LabelPaymentAmount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelPaymentAmount.Location = new System.Drawing.Point(283, 190);
            this.LabelPaymentAmount.Name = "LabelPaymentAmount";
            this.LabelPaymentAmount.Size = new System.Drawing.Size(52, 21);
            this.LabelPaymentAmount.TabIndex = 16;
            this.LabelPaymentAmount.Text = "label1";
            this.LabelPaymentAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelAfterPaymentBalance
            // 
            this.LabelAfterPaymentBalance.AutoSize = true;
            this.LabelAfterPaymentBalance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelAfterPaymentBalance.Location = new System.Drawing.Point(283, 250);
            this.LabelAfterPaymentBalance.Name = "LabelAfterPaymentBalance";
            this.LabelAfterPaymentBalance.Size = new System.Drawing.Size(52, 21);
            this.LabelAfterPaymentBalance.TabIndex = 17;
            this.LabelAfterPaymentBalance.Text = "label1";
            this.LabelAfterPaymentBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ButtonPay
            // 
            this.ButtonPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(92)))), ((int)(((byte)(214)))));
            this.ButtonPay.FlatAppearance.BorderSize = 0;
            this.ButtonPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPay.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ButtonPay.ForeColor = System.Drawing.Color.White;
            this.ButtonPay.Location = new System.Drawing.Point(86, 326);
            this.ButtonPay.Name = "ButtonPay";
            this.ButtonPay.Size = new System.Drawing.Size(273, 40);
            this.ButtonPay.TabIndex = 18;
            this.ButtonPay.UseVisualStyleBackColor = false;
            this.ButtonPay.Click += new System.EventHandler(this.ButtonPay_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Image = global::GUI.Properties.Resources.close;
            this.button1.Location = new System.Drawing.Point(403, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(51, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Change: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelChange
            // 
            this.LabelChange.AutoSize = true;
            this.LabelChange.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelChange.Location = new System.Drawing.Point(283, 283);
            this.LabelChange.Name = "LabelChange";
            this.LabelChange.Size = new System.Drawing.Size(52, 21);
            this.LabelChange.TabIndex = 22;
            this.LabelChange.Text = "label1";
            this.LabelChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BorrowerPaymentSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 400);
            this.Controls.Add(this.LabelChange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonPay);
            this.Controls.Add(this.LabelAfterPaymentBalance);
            this.Controls.Add(this.LabelPaymentAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelBorrowerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelCurrentBalance);
            this.Controls.Add(this.LabelPayBorrower);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(443, 400);
            this.MinimumSize = new System.Drawing.Size(443, 370);
            this.Name = "BorrowerPaymentSummaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorrowerPayForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelPayBorrower;
        private Label LabelCurrentBalance;
        private Label label1;
        private Label label2;
        private Label LabelBorrowerName;
        private Label label3;
        private Label label4;
        private Label LabelPaymentAmount;
        private Label LabelAfterPaymentBalance;
        private Button ButtonPay;
        private Button button1;
        private Label label5;
        private Label LabelChange;
    }
}
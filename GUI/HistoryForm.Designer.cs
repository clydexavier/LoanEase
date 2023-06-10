namespace GUI
{
    partial class HistoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LabelPaymentsHistory = new System.Windows.Forms.Label();
            this.DGVPayments = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatePayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelPaymentsHistory
            // 
            this.LabelPaymentsHistory.AutoSize = true;
            this.LabelPaymentsHistory.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelPaymentsHistory.Location = new System.Drawing.Point(33, 30);
            this.LabelPaymentsHistory.Name = "LabelPaymentsHistory";
            this.LabelPaymentsHistory.Size = new System.Drawing.Size(285, 37);
            this.LabelPaymentsHistory.TabIndex = 1;
            this.LabelPaymentsHistory.Text = "Payments History";
            // 
            // DGVPayments
            // 
            this.DGVPayments.AllowUserToAddRows = false;
            this.DGVPayments.AllowUserToDeleteRows = false;
            this.DGVPayments.AllowUserToResizeColumns = false;
            this.DGVPayments.AllowUserToResizeRows = false;
            this.DGVPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPayments.BackgroundColor = System.Drawing.Color.White;
            this.DGVPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVPayments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVPayments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVPayments.ColumnHeadersHeight = 50;
            this.DGVPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.IsMember,
            this.DatePayment,
            this.AmountPayed});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVPayments.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVPayments.EnableHeadersVisualStyles = false;
            this.DGVPayments.Location = new System.Drawing.Point(33, 132);
            this.DGVPayments.Margin = new System.Windows.Forms.Padding(0);
            this.DGVPayments.Name = "DGVPayments";
            this.DGVPayments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVPayments.RowHeadersVisible = false;
            this.DGVPayments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVPayments.RowTemplate.Height = 35;
            this.DGVPayments.ShowCellErrors = false;
            this.DGVPayments.ShowCellToolTips = false;
            this.DGVPayments.ShowEditingIcon = false;
            this.DGVPayments.ShowRowErrors = false;
            this.DGVPayments.Size = new System.Drawing.Size(1052, 363);
            this.DGVPayments.TabIndex = 2;
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "Borrower.Name";
            this.ColumnName.FillWeight = 94.86185F;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // IsMember
            // 
            this.IsMember.FillWeight = 94.86185F;
            this.IsMember.HeaderText = "Is Member";
            this.IsMember.Name = "IsMember";
            // 
            // DatePayment
            // 
            this.DatePayment.FillWeight = 94.86185F;
            this.DatePayment.HeaderText = "Payment Date";
            this.DatePayment.Name = "DatePayment";
            this.DatePayment.ReadOnly = true;
            // 
            // AmountPayed
            // 
            this.AmountPayed.FillWeight = 94.86185F;
            this.AmountPayed.HeaderText = "Amount Payed";
            this.AmountPayed.Name = "AmountPayed";
            this.AmountPayed.ReadOnly = true;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 530);
            this.Controls.Add(this.DGVPayments);
            this.Controls.Add(this.LabelPaymentsHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGVPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelPaymentsHistory;
        private DataGridView DGVPayments;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn IsMember;
        private DataGridViewTextBoxColumn DatePayment;
        private DataGridViewTextBoxColumn AmountPayed;
    }
}
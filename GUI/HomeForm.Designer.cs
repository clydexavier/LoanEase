namespace GUI
{
    partial class HomeForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelDueDate = new System.Windows.Forms.Label();
            this.DGVBorrowers = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateBorrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthlyInterst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowerLabel = new System.Windows.Forms.Label();
            this.PanelBorrowers = new System.Windows.Forms.Panel();
            this.LabelBorrowers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelPayments = new System.Windows.Forms.Panel();
            this.LabelPayments = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelLended = new System.Windows.Forms.Panel();
            this.LabelLended = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBorrowers)).BeginInit();
            this.PanelBorrowers.SuspendLayout();
            this.PanelPayments.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelLended.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.LabelDueDate);
            this.panel2.Controls.Add(this.DGVBorrowers);
            this.panel2.Location = new System.Drawing.Point(0, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1090, 289);
            this.panel2.TabIndex = 1;
            this.panel2.SizeChanged += new System.EventHandler(this.panel2_SizeChanged);
            // 
            // LabelDueDate
            // 
            this.LabelDueDate.AutoSize = true;
            this.LabelDueDate.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelDueDate.Location = new System.Drawing.Point(443, 12);
            this.LabelDueDate.Name = "LabelDueDate";
            this.LabelDueDate.Size = new System.Drawing.Size(203, 28);
            this.LabelDueDate.TabIndex = 3;
            this.LabelDueDate.Text = "Upcoming Due Date";
            // 
            // DGVBorrowers
            // 
            this.DGVBorrowers.AllowUserToAddRows = false;
            this.DGVBorrowers.AllowUserToDeleteRows = false;
            this.DGVBorrowers.AllowUserToResizeColumns = false;
            this.DGVBorrowers.AllowUserToResizeRows = false;
            this.DGVBorrowers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVBorrowers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVBorrowers.BackgroundColor = System.Drawing.Color.White;
            this.DGVBorrowers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVBorrowers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVBorrowers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVBorrowers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVBorrowers.ColumnHeadersHeight = 50;
            this.DGVBorrowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVBorrowers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.IsMember,
            this.DateBorrowed,
            this.Amount,
            this.MonthlyInterst});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVBorrowers.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVBorrowers.EnableHeadersVisualStyles = false;
            this.DGVBorrowers.Location = new System.Drawing.Point(20, 49);
            this.DGVBorrowers.Margin = new System.Windows.Forms.Padding(0);
            this.DGVBorrowers.Name = "DGVBorrowers";
            this.DGVBorrowers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVBorrowers.RowHeadersVisible = false;
            this.DGVBorrowers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVBorrowers.RowTemplate.Height = 35;
            this.DGVBorrowers.ShowCellErrors = false;
            this.DGVBorrowers.ShowCellToolTips = false;
            this.DGVBorrowers.ShowEditingIcon = false;
            this.DGVBorrowers.ShowRowErrors = false;
            this.DGVBorrowers.Size = new System.Drawing.Size(1052, 213);
            this.DGVBorrowers.TabIndex = 2;
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
            // DateBorrowed
            // 
            this.DateBorrowed.FillWeight = 94.86185F;
            this.DateBorrowed.HeaderText = "Due Date";
            this.DateBorrowed.Name = "DateBorrowed";
            this.DateBorrowed.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.FillWeight = 94.86185F;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // MonthlyInterst
            // 
            this.MonthlyInterst.FillWeight = 94.86185F;
            this.MonthlyInterst.HeaderText = "Monthly Interest";
            this.MonthlyInterst.Name = "MonthlyInterst";
            this.MonthlyInterst.ReadOnly = true;
            // 
            // BorrowerLabel
            // 
            this.BorrowerLabel.AutoSize = true;
            this.BorrowerLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BorrowerLabel.Location = new System.Drawing.Point(33, 30);
            this.BorrowerLabel.Name = "BorrowerLabel";
            this.BorrowerLabel.Size = new System.Drawing.Size(159, 37);
            this.BorrowerLabel.TabIndex = 1;
            this.BorrowerLabel.Text = "Overview";
            // 
            // PanelBorrowers
            // 
            this.PanelBorrowers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(92)))), ((int)(((byte)(214)))));
            this.PanelBorrowers.Controls.Add(this.LabelBorrowers);
            this.PanelBorrowers.Controls.Add(this.label1);
            this.PanelBorrowers.Location = new System.Drawing.Point(12, 97);
            this.PanelBorrowers.Name = "PanelBorrowers";
            this.PanelBorrowers.Size = new System.Drawing.Size(305, 100);
            this.PanelBorrowers.TabIndex = 2;
            // 
            // LabelBorrowers
            // 
            this.LabelBorrowers.AutoSize = true;
            this.LabelBorrowers.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelBorrowers.ForeColor = System.Drawing.Color.LightCoral;
            this.LabelBorrowers.Location = new System.Drawing.Point(142, 54);
            this.LabelBorrowers.Name = "LabelBorrowers";
            this.LabelBorrowers.Size = new System.Drawing.Size(28, 32);
            this.LabelBorrowers.TabIndex = 1;
            this.LabelBorrowers.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Borrowers";
            // 
            // PanelPayments
            // 
            this.PanelPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(92)))), ((int)(((byte)(214)))));
            this.PanelPayments.Controls.Add(this.LabelPayments);
            this.PanelPayments.Controls.Add(this.label4);
            this.PanelPayments.Location = new System.Drawing.Point(385, 97);
            this.PanelPayments.Name = "PanelPayments";
            this.PanelPayments.Size = new System.Drawing.Size(335, 100);
            this.PanelPayments.TabIndex = 3;
            // 
            // LabelPayments
            // 
            this.LabelPayments.AutoSize = true;
            this.LabelPayments.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelPayments.ForeColor = System.Drawing.Color.LightCoral;
            this.LabelPayments.Location = new System.Drawing.Point(155, 54);
            this.LabelPayments.Name = "LabelPayments";
            this.LabelPayments.Size = new System.Drawing.Size(28, 32);
            this.LabelPayments.TabIndex = 1;
            this.LabelPayments.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 45);
            this.label4.TabIndex = 0;
            this.label4.Text = "Payments Collected";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PanelLended);
            this.panel1.Controls.Add(this.PanelPayments);
            this.panel1.Controls.Add(this.PanelBorrowers);
            this.panel1.Controls.Add(this.BorrowerLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 229);
            this.panel1.TabIndex = 0;
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged);
            // 
            // PanelLended
            // 
            this.PanelLended.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(92)))), ((int)(((byte)(214)))));
            this.PanelLended.Controls.Add(this.LabelLended);
            this.PanelLended.Controls.Add(this.label6);
            this.PanelLended.Location = new System.Drawing.Point(767, 97);
            this.PanelLended.Name = "PanelLended";
            this.PanelLended.Size = new System.Drawing.Size(305, 100);
            this.PanelLended.TabIndex = 4;
            // 
            // LabelLended
            // 
            this.LabelLended.AutoSize = true;
            this.LabelLended.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelLended.ForeColor = System.Drawing.Color.LightCoral;
            this.LabelLended.Location = new System.Drawing.Point(156, 54);
            this.LabelLended.Name = "LabelLended";
            this.LabelLended.Size = new System.Drawing.Size(28, 32);
            this.LabelLended.TabIndex = 1;
            this.LabelLended.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(35, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 45);
            this.label6.TabIndex = 0;
            this.label6.Text = "Money Lended";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 536);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBorrowers)).EndInit();
            this.PanelBorrowers.ResumeLayout(false);
            this.PanelBorrowers.PerformLayout();
            this.PanelPayments.ResumeLayout(false);
            this.PanelPayments.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelLended.ResumeLayout(false);
            this.PanelLended.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private DataGridView DGVBorrowers;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn IsMember;
        private DataGridViewTextBoxColumn DateBorrowed;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn MonthlyInterst;
        private Label LabelDueDate;
        private Label BorrowerLabel;
        private Panel PanelBorrowers;
        private Label LabelBorrowers;
        private Label label1;
        private Panel PanelPayments;
        private Label LabelPayments;
        private Label label4;
        private Panel panel1;
        private Panel PanelLended;
        private Label LabelLended;
        private Label label6;
    }
}
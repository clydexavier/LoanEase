namespace GUI
{
    partial class BorrowerForm
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
            this.PanelTop = new System.Windows.Forms.Panel();
            this.ButtonAddBorrower = new System.Windows.Forms.Button();
            this.BorrowerLabel = new System.Windows.Forms.Label();
            this.DGVBorrowers = new System.Windows.Forms.DataGridView();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateBorrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthlyInterst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PayButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBorrowers)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.ButtonAddBorrower);
            this.PanelTop.Controls.Add(this.BorrowerLabel);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1124, 100);
            this.PanelTop.TabIndex = 0;
            // 
            // ButtonAddBorrower
            // 
            this.ButtonAddBorrower.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonAddBorrower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(92)))), ((int)(((byte)(214)))));
            this.ButtonAddBorrower.FlatAppearance.BorderSize = 0;
            this.ButtonAddBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddBorrower.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAddBorrower.ForeColor = System.Drawing.Color.White;
            this.ButtonAddBorrower.Location = new System.Drawing.Point(907, 72);
            this.ButtonAddBorrower.Name = "ButtonAddBorrower";
            this.ButtonAddBorrower.Size = new System.Drawing.Size(178, 28);
            this.ButtonAddBorrower.TabIndex = 1;
            this.ButtonAddBorrower.Text = "Add Borrower";
            this.ButtonAddBorrower.UseVisualStyleBackColor = false;
            this.ButtonAddBorrower.Click += new System.EventHandler(this.ButtonAddBorrower_Click);
            // 
            // BorrowerLabel
            // 
            this.BorrowerLabel.AutoSize = true;
            this.BorrowerLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BorrowerLabel.Location = new System.Drawing.Point(33, 30);
            this.BorrowerLabel.Name = "BorrowerLabel";
            this.BorrowerLabel.Size = new System.Drawing.Size(177, 37);
            this.BorrowerLabel.TabIndex = 0;
            this.BorrowerLabel.Text = "Borrowers";
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
            this.MonthlyInterst,
            this.EditButton,
            this.Delete,
            this.PayButton});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVBorrowers.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVBorrowers.EnableHeadersVisualStyles = false;
            this.DGVBorrowers.Location = new System.Drawing.Point(33, 132);
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
            this.DGVBorrowers.Size = new System.Drawing.Size(1052, 363);
            this.DGVBorrowers.TabIndex = 1;
            this.DGVBorrowers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVBorrowers_CellClick);
            this.DGVBorrowers.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DGVBorrowers_CellPainting);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxSearch.Location = new System.Drawing.Point(33, 103);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.PlaceholderText = "Search Borrower";
            this.TextBoxSearch.Size = new System.Drawing.Size(246, 26);
            this.TextBoxSearch.TabIndex = 3;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "Borrower.Name";
            this.ColumnName.FillWeight = 77.60936F;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // IsMember
            // 
            this.IsMember.FillWeight = 77.60936F;
            this.IsMember.HeaderText = "Is Member";
            this.IsMember.Name = "IsMember";
            // 
            // DateBorrowed
            // 
            this.DateBorrowed.FillWeight = 77.60936F;
            this.DateBorrowed.HeaderText = "Date Borrowed";
            this.DateBorrowed.Name = "DateBorrowed";
            this.DateBorrowed.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.FillWeight = 77.60936F;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // MonthlyInterst
            // 
            this.MonthlyInterst.FillWeight = 77.60936F;
            this.MonthlyInterst.HeaderText = "Quarterly Interest";
            this.MonthlyInterst.Name = "MonthlyInterst";
            this.MonthlyInterst.ReadOnly = true;
            // 
            // EditButton
            // 
            this.EditButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EditButton.FillWeight = 121.8274F;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.HeaderText = "Edit";
            this.EditButton.Name = "EditButton";
            this.EditButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EditButton.Text = "edit";
            this.EditButton.Width = 80;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Delete.FillWeight = 121.8274F;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Width = 80;
            // 
            // PayButton
            // 
            this.PayButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PayButton.FillWeight = 103.8633F;
            this.PayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayButton.HeaderText = "Pay";
            this.PayButton.Name = "PayButton";
            this.PayButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PayButton.Text = "pay";
            this.PayButton.Width = 80;
            // 
            // BorrowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 530);
            this.ControlBox = false;
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.DGVBorrowers);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BorrowerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "BorrowerForm";
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBorrowers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PanelTop;
        private Label BorrowerLabel;
        private DataGridView DGVBorrowers;
        private Button ButtonAddBorrower;
        private TextBox TextBoxSearch;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn IsMember;
        private DataGridViewTextBoxColumn DateBorrowed;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn MonthlyInterst;
        private DataGridViewButtonColumn EditButton;
        private DataGridViewButtonColumn Delete;
        private DataGridViewButtonColumn PayButton;
    }
}
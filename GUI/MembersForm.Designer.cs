namespace GUI
{
    partial class MembersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVMembers = new System.Windows.Forms.DataGridView();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.ButtonAddMember = new System.Windows.Forms.Button();
            this.LabelMembers = new System.Windows.Forms.Label();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateBorrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthlyInterst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMembers)).BeginInit();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVMembers
            // 
            this.DGVMembers.AllowUserToAddRows = false;
            this.DGVMembers.AllowUserToDeleteRows = false;
            this.DGVMembers.AllowUserToResizeColumns = false;
            this.DGVMembers.AllowUserToResizeRows = false;
            this.DGVMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMembers.BackgroundColor = System.Drawing.Color.White;
            this.DGVMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVMembers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVMembers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVMembers.ColumnHeadersHeight = 50;
            this.DGVMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.DateBorrowed,
            this.Amount,
            this.MonthlyInterst,
            this.EditButton});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVMembers.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVMembers.EnableHeadersVisualStyles = false;
            this.DGVMembers.Location = new System.Drawing.Point(33, 141);
            this.DGVMembers.Margin = new System.Windows.Forms.Padding(0);
            this.DGVMembers.Name = "DGVMembers";
            this.DGVMembers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVMembers.RowHeadersVisible = false;
            this.DGVMembers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVMembers.RowTemplate.Height = 35;
            this.DGVMembers.ShowCellErrors = false;
            this.DGVMembers.ShowCellToolTips = false;
            this.DGVMembers.ShowEditingIcon = false;
            this.DGVMembers.ShowRowErrors = false;
            this.DGVMembers.Size = new System.Drawing.Size(1052, 347);
            this.DGVMembers.TabIndex = 3;
            this.DGVMembers.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DGVMembers_CellPainting);
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.ButtonAddMember);
            this.PanelTop.Controls.Add(this.LabelMembers);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1124, 100);
            this.PanelTop.TabIndex = 2;
            // 
            // ButtonAddMember
            // 
            this.ButtonAddMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(18)))), ((int)(((byte)(89)))));
            this.ButtonAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddMember.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAddMember.Location = new System.Drawing.Point(945, 69);
            this.ButtonAddMember.Name = "ButtonAddMember";
            this.ButtonAddMember.Size = new System.Drawing.Size(140, 28);
            this.ButtonAddMember.TabIndex = 1;
            this.ButtonAddMember.Text = "Add Member";
            this.ButtonAddMember.UseVisualStyleBackColor = false;
            this.ButtonAddMember.Click += new System.EventHandler(this.ButtonAddMember_Click);
            // 
            // LabelMembers
            // 
            this.LabelMembers.AutoSize = true;
            this.LabelMembers.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelMembers.Location = new System.Drawing.Point(33, 30);
            this.LabelMembers.Name = "LabelMembers";
            this.LabelMembers.Size = new System.Drawing.Size(158, 37);
            this.LabelMembers.TabIndex = 0;
            this.LabelMembers.Text = "Members";
            // 
            // ColumnName
            // 
            this.ColumnName.FillWeight = 94.86185F;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DateBorrowed
            // 
            this.DateBorrowed.FillWeight = 94.86185F;
            this.DateBorrowed.HeaderText = "Date Borrowed";
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
            // EditButton
            // 
            this.EditButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.EditButton.DefaultCellStyle = dataGridViewCellStyle5;
            this.EditButton.FillWeight = 121.8274F;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.HeaderText = "";
            this.EditButton.Name = "EditButton";
            this.EditButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EditButton.Text = "edit";
            this.EditButton.Width = 80;
            // 
            // MembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 530);
            this.ControlBox = false;
            this.Controls.Add(this.DGVMembers);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MembersForm";
            this.ShowInTaskbar = false;
            this.Text = "MembersForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGVMembers)).EndInit();
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DGVMembers;
        private Panel PanelTop;
        private Button ButtonAddMember;
        private Label LabelMembers;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn DateBorrowed;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn MonthlyInterst;
        private DataGridViewButtonColumn EditButton;
    }
}
namespace NewGUI
{
    partial class DashboardForm
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
            this.PanelAux = new System.Windows.Forms.Panel();
            this.LabelBorrowers = new System.Windows.Forms.Label();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.ButtonPay = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.DataGridViewBorrowers = new System.Windows.Forms.DataGridView();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.LabelBorrower = new System.Windows.Forms.Label();
            this.PanelAux.SuspendLayout();
            this.PanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBorrowers)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelAux
            // 
            this.PanelAux.Controls.Add(this.LabelBorrowers);
            this.PanelAux.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelAux.Location = new System.Drawing.Point(0, 0);
            this.PanelAux.Name = "PanelAux";
            this.PanelAux.Size = new System.Drawing.Size(859, 60);
            this.PanelAux.TabIndex = 0;
            // 
            // LabelBorrowers
            // 
            this.LabelBorrowers.AutoSize = true;
            this.LabelBorrowers.Location = new System.Drawing.Point(43, 25);
            this.LabelBorrowers.Name = "LabelBorrowers";
            this.LabelBorrowers.Size = new System.Drawing.Size(60, 15);
            this.LabelBorrowers.TabIndex = 0;
            this.LabelBorrowers.Text = "Borrowers";
            // 
            // PanelMain
            // 
            this.PanelMain.Controls.Add(this.ButtonPay);
            this.PanelMain.Controls.Add(this.ButtonAdd);
            this.PanelMain.Controls.Add(this.DataGridViewBorrowers);
            this.PanelMain.Controls.Add(this.ButtonSearch);
            this.PanelMain.Controls.Add(this.TextBoxSearch);
            this.PanelMain.Controls.Add(this.LabelBorrower);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 60);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(859, 386);
            this.PanelMain.TabIndex = 1;
            // 
            // ButtonPay
            // 
            this.ButtonPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPay.Location = new System.Drawing.Point(772, 117);
            this.ButtonPay.Name = "ButtonPay";
            this.ButtonPay.Size = new System.Drawing.Size(75, 23);
            this.ButtonPay.TabIndex = 5;
            this.ButtonPay.Text = "Pay";
            this.ButtonPay.UseVisualStyleBackColor = true;
            this.ButtonPay.Click += new System.EventHandler(this.ButtonPay_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAdd.Location = new System.Drawing.Point(772, 88);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 4;
            this.ButtonAdd.Text = "Add New Loan";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // DataGridViewBorrowers
            // 
            this.DataGridViewBorrowers.AllowUserToAddRows = false;
            this.DataGridViewBorrowers.AllowUserToDeleteRows = false;
            this.DataGridViewBorrowers.AllowUserToResizeColumns = false;
            this.DataGridViewBorrowers.AllowUserToResizeRows = false;
            this.DataGridViewBorrowers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewBorrowers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewBorrowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewBorrowers.Location = new System.Drawing.Point(19, 88);
            this.DataGridViewBorrowers.Name = "DataGridViewBorrowers";
            this.DataGridViewBorrowers.ReadOnly = true;
            this.DataGridViewBorrowers.RowTemplate.Height = 25;
            this.DataGridViewBorrowers.Size = new System.Drawing.Size(747, 286);
            this.DataGridViewBorrowers.TabIndex = 3;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSearch.Location = new System.Drawing.Point(687, 53);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(79, 24);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSearch.Location = new System.Drawing.Point(19, 54);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(660, 23);
            this.TextBoxSearch.TabIndex = 1;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // LabelBorrower
            // 
            this.LabelBorrower.AutoSize = true;
            this.LabelBorrower.Location = new System.Drawing.Point(19, 26);
            this.LabelBorrower.Name = "LabelBorrower";
            this.LabelBorrower.Size = new System.Drawing.Size(99, 15);
            this.LabelBorrower.TabIndex = 0;
            this.LabelBorrower.Text = "Search Borrower: ";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 446);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelAux);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.PanelAux.ResumeLayout(false);
            this.PanelAux.PerformLayout();
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBorrowers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelAux;
        private Label LabelBorrowers;
        private Panel PanelMain;
        private Button ButtonPay;
        private Button ButtonAdd;
        private DataGridView DataGridViewBorrowers;
        private Button ButtonSearch;
        private TextBox TextBoxSearch;
        private Label LabelBorrower;
    }
}
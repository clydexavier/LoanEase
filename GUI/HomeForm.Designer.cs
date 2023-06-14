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
            this.PanelOverview = new System.Windows.Forms.Panel();
            this.LabelOverview = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPageToday = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TabPageThisWeek = new System.Windows.Forms.TabPage();
            this.TabPageThisMonth = new System.Windows.Forms.TabPage();
            this.TabPageThisYear = new System.Windows.Forms.TabPage();
            this.PanelOverview.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabPageToday.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelOverview
            // 
            this.PanelOverview.Controls.Add(this.LabelOverview);
            this.PanelOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelOverview.Location = new System.Drawing.Point(0, 0);
            this.PanelOverview.Name = "PanelOverview";
            this.PanelOverview.Size = new System.Drawing.Size(1140, 100);
            this.PanelOverview.TabIndex = 2;
            // 
            // LabelOverview
            // 
            this.LabelOverview.AutoSize = true;
            this.LabelOverview.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelOverview.Location = new System.Drawing.Point(33, 30);
            this.LabelOverview.Name = "LabelOverview";
            this.LabelOverview.Size = new System.Drawing.Size(159, 37);
            this.LabelOverview.TabIndex = 2;
            this.LabelOverview.Text = "Overview";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 482);
            this.panel1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPageToday);
            this.tabControl1.Controls.Add(this.TabPageThisWeek);
            this.tabControl1.Controls.Add(this.TabPageThisMonth);
            this.tabControl1.Controls.Add(this.TabPageThisYear);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1140, 482);
            this.tabControl1.TabIndex = 0;
            // 
            // TabPageToday
            // 
            this.TabPageToday.Controls.Add(this.panel3);
            this.TabPageToday.Controls.Add(this.panel2);
            this.TabPageToday.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TabPageToday.Location = new System.Drawing.Point(4, 25);
            this.TabPageToday.Name = "TabPageToday";
            this.TabPageToday.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageToday.Size = new System.Drawing.Size(1132, 453);
            this.TabPageToday.TabIndex = 0;
            this.TabPageToday.Text = "Today";
            this.TabPageToday.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1126, 319);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1126, 128);
            this.panel2.TabIndex = 0;
            // 
            // TabPageThisWeek
            // 
            this.TabPageThisWeek.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TabPageThisWeek.Location = new System.Drawing.Point(4, 37);
            this.TabPageThisWeek.Name = "TabPageThisWeek";
            this.TabPageThisWeek.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageThisWeek.Size = new System.Drawing.Size(1132, 441);
            this.TabPageThisWeek.TabIndex = 1;
            this.TabPageThisWeek.Text = "This Week";
            this.TabPageThisWeek.UseVisualStyleBackColor = true;
            // 
            // TabPageThisMonth
            // 
            this.TabPageThisMonth.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TabPageThisMonth.Location = new System.Drawing.Point(4, 37);
            this.TabPageThisMonth.Name = "TabPageThisMonth";
            this.TabPageThisMonth.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageThisMonth.Size = new System.Drawing.Size(1132, 441);
            this.TabPageThisMonth.TabIndex = 2;
            this.TabPageThisMonth.Text = "This Month";
            this.TabPageThisMonth.UseVisualStyleBackColor = true;
            // 
            // TabPageThisYear
            // 
            this.TabPageThisYear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TabPageThisYear.Location = new System.Drawing.Point(4, 37);
            this.TabPageThisYear.Name = "TabPageThisYear";
            this.TabPageThisYear.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageThisYear.Size = new System.Drawing.Size(1132, 441);
            this.TabPageThisYear.TabIndex = 3;
            this.TabPageThisYear.Text = "This Year";
            this.TabPageThisYear.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 582);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelOverview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.PanelOverview.ResumeLayout(false);
            this.PanelOverview.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.TabPageToday.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel PanelOverview;
        private Label LabelOverview;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage TabPageToday;
        private TabPage TabPageThisWeek;
        private TabPage TabPageThisMonth;
        private TabPage TabPageThisYear;
        private Panel panel3;
        private Panel panel2;
    }
}
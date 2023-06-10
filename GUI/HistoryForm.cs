﻿using LoanEase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            PopulatePayments();
        }

        public void PopulatePayments()
        {
            this.DGVPayments.Rows.Clear();
            foreach (Payment p in Database.Payments)
            {
                this.DGVPayments.Rows.Add(p.BorrowerName, p.BorrowerIsMember ? "Yes" : "No", p.PaymentTime.ToString("hh:mm MMMM d, yyyy"), p.AmountPayed.ToString("0.00"));
            }
        }
    }
}
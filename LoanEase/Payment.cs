using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanEase
{
    public class Payment
    {
        public string BorrowerName;
        public DateTime PaymentTime;
        public decimal AmountPayed;
        public bool BorrowerIsMember;

        public Payment(string borrowerName, DateTime paymentTime, decimal amountPayed, bool borrowerIsMember)
        {
            this.BorrowerName = borrowerName;
            this.PaymentTime = paymentTime;
            this.AmountPayed = amountPayed;
            this.BorrowerIsMember = borrowerIsMember;
        }
    }
}

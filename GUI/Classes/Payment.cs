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
        public DateTime BorrowedTime;
        public decimal AmountPayed;
        public bool BorrowerIsMember;
        

        public Payment(string borrowerName, DateTime paymentTime, DateTime borrowedTime, decimal amountPayed, bool borrowerIsMember)
        {
            this.BorrowerName = borrowerName;
            this.PaymentTime = paymentTime;
            this.BorrowedTime = borrowedTime;
            this.AmountPayed = amountPayed;
            this.BorrowerIsMember = borrowerIsMember;
        }
    }
}

using System.Runtime.CompilerServices;

namespace LoanEase
{
    public class Borrower
    {
        public string FirstName;
        public string LastName;
        public string FullName;
        public bool isMember;
        //name, is member, borrowed time, loan, monthly
        public decimal loan;
        public decimal initialLoan;
        public DateTime BorrowedTime;
        public DateTime? PayedTime;
        public decimal monthlyInterest;

        public Borrower(string first_name, string last_name, bool is_member, decimal loan)
        {
            this.FirstName = first_name;
            this.LastName = last_name;
            this.FullName = this.FirstName + " " + this.LastName;

            this.initialLoan= loan;
            this.isMember = is_member;
            
            this.BorrowedTime = DateTime.Now;
            this.monthlyInterest = Calculate.MonthlyInterest(isMember, loan);
            this.loan = loan + monthlyInterest;
        }

        public bool borrow(decimal amount)
        {
            //borrower can't borrow if they still have current loan to pay
            if (this.loan > 0) return false;

            this.monthlyInterest = Calculate.MonthlyInterest(this.isMember, amount);
            this.BorrowedTime = DateTime.Now;
            this.loan = Calculate.Loan(this.isMember, amount);
   
            return true;
        }
        public bool pay(decimal amount_payed)
        {
            //borrower can't pay if they don't have a loan
            if (this.loan <= 0) return false;

            this.loan = Calculate.Pay(this.loan, amount_payed);
            if(this.loan == 0) PayedTime = DateTime.Now;
            return true;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }


    }
}
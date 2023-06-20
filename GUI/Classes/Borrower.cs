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
        public decimal totalLoan;
        public decimal initialLoan;
        public decimal principal;
        public DateTime BorrowedTime;
        public DateTime? PayedTime;
        public decimal monthlyInterest;

        public Borrower(string first_name, string last_name, bool is_member, decimal loan)
        {
            this.FirstName = first_name;
            this.LastName = last_name;
            this.FullName = this.FirstName + " " + this.LastName;
            this.initialLoan = loan;

            this.principal= loan;
            this.isMember = is_member;
            
            this.BorrowedTime = DateTime.Now;
            this.monthlyInterest = Calculate.MonthlyInterest(isMember, loan);
            this.totalLoan = loan + monthlyInterest;
        }

        public bool borrow(decimal amount)
        {
            //borrower can't borrow if they still have current loan to pay
            if (this.totalLoan > 0) return false;

            this.monthlyInterest = Calculate.MonthlyInterest(this.isMember, amount);
            this.BorrowedTime = DateTime.Now;
            this.principal = Calculate.Loan(this.isMember, amount);
   
            return true;
        }
        public bool pay(decimal amount_payed)
        {
            //borrower can't pay if they don't have a loan
            if (this.totalLoan <= 0) return false;

            //if payment is more deduct principal amount
            if (monthlyInterest < amount_payed)
                this.principal = Calculate.Pay(this.principal, amount_payed - monthlyInterest);



            //deduct quarterly interest
            this.monthlyInterest = Calculate.Pay(this.monthlyInterest, amount_payed);

            if (totalLoan > amount_payed)
                totalLoan -= amount_payed;
            else totalLoan = 0;
            


            //if payment is more than two combined, give change


            if (this.totalLoan == 0) PayedTime = DateTime.Now;
            return true;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }


    }
}
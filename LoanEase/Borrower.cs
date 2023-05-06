namespace LoanEase
{
    public class Borrower
    {
        private string name;
        public bool isMember;

        private decimal loan;
        private DateTime BorrowedTime;
        private decimal monthlyInterest;

        public Borrower(string name, bool is_member, decimal loan)
        {
            this.name = name;
            this.isMember = is_member;
            this.loan = loan;
            this.BorrowedTime = default(DateTime);
            this.monthlyInterest = 0;
        }

        public bool borrow(decimal amount)
        {
            //borrower can't borrow if they still have current loan to pay
            if (this.loan > 0) return false;

            this.monthlyInterest = Calculate.MonthlyInterest(amount, this.isMember);
            this.BorrowedTime = DateTime.Now;
            this.loan = Calculate.Loan(amount, this.isMember);
   
            return true;
        }
        public bool pay(decimal amount)
        {
            //borrower can't pay if they don't have a loan
            if (this.loan <= 0) return false;

            this.loan = Calculate.Pay(this.loan, amount);
            return true;
        }
    }
}
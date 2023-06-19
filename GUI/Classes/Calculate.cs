using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanEase
{
 
    public static class Calculate
    {
        public const decimal member_interest = 0.03M;       // 3% interest for members
        public const decimal non_member_interest = 0.05M;   // 5% interest for non-members

        public static decimal Loan(bool isMember, decimal amount)
        {
            decimal total = amount;

            if(isMember)
                return total = total + (total * member_interest);

            return total = total + (total * non_member_interest);
            
        }

        public static decimal MonthlyInterest(bool isMember, decimal amount) 
        {
            if(isMember)
                return amount * member_interest;

            return amount * non_member_interest;
        }

        public static decimal Pay(decimal loan, decimal amount_payed) 
        {
         
            if(loan > amount_payed) return loan - amount_payed;

            return 0;

        }
    }



    

}

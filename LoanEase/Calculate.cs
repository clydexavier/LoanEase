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

        public static decimal Loan(decimal amount, bool is_member)
        {
            decimal total = amount;

            if(is_member)
                total = total + (total * member_interest);

            total = total + (total * non_member_interest);
            return total;
        }

        public static decimal MonthlyInterest(decimal amount, bool is_member) 
        {
            if(is_member)
                return amount * member_interest;

            return amount * non_member_interest;
        }

        public static decimal Pay(decimal current_loan, decimal amount) 
        {
         
            return current_loan - amount;
        }
    }



    

}

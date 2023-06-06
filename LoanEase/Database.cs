using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanEase
{

    public static class Database
    {
        public static List<Lender> lenders;
        public static List<Borrower> borrowers = new List<Borrower>();

        //initialize database
        public static void Init()
        {
            //borrowers = new List<Borrower>();
            borrowers.Add(new Borrower("Bogart", "Ignacio",false, 0));
            borrowers.Add(new Borrower("Mila","Makatigbak", true, 0));
            borrowers[0].borrow(1500);
            borrowers[1].borrow(1600);
        }

        
        public static void LoadLocal()
        {

        }

        public static void LoadOnline()
        {

        }

        public static void SaveLocal()
        {

        }

        public static void SaveOnline()
        {

        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LoanEase
{

    public static class Database
    {

        private static string DownloadPath = AppDomain.CurrentDomain.BaseDirectory;
        private static string LenderFileName = "Lender.ls";
        private static string BorrowersFilename = "Borrowers.ls";
        private static string PaymentsFilename = "Payments.ls";
        private static string TotalPaymentsFilename = "TotalPayments.ls";
        private static string TotalLendedFilename = "TotalLended.ls";

        public static Lender Lender;
        public static List<Borrower> borrowers = new List<Borrower>();
        public static List<Payment> Payments = new List<Payment>();

        public static decimal TotalPayments;
        public static decimal TotalLended;

        //initialize database
        public static void Init()
        {
            LoadLenderLocal();
            LoadBorrowersLocal();
            LoadPaymentsLocal();
            LoadTotalLended();

        }

        public static void Save()
        {
            SaveLenderLocal();
            SaveBorrowersLocal();
            SavePaymentsLocal();
            SaveTotalLended();
        }


        #region Borrowers
        public static void LoadBorrowersLocal()
        {
            string contents = System.IO.File.ReadAllText(Path.Combine(DownloadPath, BorrowersFilename));
            borrowers = JsonConvert.DeserializeObject<List<Borrower>>(contents);
            
        }
       

        public static void SaveBorrowersLocal()
        {
            string contents = JsonConvert.SerializeObject(borrowers);
            System.IO.File.WriteAllText(Path.Combine(DownloadPath, BorrowersFilename), contents);
        }
        #endregion

        #region Lender
        public static void LoadLenderLocal()
        {
            string contents = System.IO.File.ReadAllText(Path.Combine(DownloadPath, LenderFileName));
            Lender = JsonConvert.DeserializeObject<Lender>(contents);
        }

        public static void SaveLenderLocal()
        {

            string contents = JsonConvert.SerializeObject(Lender);
            System.IO.File.WriteAllText(Path.Combine(DownloadPath, LenderFileName), contents);
        }
        #endregion

        #region Payments
        public static void LoadPaymentsLocal()
        {
            string contents = System.IO.File.ReadAllText(Path.Combine(DownloadPath, PaymentsFilename));
            Payments = JsonConvert.DeserializeObject<List<Payment>>(contents);

            foreach (var x in Payments)
                TotalPayments += x.AmountPayed;
        }
        public static void SavePaymentsLocal()
        {
            string contents = JsonConvert.SerializeObject(Payments);
            System.IO.File.WriteAllText(Path.Combine(DownloadPath, PaymentsFilename), contents);
        }
        #endregion
      

        #region Total Lended
        public static void LoadTotalLended()
        {
            string contents = System.IO.File.ReadAllText(Path.Combine(DownloadPath, TotalLendedFilename));
            TotalLended = JsonConvert.DeserializeObject<decimal>(contents);
        }

        public static void SaveTotalLended() 
        {
            string contents = JsonConvert.SerializeObject(TotalLended);
            System.IO.File.WriteAllText(Path.Combine(DownloadPath, TotalLendedFilename), contents);
        }
        #endregion
    }
}

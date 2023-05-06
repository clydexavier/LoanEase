using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanEase
{
    public class Lender
    {
        private string name;
        private string username;
        private string password;

        public Lender(string name, string username, string password)
        {
            this.name = name;
            this.username = username;
            this.password = password;
        }

        public bool canLogin(string username, string password) 
        {
            return this.username == username && this.password == password;
        }
    }
}

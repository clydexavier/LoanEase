using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanEase
{
    public class Lender
    {
        [JsonRequired]
        public  string username;
        [JsonRequired]
        public string password;

        public Lender(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public bool canLogin(string username, string password) 
        {
            return this.username == username && this.password == password;
        }
    }
}

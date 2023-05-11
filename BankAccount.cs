using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemWF
{
    internal class BankAccount
    {
        public string AccountName;
        public double AccountBalance; 
        public BankAccount(string name, double balance) 
        {
            AccountName = name;
            AccountBalance = balance;
        }
    }
}

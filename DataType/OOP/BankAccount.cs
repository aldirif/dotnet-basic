using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.OOP
{
    public class BankAccount
    {
        // read
        public string Number { get; }
        // read , write
        public string Owner { get; set; }
        // read
        public decimal Balance { get; }

        public BankAccount()
        {
        }

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
        }
    }
}
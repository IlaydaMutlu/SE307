using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banker.Model
{
    public class Account
    {
        [Key]
        public int AccountNumber { get; set; }
        public decimal balance { get; set; }

        public Account(int accountNumber, decimal balance)
        {
            this.AccountNumber = accountNumber;
            this.balance = balance;
        }

        public void withdrawMoney(decimal money)
        {
            if (this.balance >= money)
            {
                this.balance -= money;
            }
        }
        public void depositMoney(decimal money)
        {
            this.balance += money;
        }
    }
}

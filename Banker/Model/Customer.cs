using Banker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Banker
{
    public class Customer : Person
    {
        private int _customerId;
        private int _accountId;
        public int customerId { get { return _customerId; } set { _customerId = value; } }
        public int accountId { get { return _accountId; } set { _accountId = value; } }
        public List<Account> Accounts { get; set; }
        public List<Foreign> ForeignCurrency { get; set; }
        public List<Gold> GoldAccounts { get; set; }
        public List<Loan> Loans { get; set; }

        public Customer()
        {
            Accounts = new List<Account>();
            ForeignCurrency = new List<Foreign>();
            GoldAccounts = new List<Gold>();
            Loans = new List<Loan>();
        }
        public void addAccount(int accountNumber, decimal balance)
        {
            if (this.Accounts == null)
            {
                this.Accounts = new List<Account>();
            }
            this.Accounts.Add(new Account(accountNumber, balance));
        }

        public void addForeign(int accountNumber, decimal balance, string type)
        {
            if(this.ForeignCurrency==null)
            {
                this.ForeignCurrency = new List<Foreign>();
            }
            this.ForeignCurrency.Add(new Foreign(accountNumber, balance, type));
        }

        public void addGold(int accountNumber,decimal balance)
        {
            if(this.GoldAccounts==null)
            {
                this.GoldAccounts = new List<Gold>();
            }
            this.GoldAccounts.Add(new Gold(accountNumber, balance));
        }

        public void addLoan(int id,string purpose,decimal amount, decimal montly,decimal total)
        {
            if(this.Loans==null)
            {
                this.Loans = new List<Loan>();
            }
            this.Loans.Add(new Loan(id, purpose, amount, montly, total));
        }
    }
}

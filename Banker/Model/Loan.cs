using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banker.Model
{
    public class Loan
    {
        private int _loanId;
        private string _purpose;
        private decimal _loanAmount;
        private decimal _month;
        private decimal _total;
        [Key]
        public int loanId { get { return _loanId; } set { _loanId = value; } }
        public string purpose { get { return _purpose; } set { _purpose = value; } }
        public decimal loanAmount { get { return _loanAmount; } set { _loanAmount = value; } }
        public decimal monthlyPayment { get { return _month; } set { _month = value; } }
        public decimal totalPayment { get { return _total; } set { _total = value; } }

        public Loan(int id, string purpose, decimal amount, decimal montly, decimal total)
        {
            this.loanId = id;
            this.purpose = purpose;
            this.loanAmount = amount;
            this.monthlyPayment = montly;
            this.totalPayment = total;
        }

        public void payment()
        {
            if (totalPayment>0)
            {
                this.totalPayment -= this.monthlyPayment;
            }
            
        }

    }
}

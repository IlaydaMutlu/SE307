using Banker.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banker
{
    public partial class accountForm : Form
    {
        public Customer customer;
        public accountForm()
        {
            InitializeComponent();
        }

        private void loanButton_Click(object sender, EventArgs e)
        {
            using (var db = new CustomerContext())
            {
                customer.addLoan(int.Parse(loanText.Text), purposeText.Text, decimal.Parse(amountText.Text), decimal.Parse(mountlyText.Text), decimal.Parse(totalText.Text));
                db.SaveChanges();
                MessageBox.Show("Loan added successfully");
            }
        }
        private void PaymentButton_Click(object sender, EventArgs e)
        {
            using (var db = new CustomerContext())
            {
                foreach (var item in customer.Loans)
                {
                    if (item.loanId == int.Parse(loanText.Text))
                    {
                        item.payment();
                    }
                }
                db.SaveChanges();
            }
        }

        private void ForeignButton_Click(object sender, EventArgs e)
        {
            using (var db = new CustomerContext())
            {
                customer.addForeign(int.Parse(ForeignnNumberText.Text), decimal.Parse(foreingBalanceText.Text), TypeText.Text );
                MessageBox.Show("Foreign Currency added successfully");
                db.SaveChanges();
            }
            
        }

        private void goldDepositButton_Click(object sender, EventArgs e)
        {
            using (var db = new CustomerContext())
            {
                foreach (var item in customer.GoldAccounts)
                {
                    if (item.AccountNumber == int.Parse(goldNumber.Text))
                    {
                        item.depositMoney(decimal.Parse(goldDepositText.Text));
                    }
                }
                db.SaveChanges();
            }
        }

        private void foreDepositButton_Click(object sender, EventArgs e)
        {
            using (var db = new CustomerContext())
            {
                foreach (var item in customer.ForeignCurrency)
                {
                    if (item.AccountNumber == int.Parse(ForeignnNumberText.Text))
                    {
                        item.depositMoney(decimal.Parse(DepositforeText.Text));
                    }
                }
                db.SaveChanges();
            }

        }

        private void foreDrawButton_Click(object sender, EventArgs e)
        {
            using (var db = new CustomerContext())
            {
                foreach (var item in customer.ForeignCurrency)
                {
                    if (item.AccountNumber == int.Parse(ForeignnNumberText.Text))
                    {
                        item.withdrawMoney(decimal.Parse(foreWithdrawText.Text));
                    }
                }
                db.SaveChanges();
            }
        }

        private void goldDrawButton_Click(object sender, EventArgs e)
        {
            using (var db = new CustomerContext())
            {
                foreach (var item in customer.GoldAccounts)
                {
                    if (item.AccountNumber == int.Parse(goldNumber.Text))
                    {
                        item.withdrawMoney(decimal.Parse(goldDrawText.Text));
                    }
                }
                db.SaveChanges();
            }
        }
    }
}

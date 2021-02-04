using Banker.Business;
using Banker.Model;
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
    public partial class Form1 : Form
    {
        public Customer customer;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new CustomerContext())
            {
                customer = new Customer { accountId =int.Parse(accountNoText.Text), name = nameText.Text, age =int.Parse( ageText.Text), address = addressText.Text, customerId =int.Parse(customerText.Text), gender = genderText.Text, phoneNumber = int.Parse( phoneText.Text), surname = surnameText.Text, TCno = int.Parse(tctextbox.Text) };
                db.Customers.Add(customer);
                
                db.SaveChanges();
                MessageBox.Show("Customer added successfully");

               /* var query = from b in db.Customers orderby b.TCno select b;
                foreach (var item in query)
                {
                    MessageBox.Show(item.name);
                }*/
                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new CustomerContext())
            {
                customer.addAccount(int.Parse(accountNumberText.Text), decimal.Parse(balanceText.Text));
                MessageBox.Show("Account added successfully");
            }
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            
            foreach (var item in customer.Accounts)
            {
                if (item.AccountNumber == int.Parse(accountNumberText.Text))
                {
                    item.depositMoney(decimal.Parse(Deposit.Text));
                }
            }
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            foreach (var item in customer.Accounts)
            {
                if (item.AccountNumber == int.Parse(accountNumberText.Text))
                {
                    item.withdrawMoney(decimal.Parse(withdrawText.Text));
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var searchForm = new searchFrom();
            searchForm.Show();
        }

        private void loanButton_Click(object sender, EventArgs e)
        {
            var accountForm = new accountForm();
            accountForm.Show();
        }

        private void currencyButton_Click(object sender, EventArgs e)
        {
            var accountForm = new accountForm();
            accountForm.Show();
        }

        private void goldButton_Click(object sender, EventArgs e)
        {
            var accountForm = new accountForm();
            accountForm.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var updateForm = new UpdateForm();
            updateForm.Show();
        }
    }
}

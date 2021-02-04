using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banker.Business;
using Banker.Model;

namespace Banker
{
    public partial class CreateCustomerAccount : Form
    {
        Customer customer;
        public CreateCustomerAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new CustomerContext())
            {
                customer = new Customer { accountId = int.Parse(accountidtxt.Text), name = nametxt.Text, age = int.Parse(agetxt.Text), address = addresstxt.Text, customerId = int.Parse(customeridtxt.Text), gender = gendertxt.Text, phoneNumber = int.Parse(phonetxt.Text), surname = surnametxt.Text, TCno = int.Parse(tctxt.Text) };
                db.Customers.Add(customer);

                db.SaveChanges();
                MessageBox.Show("Customer added successfully");
            }
        }
    }
}

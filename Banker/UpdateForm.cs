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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void newAccount_Click(object sender, EventArgs e)
        {
            using (var db = new CustomerContext())
            {
                var customer = db.Customers.SingleOrDefault(x=>x.TCno == int.Parse(tctextbox.Text));
                customer.accountId = int.Parse(accountNoText.Text);
                customer.address = addressText.Text;
                customer.age = int.Parse(ageText.Text);
                customer.customerId = int.Parse(customerText.Text);
                customer.gender = genderText.Text;
                customer.name = nameText.Text;
                customer.surname = surnameText.Text;
                customer.phoneNumber = int.Parse( phoneText.Text);
                db.SaveChanges();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (var db = new CustomerContext())
            {
                var customer = db.Customers.SingleOrDefault(x => x.TCno == int.Parse(tctextbox.Text));
                db.Customers.Remove(customer);
                db.SaveChanges();
            }
        }
    }
}

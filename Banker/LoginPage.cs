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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(usernametxt.Text!=string.Empty)
            {

                int usertxt = int.Parse(usernametxt.Text);

                var db = new CustomerContext();

                var x = from p in db.Customers
                        where (p.TCno == usertxt && p.surname == passwordtxt.Text)
                        select p;

                if (x.Any())
                {
                    Form1 form = new Form1();
                    form.ShowDialog();
                }
                else
                    MessageBox.Show("Invalid ID or Password !");

            }
            else
            {
                Form1 form = new Form1();
                form.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmployeePage emp = new EmployeePage();
            emp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateCustomerAccount custAcc = new CreateCustomerAccount();
            custAcc.ShowDialog();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            CreateEmployeeAccount createEmp = new CreateEmployeeAccount();
            createEmp.ShowDialog();
        }
    }
}

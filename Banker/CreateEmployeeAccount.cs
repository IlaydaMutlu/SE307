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
    public partial class CreateEmployeeAccount : Form
    {
        Employee employee;
        public CreateEmployeeAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new EmployeeContext())
            {
                employee = new Employee { employeeId = int.Parse(employeetxt.Text), name = nametxt.Text, age = int.Parse(agetxt.Text), address = addresstxt.Text, gender = gendertxt.Text, phoneNumber = int.Parse(phonetxt.Text), surname = surnametxt.Text, TCno = int.Parse(tctxt.Text) };
                db.Employees.Add(employee);

                db.SaveChanges();
                MessageBox.Show("Employee added successfully");
            }
        }
    }
}

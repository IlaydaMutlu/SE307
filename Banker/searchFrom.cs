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
    public partial class searchFrom : Form
    {
       
        public searchFrom()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            using (var db = new CustomerContext())
            {
                var customer = db.Customers.Where(x => x.TCno == int.Parse(searchText.Text));
                dataGridView1.Rows.Add(customer);
            }
                
        }

    }
}

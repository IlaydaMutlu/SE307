using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingManagerTrial
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = "Login Page";
        }

        

        private void loginButton_Click(object sender, EventArgs e)
        {
            banking_managementEntities1 test = new banking_managementEntities1();
            if (usernameText.Text != string.Empty || passwordText.Text != string.Empty)
            {
                var user1 = test.Login_Table.FirstOrDefault(a => a.Username.Equals(usernameText.Text));
                if (user1 != null)
                {
                    if (user1.Password.Equals(passwordText.Text))
                    {
                        //this.Hide();
                        Menu nwMenu = new Menu();
                        nwMenu.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password !");
                    }
                }
                else
                {
                    MessageBox.Show("null");
                }
            }
            else
            {
                MessageBox.Show("null");
            }
        }
    }
}

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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void newAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newAccount newAcc = new newAccount();
            newAcc.MdiParent = this;
            newAcc.Show();
        }

        private void searchAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchAccount searchAcc = new searchAccount();
            searchAcc.MdiParent = this;
            searchAcc.Show();
        }

        private void listAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listAccount listAcc = new listAccount();
            listAcc.MdiParent = this;
            listAcc.Show();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deposit depo = new Deposit();
            depo.MdiParent = this;
            depo.Show();
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Withdraw depo = new Withdraw();
            depo.MdiParent = this;
            depo.Show();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transfer depo = new Transfer();
            depo.MdiParent = this;
            depo.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
            

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword changePass = new ChangePassword();
            changePass.MdiParent = this;
            changePass.Show();

        }
    }
}

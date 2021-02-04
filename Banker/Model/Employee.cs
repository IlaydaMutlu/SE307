using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banker.Model;
using System.Data;
using Banker.Business;

namespace Banker.Model
{
    public class Employee: Person
    {
       private int _employeeId;
        
        public int employeeId { get { return _employeeId; } set { _employeeId = value; } }
        
        
        public Employee()
        {
            
        }

        public void openAccount()
        {

        }
        public void closeAccount()
        {

        }
        public void collectMoney()
        {

        }
        public Loan LoanRequest()
        {
            Loan loan = new Loan(10,"",10,10,10);
            return loan;
        }
        public void changePassword(string pass)
        {
            surname = pass;
        }

        public void provideInfo()
        {

        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banker.Model
{
    public class Gold : Account
    {
        public Gold(int accountNumber, decimal balance) : base(accountNumber, balance)
        {
        }
    }
}

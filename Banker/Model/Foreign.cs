using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banker.Model
{
    public class Foreign : Account
    {
        private string _type;
        public string type { get { return _type; } set { _type = value; } }
        public Foreign(int accountNumber, decimal balance, string type) : base(accountNumber, balance)
        {
        }
    }
}

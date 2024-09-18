using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6__Liskov_substitution.After
{
    internal abstract class RegularAccount : Account
    {
        public RegularAccount(string name, decimal balance) : base(name, balance)
        {

        }

        public abstract void Withdraw(decimal amount);
    }
}

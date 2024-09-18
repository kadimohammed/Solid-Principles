using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6__Liskov_substitution.After
{
    internal abstract class Account
    {
        public string name { get; set; }
        public decimal balance { get; set; }

        protected Account()
        {
            
        }
        public Account(string name, decimal balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public override string ToString()
        {
            return $"Name : {name} Balance: {balance}";
        }

        public abstract void Deposit(decimal amount);

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6__Liskov_substitution.Before
{
    internal class SwingAccount : Account
    {
        public SwingAccount(string name, decimal balance) : base(name, balance)
        {

        }

        public override void Deposit(decimal amount)
        {
            balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            balance -= amount;
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6__Liskov_substitution.Before
{
    internal class FixedDepositAccount : Account
    {
        public FixedDepositAccount(string name, decimal balance) : base(name, balance)
        {

        }

        public override void Deposit(decimal amount)
        {
            balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            throw new NotSupportedException("You can not Withdraw");
        }
    }
}
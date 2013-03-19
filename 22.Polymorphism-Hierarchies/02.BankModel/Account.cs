using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.BankModel
{
    abstract class Account
    {
        public decimal Balance { get; protected set; }
        public decimal InterestRate { get; private set; }
        public Customer Owner { get; private set; }

        public Account(decimal interestRate, Customer owner)
        {
            this.InterestRate = interestRate;
            this.Owner = owner;
        }

        public abstract decimal CalculateInterest(int months);
    }
}

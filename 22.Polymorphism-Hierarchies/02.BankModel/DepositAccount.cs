using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.BankModel
{
    class DepositAccount : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(decimal interestRate, Customer owner)
            : base(interestRate, owner)
        {  }

        public void Withdraw(decimal withdraw)
        {
            this.Balance -=withdraw;
        }

        public void Deposit(decimal deposit)
        {
            this.Balance += deposit;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                return this.Balance*(this.InterestRate*months);
            }
        }
    }
}

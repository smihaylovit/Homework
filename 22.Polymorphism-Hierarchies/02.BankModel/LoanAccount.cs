using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.BankModel
{
    class LoanAccount : Account, IDepositable
    {
       
        
        public LoanAccount(decimal interestRate, Customer owner, decimal loan)
            : base(interestRate, owner)
        {
            //the loans account in banks are negative :)
            this.Balance = loan * (-1);
        }

        public void Deposit(decimal deposit)
        {
            this.Balance += deposit;
        }

        public override decimal CalculateInterest(int months)
        {
            //this.Balance*(-1) - because the loans account in banks are negative :)
            return (this.Balance*(-1)) * ((months - this.Owner.FreeInterestMonths) * this.InterestRate);
        }
    }
}

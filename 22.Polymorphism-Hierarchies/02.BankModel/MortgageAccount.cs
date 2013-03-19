using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.BankModel
{
    class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(decimal interestRate, Customer owner, decimal loan)
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
            if (months<=this.Owner.MortgageMonthsDiscount)
            {
                //this.Balance*(-1) - because the loans account in banks are negative :)
                return (this.Balance*(-1)) * (this.InterestRate * (1 - this.Owner.MortgageDiscount) * months);
            }
            else
            {
                //this.Balance*(-1) - because the loans account in banks are negative :)
                decimal promotionalRate = (this.Balance * (-1)) * (this.InterestRate * (1 - this.Owner.MortgageDiscount) * this.Owner.MortgageMonthsDiscount);
                promotionalRate += (this.Balance * (-1)) * this.InterestRate * (months - this.Owner.MortgageMonthsDiscount);

                return promotionalRate;
            }
        }
    }
}

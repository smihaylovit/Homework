using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.BankModel
{
    abstract class Customer :  IFreeInterestable
    {
        //creating unique ID for every customer
        public Guid ID { get; private set; }
        //this is for free-interest for LoanDeposits
        public abstract int FreeInterestMonths { get; protected set; }
        //this is discount for MortgageDeposit
        public abstract decimal MortgageDiscount { get; protected set; }
        public abstract int MortgageMonthsDiscount { get; protected set; } 


        public Customer()
        {
            this.ID = Guid.NewGuid();
        }


        
    }
}

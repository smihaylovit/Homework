using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.BankModel
{
    class CompanyCustomer : Customer
    {
        public string Name { get; private set; }
        public string Owner { get; private set; }
        public string Phone { get; private set; }
        //these fields are needed to calculate the interest
        public override int FreeInterestMonths { get; protected set; }

        public override decimal MortgageDiscount
        { get; protected set; }

        public override int MortgageMonthsDiscount
        { get; protected set; }

        public CompanyCustomer(string name, string owner, string phone)
            : base()
        {
            this.Name = name;
            this.Owner = owner;
            this.Phone = phone;
            //sets the count of free interest months
            this.FreeInterestMonths = 2;
            //set the discounts for MortgageDiscount
            this.MortgageDiscount = 0.5m; //50 percents by condition
            this.MortgageMonthsDiscount = 12; //12 months

        }

    }
}

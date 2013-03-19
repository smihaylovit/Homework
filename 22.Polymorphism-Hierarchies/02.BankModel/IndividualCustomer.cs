using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.BankModel
{
    class IndividualCustomer : Customer
    {
        public string FirstName { get; private set; }
        public string SecondName { get; private set; }
        public string EGN { get; private set; }
        public string Phone { get; set; }
        public override int FreeInterestMonths { get; protected set; }

        public override decimal MortgageDiscount
        { get; protected set; }

        public override int MortgageMonthsDiscount
        { get; protected set; }

        //I prefer to use string type for EGN
        public IndividualCustomer(string firstName, string secondName, string EGN, string phone) 
            : base()
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.EGN = EGN;
            this.Phone = phone;
            //sets the count of free interest months
            this.FreeInterestMonths = 3;

            this.MortgageDiscount = 1m; //100 percents by condition
            this.MortgageMonthsDiscount = 6; //6 months
        }
    }
}

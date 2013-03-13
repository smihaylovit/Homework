using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.HumanBeings
{
    class Worker : Human
    {
        //<fields>
        
        //we will use decimal for more precision in Salary
        private decimal? weekSalary;
        private double? workHoursPerDay;
        //</fields>

        //<properties>
        public double? WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set { workHoursPerDay = value; }
        }
        
        public decimal? WeekSalary
        {
            get { return weekSalary; }
            set { weekSalary = value; }
        }
        //</properties>
        
        //<constructors>
        
        //by the time of creating instance we might not be 
        //provided with the salary info
        public Worker(string firstName, string secondName)
            : this(firstName, secondName, null, null) { }

        public Worker(string firstName, string secondName, decimal? weekSalary)
            : this(firstName, secondName, weekSalary, null) { }
        
        
        //calling the base() constructor to access the inherited properties
        public Worker(string firstName, string secondName, decimal? weekSalary, double? workHoursPerDay)
            : base(firstName, secondName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        //<constructors>

        //<methods>
        public decimal MoneyPerHour()
        {

            if (this.WorkHoursPerDay.HasValue && this.WeekSalary.HasValue)
            {
                return (decimal)this.WeekSalary / (decimal)this.WorkHoursPerDay;   
            }

            //if some of the value is null
            //return -1 
            return -1;
        }
        //</methods>

    }
}

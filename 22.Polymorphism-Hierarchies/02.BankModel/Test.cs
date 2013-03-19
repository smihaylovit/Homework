using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.BankModel
{
    class Test
    {
        public static void BankModel() 
        {

            Console.WriteLine("\n\n============================");
            Console.WriteLine("DepositAccount");
            Console.WriteLine("============================\n\n");

            DepositAccount myDepositIndividual = new DepositAccount(0.10m, new IndividualCustomer("Haralampi", "Abdunkov", "998877665544", "++359 888 111 222"));
            DepositAccount myDepositCompany = new DepositAccount(0.10m, new CompanyCustomer("Baba Meca LTD", "Lion King", "++359 2 123 123"));

            myDepositCompany.Deposit(100);
            Console.WriteLine("Added 100BGN to myDepositCompany after that: {0}", myDepositCompany.Balance);
            myDepositIndividual.Deposit(100);
            Console.WriteLine("Added 100BGN to myDepositIndividual after that: {0}", myDepositIndividual.Balance);

            myDepositCompany.Withdraw(60);
            Console.WriteLine("Withdrawed 600BGN from myDepositCompany after that: {0}", myDepositCompany.Balance);
            myDepositIndividual.Withdraw(60);
            Console.WriteLine("Withdrawed 60BGN from myDepositIndividual after that: {0}", myDepositIndividual.Balance);

            
            Console.WriteLine("myDepositCompany balance: {0} interest for 12 months: {1}", myDepositCompany.Balance, myDepositCompany.CalculateInterest(12));
            Console.WriteLine("myDepositIndividual balance: {0} interest for 12 months: {1}", myDepositIndividual.Balance, myDepositIndividual.CalculateInterest(12));

            myDepositCompany.Deposit(961);
            myDepositIndividual.Deposit(961);

            Console.WriteLine("myDepositCompany balance: {0} interest for 12 months: {1}", myDepositCompany.Balance, myDepositCompany.CalculateInterest(12));
            Console.WriteLine("myDepositIndividual balance: {0} interest for 12 months: {1}", myDepositIndividual.Balance, myDepositIndividual.CalculateInterest(12));


            Console.WriteLine("\n\n============================");
            Console.WriteLine("LoanAccount");
            Console.WriteLine("============================\n\n");
            LoanAccount myLoanIndividual = new LoanAccount(0.10m, new IndividualCustomer("Haralampi", "Abdunkov", "998877665544", "++359 888 111 222"), 1100);
            LoanAccount myLoanCompany = new LoanAccount(0.10m, new CompanyCustomer("Baba Meca LTD", "Lion King", "++359 2 123 123"), 1100);

            myLoanCompany.Deposit(100);
            Console.WriteLine("Added 100BGN to myLoanCompany after that: {0}", myLoanCompany.Balance);
            myLoanIndividual.Deposit(100);
            Console.WriteLine("Added 100BGN to myLoanIndividual after that: {0}", myLoanIndividual.Balance);

            Console.WriteLine("myLoanCompany balance: {0} interest for 12 months: {1}", myLoanCompany.Balance, myLoanCompany.CalculateInterest(12));
            Console.WriteLine("myLoanIndividual balance: {0} interest for 12 months: {1}", myLoanIndividual.Balance, myLoanIndividual.CalculateInterest(12));

            myLoanCompany.Deposit(900);
            myLoanIndividual.Deposit(900);

            Console.WriteLine("myLoanCompany balance: {0} interest for 12 months: {1}", myLoanCompany.Balance, myLoanCompany.CalculateInterest(12));
            Console.WriteLine("myLoanIndividual balance: {0} interest for 12 months: {1}", myLoanIndividual.Balance, myLoanIndividual.CalculateInterest(12));

            Console.WriteLine("\n\n============================");
            Console.WriteLine("MortgageAccount");
            Console.WriteLine("============================\n\n");
            MortgageAccount myMortgageIndividual = new MortgageAccount(0.10m, new IndividualCustomer("Haralampi", "Abdunkov", "998877665544", "++359 888 111 222"), 1100);
            MortgageAccount myMortgageCompany = new MortgageAccount(0.10m, new CompanyCustomer("Baba Meca LTD", "Lion King", "++359 2 123 123"), 1100);

            myMortgageCompany.Deposit(100);
            Console.WriteLine("Added 100BGN to myMortgageCompany after that: {0}", myMortgageCompany.Balance);
            myMortgageIndividual.Deposit(100);
            Console.WriteLine("Added 100BGN to myMortgageIndividual after that: {0}", myMortgageIndividual.Balance);

            Console.WriteLine("myMortgageCompany balance: {0} interest for 12 months: {1}", myMortgageCompany.Balance, myMortgageCompany.CalculateInterest(12));
            Console.WriteLine("myMortgageIndividual balance: {0} interest for 12 months: {1}", myMortgageIndividual.Balance, myMortgageIndividual.CalculateInterest(12));

            myMortgageCompany.Deposit(900);
            myMortgageIndividual.Deposit(900);

            Console.WriteLine("myMortgageCompany balance: {0} interest for 24 months: {1}", myMortgageCompany.Balance, myMortgageCompany.CalculateInterest(12));
            Console.WriteLine("myMortgageIndividual balance: {0} interest for 24 months: {1}", myMortgageIndividual.Balance, myMortgageIndividual.CalculateInterest(12));
        }
    }
}

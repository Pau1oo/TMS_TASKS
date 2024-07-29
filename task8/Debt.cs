using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class Debt
    {
        public double Balance;
        public double InterestRate;

        public Debt(double initialBalance, double initialInterestRate)
        {
            Balance = initialBalance;
            InterestRate = initialInterestRate;
        }

        public void PrintBalance()
        {
            Console.WriteLine($"Баланс: {Balance:C2}");
        }

        public void WaitOneYear()
        {
            Balance = Balance * InterestRate;
        }
    }

}

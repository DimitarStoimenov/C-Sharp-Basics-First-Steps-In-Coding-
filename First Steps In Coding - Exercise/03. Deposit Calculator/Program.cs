using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int timeDeposit = int.Parse(Console.ReadLine());
            double yearPercent = double.Parse(Console.ReadLine());

            double accruedInterest = deposit * yearPercent / 100.0;
            double mounthInterest = accruedInterest / 12;
            double sum = deposit + timeDeposit * mounthInterest;

            Console.WriteLine(sum);

        }
    }
}

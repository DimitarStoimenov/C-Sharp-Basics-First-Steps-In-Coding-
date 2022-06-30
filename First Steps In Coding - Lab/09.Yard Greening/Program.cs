using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {

            double metersHouse = double.Parse(Console.ReadLine());

            double meter = 7.61;

            double priceYard = metersHouse * meter;
            double priceDiscount = priceYard - 0.18 * priceYard;
            double finishPrice = priceYard - priceDiscount;

            Console.WriteLine("The final price is: " + priceDiscount + " lv.");
            Console.WriteLine("The discount is: " + finishPrice + " lv.");





        }
    }
}

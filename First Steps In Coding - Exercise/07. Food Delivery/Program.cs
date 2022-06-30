using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int Chicken = int.Parse(Console.ReadLine());
            int Fish = int.Parse(Console.ReadLine());
            int Vegan = int.Parse(Console.ReadLine());


            double chickenPrice = Chicken * 10.35;
            double fishPrice = Fish * 12.40;
            double veganPrice = Vegan * 8.15;
            double allSumMenu = chickenPrice + fishPrice + veganPrice;
            double dessertPrice = allSumMenu * 0.20;
            double deliveryPrice = 2.50;
            double priceBill = allSumMenu + dessertPrice + deliveryPrice;

            Console.WriteLine(priceBill);

        }
    }
}

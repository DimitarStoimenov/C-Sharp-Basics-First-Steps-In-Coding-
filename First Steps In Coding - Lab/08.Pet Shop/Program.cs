using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double oneDogFood = 2.50;
            int oneCatFoot = 4;
            string lv = " lv.";
            int dogFoot = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());

            double expenses = oneDogFood * dogFoot + oneCatFoot * catFood;

            Console.WriteLine(expenses + lv);





        }
    }
}

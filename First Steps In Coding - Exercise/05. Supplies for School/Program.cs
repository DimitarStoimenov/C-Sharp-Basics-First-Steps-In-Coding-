﻿using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPens = int.Parse(Console.ReadLine());
            int countMarkers = int.Parse(Console.ReadLine());
            int litersPrep = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            double pricePens = countPens * 5.80;
            double priceMarkers = countMarkers * 7.20;
            double pricePrep = litersPrep * 1.20;

            double sum = pricePens + priceMarkers + pricePrep;

            sum = sum - (percent / 100.0) * sum;

            Console.WriteLine(sum);



        }
    }
}

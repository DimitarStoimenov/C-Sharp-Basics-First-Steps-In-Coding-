﻿using System;

namespace Basketball_Eqitment
{
    class Program
    {
        static void Main(string[] args)
        {
            int taxPerYear = int.Parse(Console.ReadLine());
            double trainersPrice = taxPerYear - 0.4 * taxPerYear;
            double outfitPrice = trainersPrice - 0.2 * trainersPrice;
            double ballPrice = outfitPrice / 4;
            double accPrice = ballPrice / 5;

            double expenses = taxPerYear + trainersPrice + outfitPrice + ballPrice + accPrice;

            Console.WriteLine(expenses);

        }
    }
}

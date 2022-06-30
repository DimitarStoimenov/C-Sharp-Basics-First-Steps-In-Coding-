using System;

namespace RadiandtoDegreese
{
    class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double centimeters = radians * 180 / Math.PI;
            Console.WriteLine(radians = centimeters);

        }
    }
}

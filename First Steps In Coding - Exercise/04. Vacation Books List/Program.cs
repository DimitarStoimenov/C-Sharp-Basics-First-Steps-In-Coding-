using System;

namespace VacationBookList
{
    class Program
    {
        static void Main(string[] args)
        {
            int allBookPages = int.Parse(Console.ReadLine());
            int pagesForHour = int.Parse(Console.ReadLine());
            int daysToRead = int.Parse(Console.ReadLine());

            int allTimeRead = allBookPages / pagesForHour;
            int hoursPerDay = allTimeRead / daysToRead;

            Console.WriteLine(hoursPerDay);
        }
    }
}

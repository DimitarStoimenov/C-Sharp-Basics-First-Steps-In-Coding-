using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string theArchitect = Console.ReadLine();
            int Project = int.Parse(Console.ReadLine());
            int projectHours = Project * 3;

            Console.WriteLine($"The architect {theArchitect} will need {projectHours} hours to complete {Project} project/s.");

        }
    }
}

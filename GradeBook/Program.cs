using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Grade Book");

            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit.");
                var userInput = Console.ReadLine();

                if (userInput == "q")
                {
                    break;
                }

                var grade = double.Parse(userInput);
                book.AddGrade(grade);
            }

            var stats = book.GetStatistics();
            Console.WriteLine($"The Lowest grade is: {stats.Low}");
            Console.WriteLine($"The Highest grade is: {stats.High}");
            Console.WriteLine($"The Average grade is: {stats.Average}");
        }
    }
}

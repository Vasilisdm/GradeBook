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

                try
                {
                    var grade = double.Parse(userInput);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("****");
                }

                
            }

            var stats = book.GetStatistics();
            Console.WriteLine($"The Lowest grade is: {stats.Low}");
            Console.WriteLine($"The Highest grade is: {stats.High}");
            Console.WriteLine($"The Average grade is: {stats.Average}");
        }
    }
}

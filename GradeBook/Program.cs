using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Test");
            book.AddGrade(89.1);
            book.AddGrade(79.1);
            book.AddGrade(69.1);

            var stats = book.GetStatistics();
            Console.WriteLine($"The Lowest grade is: {stats.Low}");
            Console.WriteLine($"The Highest grade is: {stats.High}");
            Console.WriteLine($"The Average grade is: {stats.Average}");
        }
    }
}

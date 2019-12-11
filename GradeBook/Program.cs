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
            book.ShowStatistics();
           
        }
    }
}

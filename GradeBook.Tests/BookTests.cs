using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            Book book = new Book("");
            book.AddGrade(89.3);
            book.AddGrade(77.8);
            book.AddGrade(98.8);

            // Act
            var result = book.GetStatistics();
        }
    }
}

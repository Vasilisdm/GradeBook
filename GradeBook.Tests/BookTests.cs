using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            // Arrange
            Book book = new Book("");
            book.AddGrade(89.3);
            book.AddGrade(77.8);
            book.AddGrade(98.8);

            // Act
            var result = book.GetStatistics();

            // Assert
            Assert.Equal(result.Low, 77.8);
            Assert.Equal(result.High, 98.8);
            Assert.Equal(result.Average, 88.6, 1);
        }
    }
}

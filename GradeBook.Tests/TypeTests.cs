using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void test1()
        {
            var book = GetBook("Book1");
            var book2 = GetBook("Book2");

            Assert.Equal("Book1", book.Name);
            Assert.Equal("Book2", book2.Name);

        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}

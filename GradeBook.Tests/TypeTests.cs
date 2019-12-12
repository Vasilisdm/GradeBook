using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void PassingByRef()
        {
            var book = new Book("Book");
            GetBookSetName(out book, "Da Vinci Code");

            Assert.Equal(book.Name, "Da Vinci Code");
        }

        private void GetBookSetName(out Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book = GetBook("Book1");
            var book2 = GetBook("Book2");

            Assert.Equal("Book1", book.Name);
            Assert.Equal("Book2", book2.Name);

        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book = GetBook("Book1");
            SetName(book, "new book name");

            Assert.Equal("new book name", book.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        private Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}

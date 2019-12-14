using System;
using Xunit;

namespace GradeBook.Tests
{
    public delegate string WriteLogDelegate(string logMessage);

    public class TypeTests
    {
        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log;

            log = ReturnMessage;

            var result = log("Hello");
            Assert.Equal("Hello", result);
        }

        string ReturnMessage(string message)
        {
            return message;
        }

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "John";
            var upperName = MakeUpperCase(name);

            Assert.Equal("John", name);
            Assert.Equal("JOHN", upperName);
        }

        [Fact]
        public void PassingByRef()
        {
            var book = new Book("Book");
            GetBookSetName(out book, "Da Vinci Code");

            Assert.Equal(book.Name, "Da Vinci Code");
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

        private object MakeUpperCase(string parameter)
        {
            return parameter.ToUpper();
        }

        private void GetBookSetName(out Book book, string name)
        {
            book = new Book(name);
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

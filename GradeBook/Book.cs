using System;
namespace GradeBook
{
    public abstract class Book : NamedObject
    {
        public Book(string name) : base(name)
        {
            Name = name;
        }

        public abstract void AddGrade(double grade);
    }
}

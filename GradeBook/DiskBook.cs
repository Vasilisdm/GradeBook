﻿using System;
using System.IO;

namespace GradeBook
{
    public class DiskBook : Book
    {
        public DiskBook(string name) : base(name)
        {
        }

        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(double grade)
        {
            using (var writer = File.AppendText($"{Name}.txt"))
            {
                writer.WriteLine(grade);
                GradeAdded?.Invoke(this, new EventArgs());
            }

        }

        public override Statistics GetStatistics()
        {
            Statistics result = new Statistics();

            using(var reader = File.OpenText($"{Name}.txt"))
            {
                var line = reader.ReadLine();
                while (line !=null)
                {
                    var grade = double.Parse(line);
                    result.Add(grade);
                    line = reader.ReadLine();
                }
            }

            return result;
        }
    }
}

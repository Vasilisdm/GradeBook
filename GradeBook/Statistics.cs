using System;
namespace GradeBook
{
    public class Statistics
    {
        public double High;
        public double Low;

        public double Average
        {
            get
            {
                return Sum / Count;
            }
        }

        public char Letter
        {
            get
            {
                switch (Average)
                {
                    case var d when d > 90:
                        return 'A';
                    case var d when d > 80:
                        return 'B';
                    case var d when d > 70:
                        return 'C'; 
                    case var d when d > 60:
                        return 'D'; 
                    default:
                        return 'F'; 
                }
            }

        }
        public int Count;
        public double Sum;

        public void Add(double grade)
        {
            Sum += grade;
            Count += 1;
            Low = Math.Min(grade, Low);
            High = Math.Max(grade, High);
        }

        public Statistics()
        {
            Count = 0;
            Sum = 0.0;
            High = double.MinValue;
            Low = double.MaxValue;
        }
    }
}

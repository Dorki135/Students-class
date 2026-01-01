namespace studentsSystem
{
    using System;
    using System.Data;
    using System.Dynamic;

    public class Student
    {
        private string name;
        private string id;
        private int englishGrade;
        private int mathGrade;
        private int hebrewGrade;
        public Student(string name, string id, int englishGrade, int mathGrade, int hebrewGrade)
        {
            this.name = name;
            this.id = id;
            this.englishGrade = englishGrade;
            this.mathGrade = mathGrade;
            this.hebrewGrade = hebrewGrade;
        }

        public int GetMathGrade()
        {
            return this.mathGrade;
        }
        public int GetHebrewGrade()
        {
            return this.hebrewGrade;
        }
        public int GetEnglishGrade()
        {
            return this.englishGrade;
        }
        public void SetMathGrade(int grade)
        {
            this.mathGrade = grade;
        }
        public string GetId()
        {
            return this.id;
        }
        public string GetName()
        {
            return this.name;
        }
        public double GetAverage()
        {
            return (this.englishGrade + this.mathGrade + this.hebrewGrade) / 3.0;
        }
        public void SetEnglishGrade(int grade)
        {
            this.englishGrade = grade;
        }
        public void SetHebrewGrade(int grade)
        {
            this.hebrewGrade = grade;
        }
        public void raiseGrade(int increase, string subject)
        {
            if (subject == "english")
            {
                this.englishGrade += increase;
            }
            else if (subject == "hebrew")
            {
                this.hebrewGrade += increase;
            }
            else if (subject == "math")
            {
                this.mathGrade += increase;
            }
        }
        public void printdocumentary()
        {
            Console.WriteLine("Student name: " + this.name);
            Console.WriteLine("Student ID: " + this.id);
            Console.WriteLine("English Grade: " + this.englishGrade);
            Console.WriteLine("Math Grade: " + this.mathGrade);
            Console.WriteLine("Hebrew Grade: " + this.hebrewGrade);
            Console.WriteLine("Average Grade: " + this.GetAverage());
        }
    }
}

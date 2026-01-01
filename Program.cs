using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using studentsSystem;
namespace studentSystem
{
    public class Program
    {
        public static void StudentsAvgGreter85(Student[] students)
        {
            System.Console.WriteLine("Students with average grade greater than 85:");
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].GetAverage() > 85)
                {
                    System.Console.WriteLine(students[i].GetName());
                }
            }
        }
        public static void RaiseGrades(Student[] students, double increase, string id)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (id == students[i].GetId())
                {
                    students[i].raiseGrade((int)(students[i].GetMathGrade() * (increase / 100)), "math");
                    students[i].raiseGrade((int)(students[i].GetEnglishGrade() * (increase / 100)), "english");
                    students[i].raiseGrade((int)(students[i].GetHebrewGrade() * (increase / 100)), "hebrew");
                }
            }
        }
        public static int NumberoffailedStudentsSubject(Student[] students, string subject)
        {
            int count = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (subject == "math" && students[i].GetMathGrade() < 55)
                {
                    count++;
                }
                else if (subject == "english" && students[i].GetEnglishGrade() < 55)
                {
                    count++;
                }
                else if (subject == "hebrew" && students[i].GetHebrewGrade() < 55)
                {
                    count++;
                }
            }

            return count;
        }
        public void NumberoffailedStudents(Student[] students)
        {
            System.Console.WriteLine("The number of students who failed in Math is : " + NumberoffailedStudentsSubject(students, "math"));
            System.Console.WriteLine("The number of students who failed in English is : " + NumberoffailedStudentsSubject(students, "english"));
            System.Console.WriteLine("The number of students who failed in Hebrew is : " + NumberoffailedStudentsSubject(students, "hebrew"));
        }

        public static void Main()
        {
            Student[] students = new Student[30];
            for (int i = 0; i < students.Length; i++)
            {
                System.Console.WriteLine("Enter name for student " + (i + 1) + ":");
                string name = Console.ReadLine();
                System.Console.WriteLine("Enter ID for student " + (i + 1) + ":");
                string id = Console.ReadLine();
                System.Console.WriteLine("Enter english grade for student " + (i + 1) + ":");
                int englishGrade = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter math grade for student " + (i + 1) + ":");
                int mathGrade = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter hebrew grade for student " + (i + 1) + ":");
                int hebrewGrade = int.Parse(Console.ReadLine());
                students[i] = new Student(name, id, englishGrade, mathGrade, hebrewGrade);
            }
            for (int i = 0; i < students.Length; i++)
            {
                RaiseGrades(students, 8, students[i].GetId());
            }
            System.Console.WriteLine("Number of students who failed in math:" + NumberoffailedStudentsSubject(students, "math"));
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].GetMathGrade() > 85)
                {
                    System.Console.WriteLine("Student with a math grade greater than 85: " + students[i].GetName());
                }
            }







        }

    }

}

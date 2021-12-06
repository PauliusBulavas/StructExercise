using System;

namespace StructExercise
{
    class Program
    {
        public struct Grades
        {
            public int FirstGrade;
            public int SecondGrade;
            public int ThirdGrade;

            public Grades(int firstGrade, int secondGrade, int thirdGrade)
            {
                FirstGrade = firstGrade;
                SecondGrade = secondGrade;
                ThirdGrade = thirdGrade;
            }

            public void GradeAvrage()
            {
                double avrage = (FirstGrade + SecondGrade + ThirdGrade) / 3;
                Console.WriteLine($"The avrage grade of {FirstGrade},{SecondGrade},{ThirdGrade} is {avrage}");
            }

        }
        static void Main(string[] args)
        {
            Grades grades = new Grades(5, 3, 7);

            grades.GradeAvrage();
        }
    }
}

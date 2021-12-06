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

            public void GradeInput()
            {
                Console.WriteLine("input the three grades of the trimester:");
                int firstGrade = Convert.ToInt32(Console.ReadLine());
                int secondGrade = Convert.ToInt32(Console.ReadLine());
                int thirdGrade = Convert.ToInt32(Console.ReadLine());
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("input the three grades of the trimester:");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            int third = Convert.ToInt32(Console.ReadLine());

            Grades grades = new Grades(first, second, third);

            //grades.GradeInput();
            grades.GradeAvrage();
        }

    }
}

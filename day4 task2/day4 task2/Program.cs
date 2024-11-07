using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace day4_task2
{
    
    // بسم الله الرحمن الرحيم
    struct student
    {
        public string name;
        public string yaer_level;
        public int[] grade;
    }

    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of student");
            int numof_student = int.Parse(Console.ReadLine());
            student[] students = new student[numof_student];
            int i = 0;
            for ( i = 0; i < numof_student; i++)
            {
                Console.WriteLine($"\n enter details of student{i + 1}");
                Console.WriteLine("name:\n");
                students[i].name = Convert.ToString(Console.ReadLine());

                Console.WriteLine("enter laval year:");
                Console.WriteLine("like this \n freshman\t sophomore\t jouner\t senior ");
                students[i].yaer_level = Console.ReadLine();
            }
            double avaragegrade = students[i].grade.Average();
            students[i].grade = new int[5];
            for (int w = 0; w <= 5; w++)
            {
                Console.WriteLine($"enter grades of couses{w + 1}");
                students[i].grade[w] = Convert.ToInt32(Console.ReadLine());
            }
            string topstudent = "";
            double higet = 0;
            Console.WriteLine("student grades and avarage");
           
            foreach (var student in students)
            {
                Console.WriteLine(student.name);
                Console.WriteLine(student.yaer_level);
                Console.WriteLine(student.grade);
                if (
                    student.grade.Average() > higet)
                {
                    higet = student.grade.Average();
                    Console.WriteLine(student.name);
                }
                


            }




        }
    }
}

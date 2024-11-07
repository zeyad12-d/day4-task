using System.Transactions;

namespace day4_task_3
{
    struct employee
    {
        public int Id;
       public string Name;
        public double salary;
        public string Department;
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter The Number Of The Employees");
            int Empnumber= Convert.ToInt32(Console.ReadLine());
            employee[] employee = new employee [Empnumber];

            for (int i = 0; i <=Empnumber; i++)
            {
                Console.WriteLine($"Employee Number {i + 1}");

                Console.WriteLine($"Please Enter Employee's ID");

                employee[i].Id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Please Enter Employee's Name");

                employee[i].Name = Console.ReadLine();

                Console.WriteLine($"Please Enter Employee's Salary");

                employee[i].salary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Please Enter Employee's Department");
                employee[i].Department = Console.ReadLine();

            }
            double sum = 0;
            for (int i = 0; i <= Empnumber; i++)
            {
                sum = +employee[i].salary;
            }
            Console.WriteLine(  $"total of sum={sum}");

            double top_salary = 0;
            string highestpaid_department = "";

            for (int i = 0; i <Empnumber; i++)
            {
                if (employee[i].salary > top_salary)
                {
                    top_salary = employee[i].salary;
                    highestpaid_department = employee[i].Department;
                }
            }
            Console.WriteLine($"The Highest Employee salary is {top_salary} as a salary and located in {highestpaid_department} Department");

        }
    }
}

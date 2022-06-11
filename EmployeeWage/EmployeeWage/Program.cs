using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Program program = new Program();
            program.CalculateFullTimeAndPartTimeSalary();
        }

        public void CalculateFullTimeAndPartTimeSalary()
        {
            int WagePerHr = 20;
            Random random = new Random();
            int value = random.Next(0, 3);
            if (value == 0)
            {
                Console.WriteLine("Employee is absent");
            }
            else if (value == 1)
            {
                Console.WriteLine("Employee is working part time");
                int Salary = WagePerHr * 4;
                Console.WriteLine("Salary for part time is " + Salary);
            }
            else
            {
                Console.WriteLine("Employee is working full time");
                int Salary = WagePerHr * 8;
                Console.WriteLine("Salary for full time is " + Salary);
            }
        }
    }
    }


using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int WagePerHr = 20;
            Random random = new Random();
            int value = random.Next(0, 3);
            switch (value)
            {
                case 0:
                    Console.WriteLine("Employee is absent");
                    break;
                case 1:
                    Console.WriteLine("Employee is present part time");
                    int Salary = WagePerHr * 4;
                    Console.WriteLine("salary for part time is " + Salary);
                    break;
                case 2:
                    Console.WriteLine("Employee is present full time");
                    int SalaryFulltime = WagePerHr * 8;
                    Console.WriteLine("Salary for full time is " + SalaryFulltime);
                    break;
                default:
                    Console.WriteLine("exit");
                    break;

            }

        }
    }
    }
        



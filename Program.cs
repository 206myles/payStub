using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payStub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            int rate;
            int hourly;
            int salary;

            Console.WriteLine("Person 1, What is your hourly rate?");
            rate = int.Parse(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week?");
            hourly = int.Parse(Console.ReadLine());
            salary = rate * hourly;
            Console.WriteLine("Your weekly salary is " + salary);
            Console.ReadLine();


            int rate2;
            int hourly2;
            int salary2;

            Console.WriteLine("Person 2, What is your hourly rate?");
            rate2 = int.Parse(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week?");
            hourly2 = int.Parse(Console.ReadLine());
            salary2 = rate2 * hourly2;
            Console.WriteLine("Your weekly salary is " + salary2);
            Console.ReadLine();

            int a;
            int b;
            a = salary;
            b = salary2;

            if (a > b)
            {
                Console.Write("Person 1 makes more money!");
            }
            else
            {
                Console.Write("Person 2 makes more money!");
            }
            Console.Read();
        }
    }           
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2asser2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Employee ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Employee Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Employee Gender (M/F): ");
            char gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter the Employee Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Date of Joining (DOJ) in the format dd/mm/yyyy: ");
            string doj = Console.ReadLine();


            double taxRate = salary > 90000 ? 0.3 : 0.15;
            double taxAmount = salary * taxRate;

            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("|   ID    |   EmployeeName   | Employee Gender |  Employee Salary |   DOJ      |");
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("| {0,-8}  |     {1,-10}      |   {2,-3}        |     {3,-5}        | {4,-10} |", id, name, gender,salary, doj);
            Console.WriteLine("---------------------------------------------------------------------------------------");

            if (salary > 90000)
                Console.WriteLine("You have to pay: 30%");
            else
                Console.WriteLine("You have to pay: 15%");
            Console.ReadKey();
        }
    }
}

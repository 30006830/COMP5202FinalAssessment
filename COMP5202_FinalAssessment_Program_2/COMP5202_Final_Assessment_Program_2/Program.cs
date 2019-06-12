//Name: Blake Jensen (Student ID: 30006830)
//COMP5202 Final Assessment Question 2: Payroll System
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP5202_Final_Assessment_Program_2
{
    public class Program
    {
        public static void Main()
        {
            //makes the console window text white
            Console.ForegroundColor = ConsoleColor.White;

            //welcome message
            Console.WriteLine("==================================================\n" +
                              "================= Welcome to the =================\n" +
                              "============= Rotorua Holiday Park!! =============\n" +
                              "================= Payroll System =================\n" +
                              "==================================================\n");

            //starts asking the user to input their information as each prompt is answered correctly
            Console.Write("Please enter the first name of the employee: ");
            string fullname = Console.ReadLine();

            Console.Write($"Now enter {fullname}'s Gross annual income: ");
            double grosssalary = double.Parse(Console.ReadLine());

            Console.Write($"Now enter {fullname}'s tax rate (in percentage): ");
            double taxrate = double.Parse(Console.ReadLine());

            //this calls the empty constructor to display the message
            Employee p1 = new Employee();

            //new employee object is created named "p2"
            Employee p2 = new Employee(fullname, taxrate, grosssalary);

            //outputs the information entered to the console window in ordered format
            Console.WriteLine($"Name: {fullname} \nGross Annual Income: {grosssalary}\nTax Rate: {taxrate}\nNet Salary: ${Math.Round(p2.CalcNet(), 3)}\n"); 

            //thank you message at end of program
            Console.WriteLine("Thank you for using the Payroll system, Press enter to close this window..");
            Console.ReadLine();
        }
    }

    //class named "employee"
    class Employee
    {
        //below are the three private instance variables
        private string fullName;
        private double grossSalary;
        private double taxRate;

        //getters and setters
        public string FullName { get { return fullName; } set { fullName = value; } }
        public double GrossSalary { get { return grossSalary; } set { grossSalary = value; } }
        public double TaxRate { get { return taxRate; } set { taxRate = value; } }

        //empty employee class to display message
        public Employee() 
        {
            Console.WriteLine("\n| | | | | Employee Record Created | | | | |\n");
        }

        //employee class with 3 public properties
        public Employee(string _fullname, double _taxrate, double _grosssalary)
        {
            fullName = _fullname;
            taxRate = _taxrate;
            grossSalary = _grosssalary;
        }

        //CalcNet method to calculate the sum remaining after tax
        public double CalcNet() 
        {
            return grossSalary * (1 - taxRate / 100);
        }
    }
}

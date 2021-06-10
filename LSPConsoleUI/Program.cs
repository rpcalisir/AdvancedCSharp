using LSPLibrary;
using System;

namespace LSPConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IManager manager = new Manager(); 
            manager.FirstName = "Sue";
            manager.LastName = "Storm";
            manager.CalculatePerHourRate(4);

            IManaged emp = new Manager();//IManaged comes from Manager: Employee (Employee:EmployeeBase,IManaged)
            emp.FirstName = "Tim";
            emp.LastName = "Corey";
            emp.AssignManager(manager);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is {emp.Salary}/hour");
            Console.WriteLine($"{emp.FirstName}'s manager is {emp.Manager.FirstName}");

            Console.ReadLine();
        }
    }
}

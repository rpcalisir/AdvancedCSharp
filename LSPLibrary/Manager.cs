using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPLibrary
{
    public class Manager: Employee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 19.75M;
            Salary = baseAmount + (rank * 4);
        }

        public void FireSomeone()
        {
            Console.WriteLine("You're fired");
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("Reviewing a direct report");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPLibrary
{
    public class CEO: EmployeeBase, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 300M;
            Salary = baseAmount * rank;
        }

        public void FireSomeone()
        {
            Console.WriteLine("You're fired");
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("Reviewing direct report");
        }
    }
}

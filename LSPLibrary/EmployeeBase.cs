using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPLibrary
{
    /// <summary>
    /// Prevents common elements to be implemented seperately by each derived class
    /// </summary>
    public abstract class EmployeeBase : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public decimal Salary { get; set; } 
        public virtual void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;
            Salary = baseAmount + (rank * 2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPLibrary
{
    /// <summary>
    /// Provides a contract for common elements to be used in the base class
    /// </summary>
    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set; }
        void CalculatePerHourRate(int rank);
    }
}

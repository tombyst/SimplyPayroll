using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimplyPayroll
{
    /// <summary> provides a context for user’s input values binding.</summary>
    /// <remarks></remarks>
    public class PayrollModel
    {
        /// <summary>Represents a number of hours worked from user’s input.</summary>
        public double hoursWorked;
        /// <summary>Represents hourly rate from user’s input.</summary>
        public double hourlyRate;
    }
}

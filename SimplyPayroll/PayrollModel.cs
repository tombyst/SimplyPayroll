using System;
using System.ComponentModel.DataAnnotations;

namespace SimplyPayroll
{

    /// <summary> Provides a context for user’s input values binding.</summary>
    public class PayrollModel
    {
        /// <summary>Represents a number of hours worked from user’s input.</summary>
        [Required]
        [Range(3, 48, ErrorMessage = "Hours worked must be between 3 and 48.")]
        [Display(Name = "Hours Worked")]
        public double HoursWorked { get; set; }

        /// <summary>Represents hourly rate from user’s input.</summary>
        [Required]
        [Range(10.10, 100, ErrorMessage = "Hourly rate must be between 10 and 100.")]
        [Display(Name = "Hourly rate")]        
        public double HourlyRate { get; set; }

    }
}

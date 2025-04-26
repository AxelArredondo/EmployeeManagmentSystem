using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagmentSystem.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateHired { get; set; }

        [Range(0, 1000)]
        public double HourlyWage { get; set; }

        public double CalculateSalary(double hoursWorked)
        {
            return hoursWorked * HourlyWage;
        }
    }
}

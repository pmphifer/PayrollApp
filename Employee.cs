using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace PayrollApp
{
    class Employee
    {
        //properties
        public double HourlyRate { get; set; }
        public double HoursWorked { get; set; }
        public string Name { get; set; }
        public double BasePay { get; set; }
        public double Total { get; set; }

        //constructor
        public Employee (double hourlyRate, double hoursWorked, string name, double basePay, double total)
        {
            HourlyRate = 20.75;
            HoursWorked = hoursWorked;
            Name = name;
            BasePay = basePay;
            Total = total;
        }
        //methods (calculate pay based on hours worked and hourly rate)
       
      
    }
}

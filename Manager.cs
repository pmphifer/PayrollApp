using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollApp
{
    class Manager
    {
        //properties
        public double HourlyRate { get; set; }
        public double HoursWorked { get; set; }
        public string Name { get; set; }
        public double BasePay { get; set; }
        public double Total { get; set; }
        public int Allowances { get; set; }

        //constructor
        public Manager(double hourlyRate, double hoursWorked, string name, double basePay, double total, int allowance)
        {
            HourlyRate = 50.00;
            HoursWorked = hoursWorked;
            Name = name;
            BasePay = basePay;
            Total = total;
            allowance = 100;
        }
        //methods (calculate pay based on hours worked and hourly rate; base pay is pay before any additions, total pay includes additions, method should return total for overtime pay)

    }
}

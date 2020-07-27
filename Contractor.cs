using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollApp
{
    class Contractor
    {
        //properties
        public int HourlyRate { get; set; }
        public double HoursWorked { get; set; }
        public string Name { get; set; }
        public double BasePay { get; set; }
        public double OvertimeRate { get; set; }
        public double OvertimeHours { get; set; }

        //constructor
        public Contractor (int hourlyRate, double hoursWorked, string name, double basePay, double overtimeRate, double overtimeHours)
        {
            HourlyRate = 30;
            HoursWorked = hoursWorked;
            Name = name;
            BasePay = basePay;
            OvertimeRate = overtimeRate;
            OvertimeHours = overtimeHours;

           
        }
        //methods (calculate pay based on hours worked and hourly rate; total pay includes additions, method should return total, 
        //private method to calculate overtime rate -hours over 40 are time and a half, method should return total)

    }
}

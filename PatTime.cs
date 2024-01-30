using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class PartTime : Employee
    {
        private double Rate { get; set; }
        private double Hours { get; set; }

        private double WeeklyPay { get; set; }

        public PartTime()
        {
            
        }

        public PartTime(string id, string name, string address, string phone, long sin, string dob, string dep, double rate, double hours) : base(id, name, address, phone, sin, dob, dep)
        {
            this.Rate = rate;
            this.Hours = hours;
        }

        

        public override double GetPay()
        {
            return (Rate * Hours);
        }

        public override string ToString()
        {
            return $"PARTIME Id: {Id}, Name: {Name}, Address: {Address}, PhoneNumber: {Phone}, SIN: {Sin}, BirthDate: {Dob}, Department: {Dep}, Rate: {Rate}, Hours: {Hours}";
        }
    }
}

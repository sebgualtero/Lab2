using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Wages : Employee
    {
        private double Rate { get; set; }
        private double Hours { get; set; }

        public Wages()
        {
            
        }

        public Wages(string id, string name, string address, string phone, long sin, string dob, string dep, double rate, double hours) : base(id, name, address, phone, sin, dob, dep)
        {
            this.Rate = rate;
            this.Hours = hours;
        }

        public override double GetPay()
        {
            if (Hours > 40)
            {
                return ((Rate * 40) + (Rate * 1.5 * (Hours - 40)));
            }
            else
            {
                return (Rate * Hours);
            }
            
        }

        public override string ToString()
        {
            return $"WAGED Id: {Id}, Name: {Name}, Address: {Address}, PhoneNumber: {Phone}, SIN: {Sin}, BirthDate: {Dob}, Department: {Dep}, Rate: {Rate}, Hours: {Hours}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2
{
    internal class Salaried: Employee
    {
        private double Salary { get; set; }
        
        public Salaried()
        {
            
        }

        public Salaried(string id, string name, string address, string phone, long sin, string dob, string dep, double salary) : base(id, name, address, phone, sin, dob, dep)
        {
            this.Salary = salary;
        }

        public override double GetPay()
        {
            return Salary/4;
        }

        public override string ToString()
        {
            return $"SALARIED Id: {Id}, Name: {Name}, Address: {Address}, PhoneNumber: {Phone}, SIN: {Sin}, BirthDate: {Dob}, Department: {Dep}, Salary: {Salary}";
        }
    }
}

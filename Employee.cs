using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Employee
    {
        protected string Id { get; set; }
        protected string Name { get; set; }
        protected string Address { get; set; }
        protected string Phone { get; set; }
        protected long Sin { get; set; }
        protected string Dob { get; set; }
        protected string Dep { get; set; }

        public Employee()
        {

        }

        public Employee(string id, string name, string address, string phone, long sin, string dob, string dep)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            this.Sin = sin;
            this.Dob = dob;
            this.Dep = dep;
        }

        
        public string GetName()
        {
            return Name;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Address: {Address}, PhoneNumber: {Phone}, SIN: {Sin}, BirthDate: {Dob}, Department: {Dep}";
        }

        public virtual double GetPay()
        {
            return 0;
        }
    }

    }

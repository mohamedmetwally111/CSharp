using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp10
{
    #region  Employee Class ToSorting By Salary
    internal class Employee : IComparable<Employee>,ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int _id, string _name, double _salary)
        {
            Id = _id;
            Name = _name;
            Salary = _salary;
        }
        public Employee()
        {
            
        }

        public override string ToString()
        {
            return $"Name is: {Name}, Salary is: {Salary}, ID is: {Id}";
        }

        //compare Employee objects based on their salary 
        public int CompareTo(Employee other)
        {
            if (this.Salary > other.Salary)
                return 1;
            else if (this.Salary < other.Salary)
                return -1;
            else
                return 0;
        }

        public object Clone()
        {
            return new Employee
            {
                Id = this.Id,
                Name = this.Name,
                Salary = this.Salary
            };
        }
    }
    #endregion
}

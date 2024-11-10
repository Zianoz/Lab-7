using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGenerics
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        public Employee(int id, string name, string gender, int salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

        // This implicitly calls employee.ToString()
        public override string ToString() 
        {
            return $"Id: {Id}, Name: {Name}, Gender: {Gender}, Salary: {Salary}";
        }

    }
}

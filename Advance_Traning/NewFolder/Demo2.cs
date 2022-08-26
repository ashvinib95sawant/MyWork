﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Advance_Traning.NewFolder
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return $"{Id}->{Name}->{Salary}->{City}";
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>()
            {
              new Employee { Id = 1, Name = "Ashvini", Salary = 30799, City = "Pune" },
              new Employee { Id = 2, Name = "Manisha", Salary = 43699, City = "Mumbai" },
              new Employee { Id = 3, Name = "Reshma", Salary = 34799, City = "Nashik" },
              new Employee { Id = 4, Name = "Poonam", Salary = 45799, City = "Nagpur" },
              new Employee { Id = 5, Name = "Swanand", Salary = 238799, City = "Chennai" },
              new Employee { Id = 6, Name = "Aparna", Salary = 53299, City = "Delhi" },
              new Employee { Id = 7, Name = "Amit", Salary = 23999, City = "Kolhapur" },
              new Employee { Id = 8, Name = "Rohit", Salary = 42799, City = "Solapur" },
              new Employee { Id = 9, Name = "Sushil", Salary = 51799, City = "Satara" },
              new Employee { Id = 10, Name = "Harsha", Salary = 19299, City = "Sangali" },
            };

            var result1 = from e in emp
                          select e;

            var result2 = from e in emp
                          orderby e.Name
                          select e;

            var result3 = from e in emp
                          where e.Salary > 25000
                          select e;

            var result4 = from e in emp
                          where e.City.Contains("Pune")
                          select e;

            var result5 = from e in emp
                          orderby e.Salary descending
                          select e;

            var result6 = from e in emp
                          where e.Name.StartsWith("P")
                          select e;

            var result7 = from e in emp
                          where e.Salary > 25000 && e.City.Contains("Mumbai")
                          select e;

            foreach (Employee data in result3)
            {
                Console.WriteLine(data);
            }
        }
    }
}

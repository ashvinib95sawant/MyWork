using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Advance_Traning
{
    public class Employee1
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

    class Program11
    {
        static void Main(string[] args)
        {
            List<Employee1> emp1 = new List<Employee1>()
            {
              new Employee1 { Id = 1, Name = "Ashvini", Salary = 30799, City = "Pune" },
              new Employee1 { Id = 2, Name = "Manisha", Salary = 43699, City = "Mumbai" },
              new Employee1 { Id = 3, Name = "Reshma", Salary = 34799, City = "Nashik" },
              new Employee1 { Id = 4, Name = "Poonam", Salary = 45799, City = "Nagpur" },
              new Employee1 { Id = 5, Name = "Swanand", Salary = 238799, City = "Chennai" },
              new Employee1 { Id = 6, Name = "Aparna", Salary = 53299, City = "Delhi" },
              new Employee1 { Id = 7, Name = "Amit", Salary = 23999, City = "Kolhapur" },
              new Employee1 { Id = 8, Name = "Rohit", Salary = 42799, City = "Solapur" },
              new Employee1 { Id = 9, Name = "Sushil", Salary = 51799, City = "Satara" },
              new Employee1 { Id = 10, Name = "Harsha", Salary = 19299, City = "Sangali" },
            };

            //Lamda expresions

            //1. display all employees
            var res1 = emp1.ToList();

            //2. display employee with ascending order by name
             var res2 = emp1.OrderBy(e => e.Name).ToList();

             //3.display employee whose salary is > 25000
             var res3 = emp1.Where(e => e.Salary > 25000).ToList();

             //4. display employee whos from 'Pune' City
             var res4 = emp1.Where(e=>e.City.Contains("Pune")).ToList();


             //5. display employee with descending order by salary
             var res5 = emp1.OrderByDescending(e => e.Salary).ToList();

            // 6.display employee whose name start with 'P'
            var res6 = emp1.Where(e => e.Name.StartsWith("P")).ToList();

            //7.display employee whose salary is > 25000 & emp is from 'Mumbai' city
            var res7 = emp1.Where (e=>e.Salary > 25000 && e.City.Contains("Mumbai")).ToList();

            foreach (Employee1 data in res7)
            {
                Console.WriteLine(data);
            }



        }
    }
}


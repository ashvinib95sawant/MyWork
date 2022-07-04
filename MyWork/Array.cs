using System;
using System.Collections.Generic;
using System.Text;

namespace MyWork
{
    class Array0
    {
        static void Main(string[] args)
        {
            string[] Employee = { "Ashu", "jay", "Vijay", "Shree", "Ganesh", "Ram", "Seeta", "Neetu", "Rohit", "Kavya", "Shital", "Harish", "Pavan", "Raj", "sayali" };
           // string[] Employee = new string[15];
           // Console.WriteLine(arrEmp);
            
           for(int i=0;i< Employee.Length - 10; i++)
           {
               
                Console.WriteLine("data1 "+Employee[i]);

           }
            for (int i = 5; i < Employee.Length-5; i++)
            {

                Console.WriteLine("data2 " + Employee[i]);
            }
            for (int i = 10; i < Employee.Length; i++)
            {

                Console.WriteLine("data3 " + Employee[i]);

            }
        }
    }

    class Array1
    {
        static void Main(string[] args)
        {
            string[] Employee = { "Ashu", "jay", "Vijay", "Shree", "Ganesh", "Ram", "Seeta", "Neetu", "Rohit", "Kavya", "Shital", "Harish", "Pavan", "Raj", "sayali" };
            // string[] Employee = new string[15];
            // Console.WriteLine(arrEmp);
            for (int i = 5; i < Employee.Length-5; i++)
            {

                Console.WriteLine("data1 " + Employee[i]);

            }
            for (int i = 0; i < Employee.Length - 10; i++)
            {

                Console.WriteLine("data2 " + Employee[i]);
            }
            for (int i = 10; i < Employee.Length; i++)
            {

                Console.WriteLine("data3 " + Employee[i]);

            }
        }
    }

    class Array2
    {
        static void Main(string[] args)
        {

            string[] users = { "suman", "Amar", "Sandip", "roshan" };
            Console.WriteLine("List Display");
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine(users[i]);
            }
            Array.Sort(users);
            Console.WriteLine("Orderd List");
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine(users[i]);
            }
            Array.Reverse(users);
            Console.WriteLine("Desc Orderd List");
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine(users[i]);
            }


        }

    }

    class Array3
    {
        static void Main(string[] args)
        {
            string[] abc = { "Rahul", "Mohit", "Naman", "Aditi", "Roshani", "Abhay" };
            int count = 0;

            for (int i = 0; i < abc.Length; i++)
            {
                for (int j = 0; j < abc[i].Length; j++)
                {
                    count++;
                }
                Console.WriteLine(abc[i]+":"+ count);
            }
        }
    }

    class Array4
    {
        static void Main(string[] args)
        {
            int[] numbers = { 100, 105, 103, 104, 105, 106, 107, 108 };
            Array.Sort(numbers);


            for (int i = 0; i < numbers.Length; i++) 
            {

                if (((i > 0) && (numbers[i] == numbers[i - 1]))
                    || ((i < numbers.Length - 1) && (numbers[i] == numbers[i + 1])))
                {

                }
                else 
                {
                    Console.WriteLine(numbers[i]);
                }
                
            }
            
        }
    }
}

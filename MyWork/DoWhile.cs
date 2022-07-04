using System;
using System.Collections.Generic;
using System.Text;

namespace MyWork
{
    class DoWhile
    {
        static void Main(string[] args)
        {
            for (int i=11;i<=10;i++)
                Console.WriteLine(i);

            int j = 11;
            while(j<=10)
            {
                Console.WriteLine(j);
                j++;
            }

            int k = 11;
            do
            {
                Console.WriteLine(k);
                k++;

            } while (k <= 10);

            //for, while -> entry control loop
            //do while -> exit control loop
        }
    }


    class doWhile2
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                Console.WriteLine("Enter 2 number ");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int sum = a + b;
                Console.WriteLine("sum" + sum);
                Console.WriteLine("Do you want to perform addition once again yes/no");
                choice = Console.ReadLine().ToLower();

            } while (choice == "yes");

            for(int i=1;i<=10;i++)
            {
                if(i==6)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
    


}

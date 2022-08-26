using System;
using System.Collections.Generic;
using System.Text;

namespace MyWork
{
    class Practice2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);
            bool isZero = false;
            while(n!=0)
            {
                int last = n % 10;
                if(last==0)
                {
                    isZero = true;
                }
                n = n / 10;
            }
            if(isZero==true)
            {
                Console.WriteLine("Duck");
            }
            else
            {
                Console.WriteLine("Not Duck");
            }
        }
    }

    class Weired
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isEven = false;

            if(n%2!=0)
            {
                isEven = false;
            }
            else
            {
                isEven = true;
            }

            if(isEven==true)
            {
                if(n>=2&&n<=5)
                    Console.WriteLine("Not Weird");

                else if((n >= 6) && (n <= 20))
                    Console.WriteLine("Weird");

                else
                    Console.WriteLine("Not Weird");

            }
            else
            {
                Console.WriteLine("Weird");
            }

        }
    }
}

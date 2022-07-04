using System;

namespace MyWork
{
    //To Print No between 300 to 200 odd number
    class forLoop
    {
        static void Main(string[] args)
        {
            for(int i=299; i>=200; i=i-2)
            {
                Console.WriteLine(i);
            }
           
        }
    }

    //To Print 4 8 12 16 20 24 28 32 36 40
    class Multi4
    {
        static void Main(string[] args)
        {
            for (int i = 4; i <= 40; i = i+4)
            {
                Console.WriteLine(i);
            }

        }
    }

    //Print 1 4 9 16 25 36 49 64 81 100
    class Square
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i*i);
            }

        }
    }

    //Print table of number between 1 to 10
    class Table
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n+"x"+i+"="+n*i);
            }

        }
    }

    //Print Table of any number between 1 to 10
    class mult
    {

        static void Main(string[] args)
        {
          int m = 1;
            for (int i = 1; i <= 10; i++)
            {
                m = m * i;
            }
            Console.WriteLine(m);

        }
    }

    //Print factorial of any number between 1 to n
    class fact
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact =fact * i;
            }
            Console.WriteLine(fact);

        }
    }
    //Find factors of any number.
    class factor
    {

        static void Main(string[] args)
        {
            int n = 12;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.WriteLine(i);
            }


        }
    }
    //Find given number is prime or not
    class Prime
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int c = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                    c++;
                }
            }
            if(c==2)
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not Prime");

        }
    }

    //Find gcd of two numbers.
    class gcd
    {
        static void Main(string[] args)
        {
            int a = 12, b = 18;
            int gcd = 0;
            for (int i = 1; i <= a; i++)
            {
                if ((a % i == 0) && (b % i == 0))
                {
                    gcd = i;
                }

            }
            Console.WriteLine("gcd" + gcd);
            int lcm = a * b / gcd;
            Console.WriteLine("lcm" + lcm);


        }
    }
}

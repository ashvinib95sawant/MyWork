using System;
using System.Collections.Generic;
using System.Text;

namespace MyWork
{
    //find sum of digits of given number.
    class sumOfNum
    {
        static void Main(string[] args)
        {
           int n = 534;
            int sum = 0;
            while(n>0)
            {
                int last = n % 10;
                sum = sum + last;
                n = n/ 10;
            }
            Console.WriteLine(sum);
        
        }
    }
    // Find in given number how many odd and how many even digits.
    class EvenOdd
    {
        static void Main(string[] args)
        {
            int sum=0,Even=0,Odd = 0;
            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                int last = n % 10;
                if (last % 2 == 0)
                {
                    Even = Even + 1;
                }
                else
                {
                    Odd = Odd + 1;
                }
                sum = sum + last;
                n = n / 10;
            }
            Console.WriteLine("Odd="+Odd+"Even="+Even);
        }
    }
    //Find given number is Neon or not.
    class Neon
    {
        static void Main(string[] args)
        {
            int  square, last, sum = 0;
            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());
            square = n * n;
            while (square > 0)
            {
                last = square % 10;
                sum = sum + last;
                square = square / 10;
               
            }
            if (sum == n)
            {
                Console.WriteLine("Neon Number");
            }
            else
            {
                Console.WriteLine("Not Neon Number");
            }

        }
    }

    //Find given number is Palindrome or not.

    class palindrome
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());
            int temp = n;
            int reverse = 0; ;
            while (n > 0)
            {
               int last = n % 10;
                reverse = reverse*10 + last;
                n= n/ 10;

            }
            if (reverse == temp)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }

        }
    }

    //Find given number is Spy or not.

    class Spy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0, mul = 1;
            while(n>0)
            {
                int last = n % 10;
                sum = sum + last;
                mul = mul * last;
                n = n / 10;
            }
            if(sum==mul)
                Console.WriteLine("Spy number");
            else
                Console.WriteLine("Not Spy Number");
        }
    }

    //Find given number is Krisnamurthy or not.

    class Krishnamurthy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int temp = n, sum = 0, fact=1;

            while(n>0)
            {
                int last = n % 10;

                for(int i=1; i<=last; i++)
                {
                   
                    fact = fact * i;
                 
                }
               
                sum = sum + fact;
                n = n / 10;
                fact = 1;
                
            }
        
            if (temp == sum)
            {
                Console.WriteLine("Krishnamurthy Number");
            }
            else
            {
                Console.WriteLine("Not Krishnamurthy");
            }
        }
    }

    //Find given number is armstrong number or not.

    class armstrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int n = int.Parse(Console.ReadLine());
            int c = 0;
            int copy = n;
            while(n>0)
            {
                c++;
                n = n / 10;
            }
            n = copy;
            int sum = 0;
            while(n>0)
            {
                int l = n % 10;
                int p = ((int)Math.Pow(l, c));
                sum = sum + p;
                n = n / 10;

            }

            if(sum==copy)
                Console.WriteLine("Armstrong Number");
            else
                Console.WriteLine("Not Armstrong Number");
        }
    }
}

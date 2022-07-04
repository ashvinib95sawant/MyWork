using System;
using System.Collections.Generic;
using System.Text;

namespace MyWork
{

    //1.Write a program to print even numbers from 121 to 229 using for loop.
    class EVEN
    {
        static void Main(string[] args)
        {
            for (int i = 122; i <= 299; i = i + 2)
            {
                Console.WriteLine(i);
            }


        }
    }

    //2.Write a program to print odd numbers from 521 to 229 using while loop.

    class ODD
    {
        static void Main(string[] args)
        {
            int n = 521;
            while (n >= 229)
            {
                if (n % 2 != 0)
                    Console.WriteLine(n);
                n--;
            }
        }
    }

    //3.write a program to show the use of break statement.
    class BREAK
    {
        static void Main(string[] args)
        {

            int n = 1;
            while (n <= 10)
            {
                Console.WriteLine(n);
                n++;
                if (n == 7)
                {
                    Console.WriteLine("_");
                    break;
                }
            }

        }
    }

    //4.Write a program to find GCD and LCM of given number.

    class GCDLCM
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int n2 = int.Parse(Console.ReadLine());
            int gcd = 0;
            for (int i = 1; i <= n1; i++)
            {
                if ((n1 % i == 0) && (n2 % i == 0))
                {
                    gcd = i;
                }

            }
            Console.WriteLine("gcd" + gcd);
            int lcm = n1 * n2 / gcd;
            Console.WriteLine("lcm" + lcm);


        }
    }

    //5.Write a program to print all alphabets from a to z using for loop.

    class ALPHABET
    {
        static void Main(string[] args)
        {
            char ch;
            for (ch = 'a'; ch <= 'z'; ch++)
                Console.WriteLine(ch);
        }
    }

    //6.Write a program to find sum of all even numbers between 1 to n.

    class EVENSUM
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter value of n");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 2; i <= n; i = i + 2)
            {
                sum = sum + i;
            }

            Console.WriteLine("sum of even numbers between 1 to " + n + "=" + sum);
        }
    }

    //7.Write a program to find sum of all odd numbers between 1 to n.

    class ODDSUM
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter value of n");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i = i + 2)
            {
                sum = sum + i;
            }

            Console.WriteLine("sum of odd numbers between 1 to " + n + "=" + sum);
        }
    }

    //8.Write a program to count number of digits in any number.

    class DIGITS
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int temp = n;

            while (n != 0)
            {
                n = n / 10;
                count++;
            }
            Console.WriteLine("number of digits= " + count);
        }
    }

    //9.Write a program to calculate product of digits of any number.

    class PRODUCT
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int mul = 1;
            int temp = n;

            while (n != 0)
            {
                int last = n % 10;
                mul = mul * last;
                n = n / 10;

            }
            Console.WriteLine("Product of digits= " + mul);
        }
    }

    //10.Write a program to find frequency of each digit in a given integer.

    class FREQUENCY
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int n = int.Parse(Console.ReadLine());
            int copy = n;
            int count = 0;

            for (int i = 0; i <=9; i++)
            {
                while (n != 0 )
                {
                    int last = n % 10;
                    if (last == i)
                    {
                        count++;
                        
                    }

                    n = n / 10;
                }
                n = copy;
                if(count!=0)
                 Console.WriteLine("count of " + i + " is" + count);
                count = 0;
            }
        }
    }

    //11.Find all prime number between 400 to 300.

    class PRIME
    {
        static void Main(string[] args)
        {
            int count = 0;
            int sum = 0;

            for (int i = 400; i >= 300; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                       
                    }

                }

                if (count == 2)
                {
                    Console.WriteLine(i);
                    sum++;
                }
                count = 0;
            }
            Console.WriteLine("Total number of prime numbers between 400 to 300 = "+sum);
        }
    }

    //12.Write a program to print table of given number.

    class TABLE
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(n*i);
            }
        }
    }

    //13.Write a program to print squares from 1 to 20.

    class SQUARES
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=20;i++)
            {
                int square = i * i;
                Console.WriteLine(square);
            }
        }
    }

    //14.Write a program to accept base and index from user and calculate power.

    class POWER
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter power");
            int p = int.Parse(Console.ReadLine());
            int result = (int)Math.Pow(b, p);
            Console.WriteLine(b +" Power "+ p +" is "+result);
        }
    }

    //15. 1!+2!+3!+4!+...+n! Find s.

    class FACTORIAL
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter value of n");
            int n = int.Parse(Console.ReadLine());
            int fact = 1,sum=0;
            for(int i=1;i<=n;i++)
            {
                fact = fact * i;
                sum = sum + fact;

            }
            Console.WriteLine("sum of 1! to " + n+"! = " +sum);
        }
    }

    //1!+3!+5!+...+n!
    class FACT
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter value of n");
            int n = int.Parse(Console.ReadLine());
            int odd = 1, sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int fact = 1;
                for (int j = 1; j <=odd; j++)
                {
                    fact = fact * j;
                }
                    
                sum = sum + fact;
                odd = odd + 2;

            }
            Console.WriteLine("sum of 1! to " + n + "! = " + sum);
            
        }
    }

    //16. Write a program to  check given number is Krishnamurthy or not.eg.145=1!+4!+5!

    class KRISHNAMURTHY
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int temp = n, sum = 0, fact = 1;

            while (n > 0)
            {
                int last = n % 10;

                for (int i = 1; i <= last; i++)
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

    //17. Write a program to  check given number is palindrome or not. eg.1221

    class PALINDROME
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());
            int temp = n;
            int reverse = 0; 
            while (n > 0)
            {
                int last = n % 10;
                reverse = reverse * 10 + last;
                n = n / 10;

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

    //18. Write a program to  check given number is automorphic or not.
    //eg. input n=25 output Automorphic
    //As 25*25=625

    class AUTOMORPHIC
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());
            int square = (n * n);
            bool condition =true;
            //n=25 square =625
            //n=12 sq=144
            while (n > 0)
            {
                if (n % 10 != square % 10)
                {
              
                   condition = false;
                    break;

                }
                n = n / 10;//n=2
                square = square / 10;//62
            }
            if (condition == true)
                Console.WriteLine("AUTOMORPHIC");
            else
                Console.WriteLine("not AUTOMORPHIC");
        }
    }

   //19. Write a program to  check given number is Harshad/Niven number or not.
    //An Harshad number is an integer number divisible by sum of its digits.
    //eg.18 sum=9 and 18 is divisible by 9.

    class HARHAD
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0,temp=n;
            while(n>0)
            {
                int last = n % 10;
                sum = sum + last;
                n = n / 10;
            }
            
            if(temp%sum==0)
                Console.WriteLine("Harshad Number");
            else
                Console.WriteLine("Not Harshad Number");
        }
    }


    //20.Print all palindrome numbers from 100 to 500.

    class PALINDROME_RANGE
    {
        static void Main(string[] args)
        {
            int reverse = 0;
            for (int i = 100; i <= 500; i++)
            {
                int temp = i;


                while (temp > 0)
                {
                    int last = temp % 10;
                    reverse = reverse * 10 + last;
                    temp = temp / 10;
                    
                }
                 
                if (reverse == i)
                {
                    Console.WriteLine(i);
                }
                reverse = 0;
            }
        }
    }

    //fibonacci series
    class fibo
    {
        static void Main()
        {

            int n = 1;
            int sum = 0;
            for (int i = 1; i < 10; i++)
            {
                int result = sum + n;
                Console.Write(n + " ");
                sum = n;
                n = result;

            }

        }
    }
}

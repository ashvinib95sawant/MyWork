using System;
using System.Collections.Generic;
using System.Text;

namespace MyWork
{
    //Singlecast deligates
    class DemoDelegates
    {
        //declare a delegate
        public delegate void mydelegate(int x);
        public void square(int a)
        {
            Console.WriteLine("Square:"+a*a);
        }

        static void Main(string[] args)
        {
            //set a target
            DemoDelegates ob = new DemoDelegates();
            mydelegate d1 = ob.square;
            d1(7);
        }
    }

    class Demo2
    {
        public delegate int mydelegate1(int x);
        public static int Factorial(int a)
        {
            int f = 1;
            for(int i=1;i<=a;i++)
            {
                f = f * i;
            }
            return f;
        }
        static void Main(string[] args)
        {
            mydelegate1 d2 = Factorial;
            Console.WriteLine(d2(5));
        }
    }

    //Multicast deligates: HOLDING REFERENCE OF MORE THAN ONE FUNCTION
    class DemoDelegates3
    {
        //declare a delegate
        public delegate void mydelegate(int x);
        public void square(int a)
        {
            Console.WriteLine("Square: " + a * a);
        }
        public void cube(int x)
        {
            Console.WriteLine("Cube: " + (x * x * x));
        }

        public static void doubleup(int x)
        {
            Console.WriteLine("Doubleup: "+(2*x));
        }
        static void Main(string[] args)
        {
            //set a target
            //multicast deligate
            DemoDelegates3 ob = new DemoDelegates3();
            mydelegate d1 = ob.square;
            d1 = d1 + ob.cube;
            d1 = d1 + DemoDelegates3.doubleup;
            d1(7);
        }
    }

    //Lamda Expression

    public delegate void mydel3(int x,int y);

    class Demodg
    {
        static void Main(string[] args)
        {
            mydel3 d1 = delegate (int x, int y)
              {
                  Console.WriteLine("sum= " + (x + y));
              };
            d1(10, 20);

            //lamda expression

            mydel3 d2 = (x, y) =>
              {
                  Console.WriteLine("Addition: " + (x + y));
              };
            d2(11, 12);
        }
    }

    //Check no is prime or not using lamda expression
    public delegate bool mydel4(int x);
    class DPrime
    {
        //only logic
        static bool isPrime(int n)
        {
            bool isPrime = true;
            for(int i=2;i<=n/2;i++)
            {
                if(n%i==0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }

        //Lamda expression
        static void Main(string[] args)
        {
            mydel4 d4 = (n) =>
              {
                  bool isPrime = true;
                  for (int i = 2; i <= n / 2; i++)
                  {
                      if (n % i == 0)
                      {
                          isPrime = false;
                          break;
                      }
                  }
                  return isPrime;
              };
            bool ans = d4(97);
            Console.WriteLine(ans);
        }
    }


    //Func, Action and Predicate
    class demodg1
    {
        static string greet()
        {
            return "Good Morning";
        }

        static int product(int a, int b, int c)
        {
            return a * b * c;
        }

        static bool iseven(int x)
        {
            if (x % 2 == 0)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            Func<string> d1 = greet;
            Func<int, int, int, int> d2 = (a, b, c) => a * b * c;
            int prod = d2(2, 3, 4);
            Console.WriteLine("Multiplication: "+prod);

            Action<int, int> d3 = (a, b) => Console.WriteLine("Adition: "+(a+b));
            d3(89, 9);

            Func<int, bool> d4 = iseven;
            bool b = d4(89);
            Console.WriteLine(b);

            Predicate<int> d5 = iseven;
            bool bb = d5(78);
            Console.WriteLine(bb);
        }

    }

    //Callback

    class MyCallBack
    {
        public static void display()
        {
            Console.WriteLine("Good Morning");
        }

        public static void square(int a, Action d1)
        {
            Console.WriteLine("Square: "+a*a);
            d1();
        }

        static void Main(string[] args)
        {
            square(10, () => Console.WriteLine("Happy Morning"));
            square(9, display);
        }
    }
   
    //

    class overload
    {
        public delegate void mydel111(int x);
        public static void m1(int a)
        {
            Console.WriteLine("In m1 " + a);
        }
        public static void cube(int x)
        {
            Console.WriteLine("Cube: " + (x * x * x));
        }

        static void Main(string[] args)
        {
            //singlecast
            mydel111 d1 = cube;

            //multicast-holding reference of more than one function
            mydel111 d2 = cube;
            d2 = d2 + m1;
            d2(9);

          
        }
        public static void m1(int a, int b)
        {
            Console.WriteLine("in m1 " + a + " " + b);
        }
    }
}

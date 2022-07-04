using System;
using System.Collections.Generic;
using System.Text;

namespace MyWork
{
    //1.Write a program to check given number is spy number or not.
    //eg. 123 sum= 1+2+3=6 mul= 1*2*3= 6 then spy number.

    class SpyNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0, mul = 1;
            while (n > 0)
            {
                int last = n % 10;
                sum = sum + last;
                mul = mul * last;
                n = n / 10;
            }
            if (sum == mul)
                Console.WriteLine("Spy number");
            else
                Console.WriteLine("Not Spy Number");
        }
    }

    //2.Write a program to find all factors of given number.

    class factors1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int a = int.Parse(Console.ReadLine());
            for(int i=1;i<=a;i++)
            {
                if(a%i==0)
                    Console.WriteLine(i);
            }

        }
    }

    //3.Write a program to print number from 1 to 50. if number is even print as it is and if number is odd print its square.

    class EvenOddsq
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=50;i++)
            {
                if(i%2==0)
                    Console.WriteLine(i);
                else
                    Console.WriteLine(i*i);
            }
        }
    }

    //4. write a program to check given number is harshad number or not.
    //eg. 156 sum=1+5+6=12 156/12=13 so harshad. 

    class  HarshadNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0, temp = n;
            while(n!=0)
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

    //5.Write a program to print number from 1 to 100 such that when a number is factor of 3 and 5 both print "RedBlue"
    //and if given number is factor of 3 only print "Red" and given number is factor of 5 only then print "Blue".
    //Otherwise the number itself.

    class RedBlue
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=100;i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("Redblue");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Red");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Blue");
                }
                else
                    Console.WriteLine(i);
                    
            }
        }
    }

    //6.Write a program to check  two numbers are Amicable numbers or not.
    //eg. 220 and 284
    //  220 is divisible by = 1,2,4,5,10,11,20,22,44,55,110. sum =284
    // 284 is divisible by = 1,2,4,71,142. sum =220


    class Amicable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int n2 = int.Parse(Console.ReadLine());
            int sum1 = 0, sum2 = 0;

            for(int i= 1;i<=n1/2;i++)
            {
                if (n1 % i == 0)
                {
                    sum1 = sum1 + i;
                }
            }

            for(int j=1;j<=n2/2;j++)
            {
                if(n2%j==0)
                {
                    sum2 = sum2 + j;
                }
            }

            if((n1==sum2)&&(n2==sum1))
                Console.WriteLine("Amicable");
            else
                Console.WriteLine("Not Amicable");
        }
    }

    //7.Write a program to check given number is trimorphic number or not.
    //eg. 4*4*4=64, 501*501*501=125751501
    //cube of number has the number as a last digits.

    class Trimorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int cube = n * n * n;
            bool condition = true;
            
            while (n > 0)
            {
                if (n % 10 != cube % 10)
                {
                    condition = false;
                    break;
                }
                n = n / 10;
                cube = cube / 10;
            }

            if(condition == true)
                Console.WriteLine("Trimorphic");
            else
                Console.WriteLine("NOt Trimorphic");

        }
    }

    /*8.
            1
           222
          33333
         4444444
    */

    class p1
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 4; r++)
            {
                for (int space = 3; space >= r; space--)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(r);
                }
               
                for (int j = 2; j <=r ; j++)
                {
                    Console.Write(r);
                }
                Console.WriteLine();
            }
                
            
        }
    }

    /* 9.
     *****
     ****
     ***
     **
     *
     */

    class p2
    {
        static void Main(string[] args)
        {
            for(int r=1;r<=5;r++)
            {
                for(int c=5;c>=r;c--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    /* 10. Write a program to find twin prime number.
      (Accept two number from user and check if both are prime
        and their difference is 2 then they are twin prime)
    */

    class TwinPrime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two numbers");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int count = 0, count1=0;
            for(int i=1;i<=n1;i++)
            {
                
                if(n1%i==0)
                {
                    count++;  
                }
            }
            for (int j = 1; j <= n2; j++)
            {
                
                if (n2 % j == 0)
                {
                    count1++;
                }
            }
            if(count==2 && count1==2)
            { 
                if(n1-n2==2||n2-n1==2)
                    Console.WriteLine("Twin Prime");
                else
                    Console.WriteLine("Not Twin Prime");

            }
            else
                Console.WriteLine("Not Twin Prime");


        }
    }

    /* 11.
    12345
    1234
    123
    12
    1
    12
    123
    1234
    12345
    */
    
    class p3
    {
        static void Main(string[] args)
        {
            for (int r = 5; r >= 1; r--)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();

            }
            for (int r = 2; r <= 5; r++)
            {

                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c);

                }
                Console.WriteLine();
            }
        }
    }

    /* 12. Design a class 'Time' with the following specifications:
      class Time
         Data members/Instance variables
         int hour,min,sec
      Member methods:
         void set time():to accept a time in hour, min and sec
         void show time():to display the time in terms of hour, min and sec.
    Write a main method to create an object of class 'Time' and call the member methods.
    */

    class Time
    {
        int hour, minute, second;

        public void SetTime()
        {
            Console.WriteLine("Enter Time");
            do
            {

                hour = int.Parse(Console.ReadLine());
                minute = int.Parse(Console.ReadLine());
                second = int.Parse(Console.ReadLine());
                if (hour > 24 || minute > 60 || second > 60)
                    Console.WriteLine("Please Enter valid time");

            } while (hour > 24 || minute > 60 || second > 60);
               
            

        }

        public void ShowTime()
        {
            Console.WriteLine(hour+":"+minute+":"+second);
        }
    }

    class clock
    {
        static void Main(string[] args)
        {
            Time t1 = new Time();
            t1.SetTime();
            t1.ShowTime();
        }
    }


    /* 13. Design a class 'Rectangle' with the following specifications:
     class Rectangle
        Data members/Instance variables
        int length, breadth, area, perimeter
     Member methods:
        void input():to accept a length and breadth of rectangle
        int calculatearea():to calculate area
        int calculateperimeter():to calculate perimeter
         void display(): to print area and perimeter of rectangle
   Write a main method to create an object of class 'Rectangle' and call the member methods.
   */

    class Rectangle
    {
        int length, breadth, Area, Perimeter;
         
        public void input()
        {
            Console.WriteLine("Enter length and breadth");
            length = int.Parse(Console.ReadLine());
            breadth = int.Parse(Console.ReadLine());
        }

        public int CalculateArea()
        {
             Area = length * breadth;
            return Area;
        }

        public int CalculatePerimeter()
        {
             Perimeter = 2 * (length + breadth);
            return Perimeter;
        }

        public void  display()
        {
            Console.WriteLine("Length= "+length);
            Console.WriteLine("Breadth= "+breadth);
            Console.WriteLine("Area= " + Area);
            Console.WriteLine("Perimeter= " + Perimeter);
        }

    }

    class rect
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.input();
            r1.CalculateArea();
            r1.CalculatePerimeter();
            r1.display();
        }
    }

    /* 14. Design a class 'Calculaor' with the following specifications:
     class Calculator
        Data members/Instance variables
        int a,b,c
     Member methods:
        void readdata():to accept the values of a and b
        void add():to add a and b and place the result in c.
        void sub():to subtract b from a and place the result in c. Display the result
        void mul():to multiply a and b and  place the result in c. Display the result
        void div():to divide a by b and place the result in c. Display the result
      Write a main method to create an object of class 'Calculator' and call the member methods to enable the task.
   */


    class CalcuLator
    {
        int a, b,c;

        public void ReadData()
        {
            Console.WriteLine("Enter Two numbers");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

        }
        public void add()
        {
             c = a + b;
            Console.WriteLine("add= " + c);

        }
        public void sub()
        {
            c = a - b;
            Console.WriteLine("sub= " + c);


        }
        public void mul()
        {
            c = a * b;
            Console.WriteLine("mul= " + c);

        }
        public void div()
        {
            c = a / b;
            Console.WriteLine("div= " + c);

        }
    }
    

    class task
    {
        static void Main(string[] args)
        {
            CalcuLator a1 = new CalcuLator();
            a1.ReadData();
            a1.add();
            a1.sub();
            a1.mul();
            a1.div();

        }
    }
}

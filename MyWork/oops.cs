using System;
using System.Collections.Generic;
using System.Text;

namespace MyWork
{
    //calculator
    class Calculator
    {
        int n1, n2;
        public void accept()
        {
            Console.WriteLine("enter two number");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

        }

        public void add()
        {
            int sum = n1 + n2;
            Console.WriteLine("sum=" + sum);

        }

        public int product()
        {
            int r = n1 * n2;
            return r;
        }

        public float div()
        { 
              float d = n1/n2;
              return d;
        }
        public int sub()
        {
            int s = n1 - n2;
            return s;
        }




    }

    class TEST
    {
        static void Main(string[] args)
        {
            Calculator ca = new Calculator();
            ca.accept();
            ca.add();
            int r = ca.product();
            float d = ca.div();
            int s = ca.sub();

            Console.WriteLine("multi="+r);
            Console.WriteLine("div="+d);
            Console.WriteLine("sub="+s);


        }
    }

    //Factorial
    class aaa
    {
        int a;
        public void accept()
        {
            Console.WriteLine("enter a number");
            a = int.Parse(Console.ReadLine());

        }

        public int factorial()
        {
            int f = 1;
            for(int i=1;i<=a;i++)
            {
                f = f * i;
               
            }
            return f;
        }

        //prime number
       public bool isprime()
        {
            int count = 0;
            bool result = false;
            for (int j = 1; j <= a; j++)
            {
                if (a % j == 0)
                {
                    count++;
                }

            }
            if (count == 2)
            {
                result = true;
            }
            else
                result = false;
            return result;
        }

    }
    

    class T1
    {
        static void Main(string[] args)
        {


            aaa f1 = new aaa();
            f1.accept();
            int f = f1.factorial();
            bool result = f1.isprime();
            Console.WriteLine("fact= "+f);
            Console.WriteLine(result==true?"prime":"not prime");

        }
    }

    /*
     Create class account containing following methods-
    insert()to insert account data
    display() to display account information
    deposit() to deposit amount
    withdraw(0 to withdraw amount
    checkBalance() to check balance
     
     */
    class account
    {
        string AccName;
        int AccNumber;
        string AccType;
        int AccBalance;
        public void insert()
        {
            Console.WriteLine("Enter AccName, AccNumber, AccType, AccBalance");
            AccName = Console.ReadLine();
            AccNumber = int.Parse(Console.ReadLine());
            AccType= Console.ReadLine();
            AccBalance = int.Parse(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine("AccName: "+AccName);
            Console.WriteLine("AccNumber: "+AccNumber);
            Console.WriteLine("AccType: "+AccType);
            Console.WriteLine("AccBalance: "+AccBalance);
        }
        public void deposit()
        {
            Console.WriteLine("enter deposit ammount");
            int dAmont = int.Parse(Console.ReadLine());
            AccBalance = AccBalance + dAmont;
            Console.WriteLine("After Deposit balance is"+AccBalance);
        }

        public void withdraw()
        {
            Console.WriteLine("enter amount to withdraw");
            int wDraw= int.Parse(Console.ReadLine());
            if(wDraw>AccBalance)
                Console.WriteLine("Insufficient balance");
            else
            {
                AccBalance = AccBalance - wDraw;
                Console.WriteLine("Withdraw successful");
                Console.WriteLine("After withdraw balance is"+ AccBalance);
            }
        }

        public int CheckBalance()
        {
            return AccBalance;
        }
    }

    class bank
    {
        static void Main(string[] args)
        {
            account a1 = new account();
            a1.insert();
            a1.display();
            a1.deposit();
            a1.withdraw();
            int AccBalance = a1.CheckBalance();
            Console.WriteLine("Your AccBalance:"+ AccBalance);
        }
    }

    //static variable
    class hdfcBank
    {
        //Instance variables
        int AccId;
        int AccBal;
        string Accname;
        //static variable
        static float roi = 7.8f;

        //object require to call instance method
        public void m1()
        {
            int a = 90;
            Console.WriteLine(a);
        }

        //static doesnt require object
        //classname.m2();
        static void m2()
        {

        }
        static void Main(string[] args)
        {
            hdfcBank h1 = new hdfcBank();
            h1.m1();
            h1.AccId = 900;
            h1.AccBal = 90000;
            h1.Accname = "Ashvini";
            Console.WriteLine(h1.AccId);
            Console.WriteLine(h1.AccBal);
            Console.WriteLine(h1.Accname);
            hdfcBank.m2();
            Console.WriteLine(  "Hello");
            Console.WriteLine(hdfcBank.roi);
        }
    }

    //set get methods

    class Movie
    {
        string moviename;
        int ratings;

        //set value to moviename
        public void setmoviename(string nmm)
        {
            moviename = nmm;
        }

        public string getmoviename()
        {
           return moviename;
        }
        public void setratings(int r)
        {
            ratings = r;
        }
        public int getratings()
        {
            return ratings;
        }
    }

    class Movieee
    {
        static void Main(string[] args)
        {
            Movie m1 = new Movie();
            m1.setmoviename("Ready");
            Console.WriteLine(m1.getmoviename());
        }
    }

    // Properties

    class Restaurant
    {
        string rname;
        string area;
        long mobileName;
        int ratings;

        public string RestaurantName
        {
            set { rname = value; }
            get { return rname; }
        }
        public string RestaurantArea
        {
            set { area = value; }
            get { return area; }
        }
        public long RestaurantMobileName
        {
            set { mobileName = value; }
            get { return mobileName; }
        }
        public int RestaurantRatings
        {
            set { ratings = value; }
            get { return ratings; }
        }

    }

    class RRR
    {
        static void Main(string[] args)
        {
            Restaurant r1 = new Restaurant();
            r1.RestaurantName = "Ashvini";
            Console.WriteLine(r1.RestaurantName);
            r1.RestaurantArea = "Pune";
            Console.WriteLine(r1.RestaurantArea);
            Console.WriteLine("enter mobile name");
            r1.RestaurantMobileName =long.Parse (Console.ReadLine());
            Console.WriteLine(r1.RestaurantMobileName);
            r1.RestaurantRatings = 4;
            Console.WriteLine(r1.RestaurantRatings);

        }
    }

   //constructor and properties


    /* 12. Design a class 'Time' with the following specifications:
    class Time
       Data members/Instance variables
       int hour,min,sec
    Member methods:
       void set time():to accept a time in hour, min and sec
       void show time():to display the time in terms of hour, min and sec.
  Write a main method to create an object of class 'Time' and call the member methods.
  */

    class Timee
    {
        int hour, minute, second;

        public Timee()
        {
            Console.WriteLine("In default Timee");
        }
        public int Hour
        {
            set { hour = value; }
            get { return hour; }
        }
        public int Minute
        {
            set { minute = value; }
            get { return minute; }
        }
        public int Second
        {
            set { second = value; }
            get { return second; }
        }


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
            Console.WriteLine(hour + ":" + minute + ":" + second);
        }
    }

    class clockk
    {
        static void Main(string[] args)
        {
            Timee t1 = new Timee();
            t1.Hour = int.Parse(Console.ReadLine());
            t1.Minute = int.Parse(Console.ReadLine());
            t1.Second= int.Parse(Console.ReadLine());
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

    class Rectanglee
    {
        int length, breadth, area, perimeter;

        public Rectanglee()
        {
            Console.WriteLine("In default Rectanglee");
        }
        public int Length
        {
            set { length = value; }
            get { return length; }
        }
        public int Breadth
        {
            set { breadth = value; }
            get { return breadth; }
        }
        public int Area
        {
            set { area = value; }
            get { return area; }
        }
        public int Perimeter
        {
            set { perimeter = value; }
            get { return perimeter; }
        }
        public void input()
        {
            Console.WriteLine("Enter length and breadth");
            length = int.Parse(Console.ReadLine());
            breadth = int.Parse(Console.ReadLine());
        }

        public int CalculateArea()
        {
            area = length * breadth;
            return area;
        }

        public int CalculatePerimeter()
        {
            perimeter = 2 * (length + breadth);
            return perimeter;
        }

        public void display()
        {
            Console.WriteLine("Length= " + length);
            Console.WriteLine("Breadth= " + breadth);
            Console.WriteLine("Area= " + area);
            Console.WriteLine("Perimeter= " + perimeter);
        }

    }

    class rectt
    {
        static void Main(string[] args)
        {
            Rectanglee r1 = new Rectanglee();
            r1.Length = int.Parse(Console.ReadLine());
            r1.Breadth = int.Parse(Console.ReadLine());
            r1.input();
            r1.CalculateArea();
            r1.CalculatePerimeter();
            r1.display();
           
        }
    }

    /* 14. Design a class 'Calculator' with the following specifications:
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


    class CalcuLatorr
    {
        int a, b, c;

        public CalcuLatorr()
        {
            Console.WriteLine("In default CalcuLatorr ");
        }
        public int A
        {
            set { a = value; }
            get { return a; }
        }
        public int B
        {
            set { b = value; }
            get { return b; }
        }
        public int C
        {
            set { c = value; }
            get { return c; }
        }


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


    class taskk
    {
        static void Main(string[] args)
        {
            CalcuLatorr a1 = new CalcuLatorr();
            a1.A = int.Parse(Console.ReadLine());
            a1.B = int.Parse(Console.ReadLine());
            a1.ReadData();
            a1.add();
            a1.sub();
            a1.mul();
            a1.div();

        }
    }

    //Method Overloading

    class Overload
    {
        static int max(int a, int b)
        {
            if(a>b)
                return a;
            else
                return b;
        }
        static int max(int a, int b, int c)
        {
            if (a > b && a > c)
                return a;
            else if (b > c)
                return b;
            else
                return c;
        }
        static void Main(string[] args)
        {
           int m1 = max(45, 82);
            Console.WriteLine("Max from 2 is "+m1);
           int m2 = max(34, 21, 89);
            Console.WriteLine("Max from 3 is " + m2);
        }
    }

    //constructor overloading

    class Pen
    {
        string penName;
        string brand;
        string color;
        int price;

        public Pen()
        {
            Console.WriteLine(" In Default Constructor");
        }
        public Pen(string xyz)
        {
            penName = xyz;
            Console.WriteLine("In 1st Constructor");
        }
        public Pen(string xyz, string abc, int pq)
        {
            penName = xyz;
            brand = abc;
            price = pq;
            Console.WriteLine("In 2nd Constructor");
        }
        public Pen(string xyz, string abc, string efg, int pq)
        {
            penName = xyz;
            brand = abc;
            color = efg;
            price = pq;
            Console.WriteLine("In 3rd Constructor");
        }

    }
    class PenTest
    {
        static void Main(string[] args)
        {
            Pen pp = new Pen();
            Pen p1 = new Pen("Trimax");
            Pen p2 = new Pen("Cello", "gelpen", 30);
            Pen p3 =new Pen("Airmail", "Inkpen", "Red", 45); 
        }
    }
    
    //this keyword

    class Pencil
    {
        string pname;
        int cost;
        static int c;
        
        //Static constructor automatically called only once
        static Pencil()
        {
            c = 900;
            Console.WriteLine("in static Costructor");
        }

        //Instance to initialize instance variable
        public Pencil()
        {

        }
        Pencil(string pname, int cost)
        {
            //automatical
            //this--currently invoking object address
            this.pname = pname;
            this.cost = cost;
        }

        //this in instance Method
        public void m1()
        {
            Console.WriteLine("In m1");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("In Main starts");
            Console.WriteLine(Pencil.c);
        }
            
    }
}

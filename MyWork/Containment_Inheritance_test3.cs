using System;
using System.Collections.Generic;
using System.Text;

namespace MyWork
{
 /*1.Create class Teacher with following Tid, Tname,MobileNo
     Parameterized constructor
     abstract void salary()
     Create class Hourlybased which is derived class from teacher with fields rate_per_hr, int hrs;
     Parameterized constructor void salary()
  •Create class SalaryBased which is derived class from teacher. with fields int salary,
     Parameterized constructor void salary()
 Write main to create objects of HourlyBased teacher and SalaryBased teacher 
 and also call respective salary method and also show runtime polymorphism
*/
    abstract class Teacher1
    {
        int tid;
        string tname;
        long tMobNo;
        
         public Teacher1()
         {

         }
        public Teacher1(int tid, string tname, long tMobNo)
        {
            this.Tid = tid;
            this.Tname = tname;
            this.TMobNo = tMobNo;
        }

        abstract public void Salaryy();
        public int Tid { get => tid; set => tid = value; }
        public string Tname { get => tname; set => tname = value; }
        public long TMobNo { get => tMobNo; set => tMobNo = value; }

       

    }

    class Hourlybased:Teacher1
    {
        int rate_per_hr;
        int hrs;
        public Hourlybased(int tid, string tname, long tMobNo, int rate_per_hr, int hrs) : base( tid,  tname,  tMobNo)
        {
            this.Rate_per_hr = rate_per_hr;
            this.Hrs = hrs;
        }

        public int Rate_per_hr { get => rate_per_hr; set => rate_per_hr = value; }
        public int Hrs { get => hrs; set => hrs = value; }
          
        public override void Salaryy()
        {
            Console.WriteLine("salary= "+rate_per_hr*hrs);
        }
    }

    class SalaryBased : Teacher1
    {
        int salary1;

        public SalaryBased(int tid, string tname, long tMobNo, int salary1):base(tid, tname, tMobNo)
        {
            this.Salary1 = salary1;
        }

        public int Salary1 { get => salary1; set => salary1 = value; }

        public override void Salaryy()
        {
            Console.WriteLine("salary= "+Salary1);
        }

    }

    class YTest
    {
        static void Main(string[] args)
        {
            Teacher1 sb1 = new SalaryBased(768, "Rohit", 8976534901, 56000);
            sb1.Salaryy();
            Teacher1 hb1 = new Hourlybased(3456, "Rahul", 8702729027, 3000, 15);
            hb1.Salaryy();
        }
    }

    /*2.A Pen contains variables Refill r, int capLength and String brand.
       Refill has variables inkColor, length and Nib(tip). Nib has variables materialType and width.
       Create a Java class structure for above
       Write a main method which sets values in all the variables using setter methods and prints all the variables using getter methods.
      */

    class Nib
    {
        string mType;
        int width;
        public Nib(string mType, int width)
        {
            Console.WriteLine("In Nib Constructor");
            this.MType = mType;
            this.Width = width;

            
        }

        public string MType { get => mType; set => mType = value; }
        public int Width { get => width; set => width = value; }
    }
    class Refill
    {
        string ink_color;
        int length;
        Nib nib;
        public Refill(string ink_color, int length, Nib nib)
        {
            Console.WriteLine("In Refill Constructor");
            this.Ink_color = ink_color;
            this.Length = length;
            this.nib = nib;

        }

        public string Ink_color { get => ink_color; set => ink_color = value; }
        public int Length { get => length; set => length = value; }
        internal Nib Nnib { get => nib; set => nib = value; }
    }
    class Pen5
    {
        Refill r;
        int capLength;
        string brand;
        public Pen5(Refill r, int capLength, string brand)
        {
            Console.WriteLine("In Pen5 Constructor");
            this.R = r;
            this.CapLength = capLength;
            this.Brand = brand;
           
        }

        public int CapLength { get => capLength; set => capLength = value; }
        public string Brand { get => brand; set => brand = value; }
        internal Refill R { get => r; set => r = value; }
    }

    class Xtest
    {
        static void Main(string[] args)
        {
            Nib nb = new Nib("plastic", 5);
            Console.WriteLine(nb.MType);
            Console.WriteLine(nb.Width);
            Console.WriteLine();

            Refill rf = new Refill("red", 4, nb);
            Console.WriteLine(rf.Ink_color);
            Console.WriteLine(rf.Length);
            Console.WriteLine(rf.Nnib.MType);
            Console.WriteLine(rf.Nnib.Width);
            Console.WriteLine();

            Pen5 p5 = new Pen5(rf, 6, "cello");
            Console.WriteLine(p5.R.Ink_color);
            Console.WriteLine(p5.R.Length);
            Console.WriteLine(p5.R.Nnib.MType);
            Console.WriteLine(p5.R.Nnib.Width);
            Console.WriteLine(p5.CapLength);
            Console.WriteLine(p5.Brand);
        }
    }

    /*3. Write a java program to create 2 person objects. Take input or hardcode for all two person from console.
     Person class is as follows Person(int id, String name, Vehicle v)
     Vehicle(int vid, String name)
   */
   class Vehicle
   {
        int vid;
        string vname;
        public Vehicle(int vid = 0, string vname = null)
        {
            this.vid = vid;
            this.vname = vname;
        }

        public int Vid { get => vid; set => vid = value; }
        public string Vname { get => vname; set => vname = value; }
   }
    class person1
    {
        int id;
        string name;
        Vehicle v;
        
        public person1()
        {
          
            

        }

        public person1(int id, string name, Vehicle v)
        {
            Console.WriteLine("In Person1");
            this.id = id;
            this.name = name;
            this.v = v;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        internal Vehicle V { get => v; set => v = value; }
    }
    class person2
    {
        int id;
        string name;
        Vehicle v;
        
        public person2()
        {
            

        }

        public person2(int id, string name, Vehicle v)
        {
            Console.WriteLine("In Person2");
            this.id = id;
            this.name = name;
            this.v = v;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        internal Vehicle V { get => v; set => v = value; }
    }
    class vperson
    {
        static void Main(string[] args)
        {
            Vehicle vv = new Vehicle(0, null);
            person1 p1 = new person1(0, null, vv);
            Console.WriteLine("Enter person1 Id");
            p1.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter person1 Name");
            p1.Name = Console.ReadLine();
            Console.WriteLine("Enter vehicle id");
            p1.V.Vid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Vehicle name");
            p1.V.Vname = Console.ReadLine();
            Console.WriteLine();

            person2 p2 = new person2(0, null, vv);
            Console.WriteLine("Enter person id");
            p2.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter person Name");
            p2.Name = Console.ReadLine();
            Console.WriteLine("Enter vehicle id");
            p2.V.Vid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter vehicle name");
            p2.V.Vname = Console.ReadLine();

        }
    }

    /*6. Design a class to overload a function volume() as follows: [2M]
    (i) double volume(double r) - with radius 'r' as an argument, returns the volume of
        sphere using the formula: v=4/3x22/7xr3
    (ii) double volume(double h, double r) - with height 'h' and radius 'r' as the
         arguments, returns the volume of a cylinder using the formula: v = 22/7 x 12 xh
    (iii) double volume(double L, double b, double h) - with length 'L', breadth 'b' and height 'h' as the arguments, 
    returns the volume of a cuboid using the formula:v=lxbxh
    */
    class measurements
    {
        static double volume(double r)
        {
            double V = (4 / 3) * (22 / 7) * (r * r * r);
            return V;
        }
        static double volume(double h, double r)
        {
            double V = (22 / 7) * r * r * h;
            return V;
        }
        static double volume(double l, double h, double b)
        { 
            double V = l * b * h;
            return V;
        }
        static void Main(string[] args)
        {
            double v1 = volume(7.4);
            Console.WriteLine(v1);

            double v2 = volume(5.2, 4.6);
            Console.WriteLine(v2);

            double v3 = volume(7.4,2.00,4.00);
            Console.WriteLine(v3);
        }
    }

      /* 7. Design class Order (int orderid,String Orderdate, Customer cust,item item)
           Customer (int custid,String custname Address address)
           Address(String addr1, city, int pincode)
           Item(int itemid, String itemname, int price) Write constructors, getters/setters in respective classes.
      */

    class Address1
    {
        string add1;
        string city;
        int pincode;
        public Address1(string add1, string city, int pincode)
        {
            Console.WriteLine("in address");
            this.Add1 = add1;
            this.City = city;
            this.Pincode = pincode;
        }

        public string Add1 { get => add1; set => add1 = value; }
        public string City { get => city; set => city = value; }
        public int Pincode { get => pincode; set => pincode = value; }
    }
    class Customer1
    {
        string cname;
        int cId;
        Address1 add;

        public Customer1(string cname, int cId, Address1 add)
        {

            Console.WriteLine("In Customer");
            this.Cname = cname;
            this.CId = cId;
            this.Add = add;
        }

        public string Cname { get => cname; set => cname = value; }
        public int CId { get => cId; set => cId = value; }
        internal Address1 Add { get => add; set => add = value; }
    }
    class Item1
    {
        string iname;
        int iprice;
        int iId;
        public Item1(string iname, int iprice, int iId)
        {
            Console.WriteLine("In Item1");
            this.Iname = iname;
            this.Iprice = iprice;
            this.IId = iId;
        }

        public string Iname { get => iname; set => iname = value; }
        public int Iprice { get => iprice; set => iprice = value; }
        public int IId { get => iId; set => iId = value; }
    }
    class Order1
    {
        int orderId;
        string orderdate;
        Customer1 cust;
        Item1 item11;

        public Order1(int orderId, string orderdate, Customer1 cust, Item1 item11)
        {
            Console.WriteLine("In order");
            this.OrderId = orderId;
            this.Orderdate = orderdate;
            this.Cust = cust;
            this.Item11 = item11;
        }

        public int OrderId { get => orderId; set => orderId = value; }
        public string Orderdate { get => orderdate; set => orderdate = value; }
        internal Customer1 Cust { get => cust; set => cust = value; }
        internal Item1 Item11 { get => item11; set => item11 = value; }
    }

    class Containment1
    {
        static void Main(string[] args)
        {
            Address1 aaa1 = new Address1("Dahigaon", "Natepute", 413109);
            Console.WriteLine(aaa1.Add1);
            Console.WriteLine(aaa1.City);
            Console.WriteLine(aaa1.Pincode);
            Console.WriteLine();

            Customer1 ccc4 = new Customer1("Kavya", 1111,aaa1);
            Console.WriteLine(ccc4.Cname);
            Console.WriteLine(ccc4.CId);
            Console.WriteLine(ccc4.Add.Add1);
            Console.WriteLine(ccc4.Add.City);
            Console.WriteLine(ccc4.Add.Pincode);
            Console.WriteLine();

            Item1 iii1 = new Item1("watch", 7000, 12);
            Console.WriteLine(iii1.Iname);
            Console.WriteLine(iii1.Iprice);
            Console.WriteLine(iii1.IId);
            Console.WriteLine();

            Order1 oo1 = new Order1(12, "1/2/2022", ccc4, iii1);
            Console.WriteLine(oo1.OrderId);
            Console.WriteLine(oo1.Orderdate);
            Console.WriteLine(oo1.Cust.Cname);
            Console.WriteLine(oo1.Cust.CId);
            Console.WriteLine(oo1.Cust.Add.Add1);
            Console.WriteLine(oo1.Cust.Add.City);
            Console.WriteLine(oo1.Cust.Add.Pincode);
            Console.WriteLine(oo1.Item11.Iname);
            Console.WriteLine(oo1.Item11.Iprice);
            Console.WriteLine(oo1.Item11.IId);
        }
    }






}







using System;
using System.Collections.Generic;
using System.Text;

namespace MyWork
{
    //single level inheritance
    class parent
    {
        int id = 101;
        string name = "Ashu";
        public int Id { get => id; set => id = value; }
        public string Name{ get => name; set => name= value; }
        public void m1()
        {
            Console.WriteLine("In parent m1");
        }
      

    }
    class child : parent
    {
       
        public void m2()
        {
            Console.WriteLine("In child m2");
        }
    }
    class inherit
    {
        static void Main(string[] args)
        {
            child c = new child();
            c.m1();
            c.m2();
            Console.WriteLine(c.Id);
            Console.WriteLine(c.Name);
        }
    }


    //Multi level inheritance
    class grandparent
    {
        int id = 101;
        string name = "Ashu";
        string city = "pune";
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string City { get => city; set => city = value; }
        public void a1()
        {
            Console.WriteLine("In grandparent a1");
        }


    }
    class parentt : grandparent
    {
        public void a2()
        {
            Console.WriteLine("In child a2");
        }
    }
    class childdd : parentt
    {
        public void a3()
        {
            Console.WriteLine("In child a3");
        }
    }

    class inheritance
    {
        static void Main(string[] args)
        {
            childdd e = new childdd();
            e.a1();
            e.a2();
            e.a3();
            Console.WriteLine(e.Id);
            Console.WriteLine(e.Name);
            Console.WriteLine(e.City);
        }
    }


    //Hierarchical Inheritance
    class Aaa
    {
        int id = 101;
        string name = "Ashu";
        string city = "pune";
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string City { get => city; set => city = value; }
        public void a1()
        {
            Console.WriteLine("In parent a1");
        }


    }
    class Bbb : Aaa
    {
        public void a2()
        {
            Console.WriteLine("In child a2");
        }
    }
    class Ccc: Aaa
    {
        public void a3()
        {
            Console.WriteLine("In child a3");
        }
    }

    class inheritanceee
    {
        static void Main(string[] args)
        {
            Ccc ff = new Ccc();
            ff.a1();
            ff.a3();
            Bbb ff2 = new Bbb();
            ff2.a2();
            ff2.a1();
            
            Console.WriteLine(ff.Id);
            Console.WriteLine(ff.Name);
            Console.WriteLine(ff.City);
        }
    }

    //hybrid Inheritance

    class Xxx
    {
        int id = 101;
        string name = "Ashu";
        string city = "pune";
        int salary = 20000;
        string company = "private";
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string City { get => city; set => city = value; }
        public int Salary { get => salary; set => salary = value; }
        public string Company { get => company; set => company = value; }

        public void n1()
        {
            Console.WriteLine("In grandparent n1");
        }


    }
    class Yyy : Xxx
    {
        public void n2()
        {
            Console.WriteLine("In child n2");
        }
    }
    class Zzz : Yyy
    {
        public void n3()
        {
            Console.WriteLine("In child n3");
        }
    }
    class Ggg : Xxx
    {
        public void n4()
        {
            Console.WriteLine("In child n4");
        }
    }
    class Hhh : Xxx
    {
        public void n5()
        {
            Console.WriteLine("In child n5");
        }
    }

     class Iii
     {
         static void Main(string[] args)
         {
             Hhh h1 = new Hhh();
             h1.n5();
            Ggg g1 = new Ggg();
            g1.n4();
            Zzz z1 = new Zzz();
            z1.n3();
            Yyy y1 = new Yyy();
            y1.n2();
            Console.WriteLine(y1.Id);
             Console.WriteLine(z1.Name);
             Console.WriteLine(g1.City);
            Console.WriteLine(h1.Salary);
         }
     }

    //
    class Teacher
    {
        string tName;
        int salary;
        int experience;
        public Teacher()
        {
            Console.WriteLine("In Teacher Constructor");
        }
        public Teacher(string tName, int salary, int experience)
        {
            this.TName = tName;
            this.Salary = salary;
            this.Experience = experience;
            //Console.WriteLine(tName);
            Console.WriteLine("in Teacher constructor with variable");
        }

        public string TName { get => tName; set => tName = value; }
        public int Salary { get => salary; set => salary = value; }
        public int Experience { get => experience; set => experience = value; }
    }

        class VisitingTeacher : Teacher
        {
            int hrs, rate;
            public VisitingTeacher(string nm, int sal, int exp,int hrs, int r):base(nm,sal,exp)
            {
                Console.WriteLine("in visiting teacher constructor");
               // Console.WriteLine(nm);
                this.Hrs = hrs;
                this.Rate = r;
            }

            public int Hrs { get => hrs; set => hrs = value; }
            public int Rate { get => rate; set => rate = value; }
        }
    
     class TTT
     {
         static void Main(string[] args)
         {
             VisitingTeacher v = new VisitingTeacher("Ashu", 2000, 12, 34, 1000);
           // v.Hrs=5;
            //v.TName = "no say";
            //Console.WriteLine(v.TName);
           // Teacher T5 = new Teacher();
            //T5.TName = "say";
         }
     }

    //Containment

    class Penn
    {
        string brand;
        int cost;
        string color;

        public Penn(string brand, int cost, string color)
        {
            this.Brand = brand;
            this.Cost = cost;
            this.Color = color;
            Console.WriteLine("In penn");
        }

        public string Brand { get => brand; set => brand = value; }
        public int Cost { get => cost; set => cost = value; }
        public string Color { get => color; set => color = value; }
    }

        class CompassBox
        {
            string compassbrand;
            int price;
            Penn pen;


            static void Main(string[] args)
            {
                 
                CompassBox B = new CompassBox();
                B.compassbrand = "Apsara";
                Console.WriteLine(B.compassbrand);
                B.price = 20;
                Console.WriteLine(B.price);
                B.pen = new Penn("Cello", 30, "Black");
            }
        }
        
    //class Order--OrderId,odate,Customer Cust;Item item;
    //containment
    //Has a relationship
    class Customer
    {
        string cname;
        int mobileNo;
        int bill;

        public Customer(string cname, int mobileNo, int bill)
        {
            this.cname = cname;
            this.mobileNo = mobileNo;
            this.bill = bill;
            Console.WriteLine("In Customer");
        }

        public string Cname { get => cname; set => cname = value; }
        public int MobileNo { get => mobileNo; set => mobileNo = value; }
        public int Bill { get => bill; set => bill = value; }
    }
    class Item
    {
        string iname;
        int iprice;
        public Item(string iname, int iprice)
        {
            this.Iname = iname;
            this.Iprice = iprice;
            Console.WriteLine("In Item");
        }

        public string Iname { get => iname; set => iname = value; }
        public int Iprice { get => iprice; set => iprice = value; }
    }
    class Order
    {
        int orderId;
        string ordertype;
        Customer cust;
        Item item;

        static void Main(string[] args)
        {
            Order o1 = new Order();
            o1.orderId = 1234;
            o1.ordertype ="online";
            Console.WriteLine(o1.orderId);
            Console.WriteLine(o1.ordertype);
            o1.cust = new Customer("Ashu", 453216789, 2000);
            o1.item = new Item("Watch",3000);
        }
    }

    //Developer
    //webDeveloper
    //Inheritance
    //is a relationship
    class Developer
    {
        string dName;
        string department;
        int dsalary;
        public Developer()
        {
            Console.WriteLine("in default Developer");
        }
        public Developer(string dName, string department, int dSalary)
        {
            this.DName = dName;
            this.department = department;
            this.Dsalary = dSalary;
        }

        public string DName { get => dName; set => dName = value; }
        public string Department { get => department; set => department = value; }
        public int Dsalary { get => dsalary; set => dsalary = value; }
    }

    class WebDeveloper:Developer
    {
        string technology;
        string specialization;
        public WebDeveloper(string technology, string specialization)
        {
            this.Technology = technology;
            this.Specialization = specialization;
           
        }

        public string Technology { get => technology; set => technology = value; }
        public string Specialization { get => specialization; set => specialization = value; }
    }
     class multipleInheritance
     {
        static void Main(string[] args)
        {
            WebDeveloper w = new WebDeveloper("dotnet", "c#");
           
            Console.WriteLine(w.Technology);
            Console.WriteLine(w.Specialization);
            Console.WriteLine(w.DName);
            Console.WriteLine(w.Department);
            Console.WriteLine(w.Dsalary);


            Developer d = new Developer("Mahesh", "software", 23400);
            Console.WriteLine(d.DName);
            Console.WriteLine(d.Department);
            Console.WriteLine(d.Dsalary);

        }
     }


    //Overridding

    class Parent //Permission authority
    {
       // string name;
        public void play()
        {
          
        }
        public virtual void study()
        {
            Console.WriteLine("Read books");
           
        }
        public  void playy()
        {
            Console.WriteLine("on ground");
        }
    }

    class children:Parent
    {
         public override void study() //method riding
         {
            Console.WriteLine("Learn watching online class");
        }
        public new void playy()   //To do Method hiding we use new keyword
        {
            Console.WriteLine("online games");
        }
    }

    class TTest
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            p.study();
            p.playy();


            children c1 = new children();
            c1.study();
            c1.playy();

            //reference variable of parent type can hold object of child

            Parent p2 = new children();
            p2.study();
            p2.playy();
        }
    }

    //sealed keyword

    class pqr
    {
        public virtual void m1()
        {
            Console.WriteLine("In parent");
        }

    }

    class abc:pqr
    {
        public override void m1() //for sealed method we can write public sealed override void m1()
        {
            Console.WriteLine("In child abc");
        }

    }

    class def:abc
    {
        public override void m1()
        {
            Console.WriteLine("In child def");
        }

    }

    class checkkk
    {
        static void Main(string[] args)
        {
            abc pp = new def();
            pp.m1();
        }
    }

    //To string

    class asd
    {
        int num;
        string name;
        int percent;

        public asd(int num, string name, int percent)
        {
            this.num= num;
            this.name=name;
            this.percent=percent;

        }
        public override string ToString()
        {
            return $"num{num} name{name} percent{percent}";
        }
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);
            asd s1 = new asd(1, "Aniket", 90);
            Console.WriteLine("s1");
        }
            
    }

    //Abstract

    abstract class Teacherrr
    {
        string name;
        int exp;


        public Teacherrr(string name, int exp)
        {
            this.Name = name;
            this.Exp = exp;
        }
        public Teacherrr()
        {
           
        }
        public void m3()
        {

        }
        abstract public void calculatesalary();
        public string Name { get => name; set => name = value; }
        public int Exp { get => exp; set => exp = value; }
    }
        class permanentTeacher:Teacherrr
        {
            int salary=12000;
           public permanentTeacher():base()
           {
                
           }
            public override void calculatesalary()
            {
                Console.WriteLine("salary= "+salary);
            }

        }
        class visitingTeacherr: Teacherrr
        {
            int hrs=4, rate=4000;
            public override void calculatesalary()
            {
                Console.WriteLine("salary=" +hrs*rate);
            }
        }

        class TTTT
        {
            static void Main(string[] args)
            {
                Teacherrr T = new permanentTeacher();
                T.calculatesalary();
            }
        }





    

}



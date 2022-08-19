using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace MyWork
{
    // 1.	WAP to sort the elements of List that contains String objects.Print List.

    class Animall:IComparable<Animall>
    {
        string Aname;
        int speed;
        string color;

        public Animall(string aname, int speed, string color)
        {
            Aname1 = aname;
            this.Speed = speed;
            this.Color = color;
        }

        public string Aname1 { get => Aname; set => Aname = value; }
        public int Speed { get => speed; set => speed = value; }
        public string Color { get => color; set => color = value; }

        public override string ToString()
        {
            return "Name: " + Aname + " speed: " + Speed + " color: " + Color;
        }

        public int CompareTo(Animall other)
        {
            return this.Aname.CompareTo(other.Aname);
        }

        
    }
    class Testt1
    {
        static void Main(string[] args)
        {
            List<Animall> lt1 = new List<Animall>();
            lt1.Add(new Animall("Tiger",45,"Orange"));
            lt1.Add(new Animall("Lion",56,"Yellow"));
            lt1.Add(new Animall("Deer",87,"Brown"));
            lt1.Add(new Animall("Elephant",32,"Grey"));
            lt1.Add(new Animall("Beer",21,"Black"));
            lt1.Add(new Animall("Giraffe",33,"Chestnut"));

            Console.WriteLine("Original List");
            foreach (Animall data in lt1)
                Console.WriteLine(data);

            Console.WriteLine("........................................");
            Console.WriteLine("List after sorting ");
            lt1.Sort();

            foreach (Animall data in lt1)
                Console.WriteLine(data);
        }
    }

    //2.	WAP to create a class Employee with(name, designation , salary).
    //      Now create and add Employee objects elements to List.Print List.

    class Employyeee 
    {
        string name;
        int salary;
        string designation;

        public Employyeee(string name, int salary, string designation)
        {
            this.Name = name;
            this.salary = salary;
            this.designation = designation;
        }

        public override string ToString()
        {
            return "Name: " + name + " salary: " + salary + " designation: " + designation;
        }


        public string Name { get => name; set => name = value; }
        public int Salary { get => salary; set => salary = value; }
        public string Designation { get => designation; set => designation = value; }
    }

    class Testt2
    {
        static void Main(string[] args)
        {
            List<Employyeee> lt2 = new List<Employyeee>();
            lt2.Add(new Employyeee("Tanu", 20000, "System Engg"));
            lt2.Add(new Employyeee("Ganu",30000, "Trainee"));
            lt2.Add(new Employyeee("Banu", 34000, "Senior Engg"));
            lt2.Add(new Employyeee("Manu", 65000, "Production Engg"));
            lt2.Add(new Employyeee("Panu", 49000, "Quality Engg"));

            foreach (Employyeee data in lt2)
                Console.WriteLine(data);

        }
    }

    //3.	WAP to create a Queue with some colors(String) using generics.

    class Assignmentt3
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("Red");
            q.Enqueue("Blue");
            q.Enqueue("yellow");
            q.Enqueue("Black");
            q.Enqueue("Orange");

            foreach (string d in q)
                Console.WriteLine(d);
        }
    }

    //4. WAP to add user defined objects of type Employee in a HashSet employee object.
    //   Make sure if I create 2 different objects with same data the other one
    //   should not be added as hashset stores unique objects.

    class Assignment4
    {
        static void Main(string[] args)
        {
            HashSet<string> hs1 = new HashSet<string>() { "ename", "eId", "esalary", "eDesignation" };
            HashSet<string> hs2 = new HashSet<string>() { "edepartment", "esalary", "egarde", "eId" };

            hs1.UnionWith(hs2);

            foreach (string d in hs1)
                Console.WriteLine(d + " ");

        }
    }

    // 5.	WAP to create SortedList where key is of Integer type
    //      and value string and print all key-value pairs.

    class Assignment5
    {
        static void Main(string[] args)
        {
            SortedList<int, string> ss = new SortedList<int, string>();
            ss.Add(92, "S");
            ss.Add(62, "o");
            ss.Add(44, "x");
            ss.Add(98, "u");
            ss.Add(79, "h");
            ss.Add(74, "S");
           
            foreach (KeyValuePair<int, string> kv in ss)
                Console.WriteLine(kv.Key + "===>" + kv.Value);

        }
    }

    //6. WAP to create Dictionary where key is of string type
    //   and value of float type and print all key-value pairs.

    class Assignment6
    {
        static void Main(string[] args)
        {
            Dictionary<string, float> dd = new Dictionary<string, float>();
            dd.Add("English", 34.6f);
            dd.Add("Hindi", 76.9f);
            dd.Add("Marathi", 93.3f);
            dd.Add("Urdu", 87.0f);
         
            foreach (KeyValuePair<string, float> kv in dd)
                Console.WriteLine(kv.Key + "==>" + kv.Value);
        }
    }

    //7. Make use of such collection that stores moviename such that
    //   last entered movie is first deleted and accordingly previous one.

    class Assignment7
    {
        static void Main(string[] args)
        {
            Stack<string> st = new Stack<string>();

            st.Push("Twilight");
            string datapeek = st.Peek();
            Console.WriteLine("Entered Movie: " + datapeek);

            st.Push("Runway 34");
            string datapeek1 = st.Peek();
            Console.WriteLine("Entered Movie: " + datapeek1);

            st.Push("Malignant");
            string datapeek2 = st.Peek();
            Console.WriteLine("Entered Movie: " + datapeek2);

            st.Push("Avtar");
            string datapeek3 = st.Peek();
            Console.WriteLine("Entered Movie: " + datapeek3);

            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            while (st.Count > 0)
            {
                string DeletedMovie = st.Pop();
                Console.WriteLine("Deleted movie: " + DeletedMovie);
            }

        }
    }

    //8. WAP to create SortedList<Employee,string> where key is of Employee type
    // and value is departmentname(string) he works in.
    // SortedList should maintain data in descending order of salary.

    class Emp1 : IComparable<Emp1>
    {
        string name;
        int salary;
        string designation;

        public Emp1(string name, int salary, string designation)
        {
            this.Name = name;
            this.salary = salary;
            this.designation = designation;
        }

        public override string ToString()
        {
            return "Name: " + name + " salary: " + salary + " designation: " + designation;
        }

        public int CompareTo(Emp1 other)
        {
            return other.salary.CompareTo(this.salary);
        }

        public string Name { get => name; set => name = value; }
        public int Salary { get => salary; set => salary = value; }
        public string Designation { get => designation; set => designation = value; }
    }

    class Assignmentt8
    {
        static void Main(string[] args)
        {
            SortedList<Emp1, string> ss = new SortedList<Emp1, string>();
            ss.Add(new Emp1("Raja", 65000, "system engg"), "computer");
            ss.Add(new Emp1("Rani", 43000, "Production engg"), "Mechanical");
            ss.Add(new Emp1("Romeo", 34000, "HR"), "HR");
            ss.Add(new Emp1("Juliet", 76000, "Trainee"), "IT");
            ss.Add(new Emp1("Heer", 54000, "IT engg"), "Web service");
            ss.Add(new Emp1("Ranjha", 62000, "Senior engg"), "IT");

            foreach (KeyValuePair<Emp1, string> kv in ss)
                Console.WriteLine(kv.Key + "===>" + kv.Value);

        }
    }

    //9. Create a class Flat (flatno, WingName, List<Member> memberlist)
    //Member(memberid, membername, profession, age)
    //  Create of 2 flat objects

    class Member
    {
        int memberId;
        string membername;
        string profession;
        int age;

        public Member(int memberId, string membername, string profession, int age)
        {
            this.MemberId = memberId;
            this.Membername = membername;
            this.Profession = profession;
            this.Age = age;
        }

        public int MemberId { get => memberId; set => memberId = value; }
        public string Membername { get => membername; set => membername = value; }
        public string Profession { get => profession; set => profession = value; }
        public int Age { get => age; set => age = value; }

        public override string ToString()
        {
            return "memberId: " + memberId + " membername: " + membername + " profession: " + profession + " age: " + age;
        }
    }
    class Flat
    {
        int flatno;
        string wingname;
        List<Member> memberlist;

        public Flat(int flatno, string wingname, List<Member> memberlist)
        {
            this.Flatno = flatno;
            this.Wingname = wingname;
            this.Memberlist = memberlist;
        }

        public int Flatno { get => flatno; set => flatno = value; }
        public string Wingname { get => wingname; set => wingname = value; }
        internal List<Member> Memberlist { get => memberlist; set => memberlist = value; }

        public override string ToString()
        {
            return "Flatno: " + flatno + " wingname: " + wingname + " memberlist: " + memberlist;
        }

        static void Main(string[] args)
        {
            List<Member> lst1 = new List<Member>();
            lst1.Add(new Member(1, "Ashvini","Developer",28));
            lst1.Add(new Member(2, "Shital", "Embedded Developer", 29));

            List<Flat> lst = new List<Flat>();
            lst.Add(new Flat(101, "A", lst1));
            lst.Add(new Flat(102, "B", new List<Member>()));

            List<Member> mlist =lst[1].Memberlist;
            mlist.Add(new Member(1, "Kavya", "Scientist", 30));
            mlist.Add(new Member(2, "Shivanya", "Doctor", 31));

            foreach(Flat D in lst)
                Console.WriteLine(D);

            foreach(Member M in lst1)
                Console.WriteLine(M);
        }

    }

    //OR

    class Demoflat
    {
        static void Main(string[] args)
        {
            List<Flat> flist = new List<Flat>();

            do
            {
                Console.WriteLine("Enter no of wing");
                int flatno = int.Parse(Console.ReadLine());
                string wing = Console.ReadLine();
                Console.WriteLine("Enter no of member in your flat");
                int n = int.Parse(Console.ReadLine());

                List<Member> memberlist = new List<Member>();

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Enter member name, profession, age");
                    string mnm = Console.ReadLine();
                    string prof = Console.ReadLine();
                    int age = int.Parse(Console.ReadLine());
                    Member mobj = new Member(i, mnm, prof, age);
                    memberlist.Add(mobj);
                }

                flist.Add(new Flat(flatno, wing, memberlist));
                Console.WriteLine("do u want to add one more flat details");
                string choice = Console.ReadLine();

                if (choice.ToLower() == "no")
                    break;
            } while (true);

            foreach(Flat fobj in flist)
            {
                Console.WriteLine("FlatNo " + fobj.Flatno);
                Console.WriteLine("wing "+fobj.Wingname);
                List<Member> mlst = fobj.Memberlist;

                foreach(Member mobj in mlst)
                    Console.WriteLine(mobj);
            }
        }
    }

}

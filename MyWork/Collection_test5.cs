using System;
using System.Collections.Generic;
using System.Text;

namespace MyWork
{
    //1.WAP add elements to List<String>,insert at specifies=d position ,update and delete a element
    class Ass1
    {
        static void Main(string[] args)
        {
            List<string> element = new List<string>();
            element.Add("Sugar");
            element.Add("salt");
            element.Add("Soda");
            element.Add("Coffee");
            element.Add("Tea");

            element.Insert(3, "Vanilla");

            foreach(string s in element)
                Console.WriteLine(s);

            element[2] = "CompassBox";
        
            element.Remove("Coffee");

            foreach (string d in element)
                Console.WriteLine(d);
        }
    }
    //2.WAP to create a new List, add some colors (string) and print the collection.
    class ColorC
    {
        static void Main(string[] args)
        {
            List<string> color = new List<string>();
            color.Add("Purple");
            color.Add("OliveGreen");
            color.Add("Grey");
            color.Add("White");
            color.Add("black");
            color.Add("Black");
            color.Add("orange");

            foreach (string d in color)
                Console.WriteLine(d);

            /*OR
                for (int i = 0; i < color.Count; i++)
                Console.WriteLine(color[i]);*/
        }
    }

    // 3.WAP of swap two elements in an List

    class Assignment3
    {
        public static void Swap<T>(List<T> list, int i, int j)
        {
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }

    public class Example
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };
            Assignment3.Swap(nums, 2, 3);
            Console.WriteLine(String.Join(", ", nums));
        }
    }

     //4.WAP to replace the second element of an List with the specified element
     class ReplaceEle
     {
         static void Main(string[] args)
         {
             List<int> lst = new List<int>();
             lst.Add(1);
             lst.Add(4);
             lst.Add(8);
             lst.Add(9);
             lst.Add(4);
             lst.Add(5);
             for (int i = 0; i < lst.Count; i++)
                 Console.WriteLine("Before Replacing: " + lst[i]);

             lst[1] = 10;
             for (int i = 0; i < lst.Count; i++)
                 Console.WriteLine("After Replacing: " + lst[i]);
         }
     }

    //5.WAP to create List of Students and iterate over it.

    class studentt : IComparable<studentt>
    {
        string name;
        int percent;
        string qualification;

        public studentt(string name, int percent, string qualification)
        {
            this.Name = name;
            this.Percent = percent;
            this.Qualification = qualification;
        }

        public override string ToString()
        {
            return "Name: " + name + " Percent: " + percent + " Eduacation: " + qualification;
        }

        public int CompareTo(studentt other)
        {
            return this.percent.CompareTo(other.percent);
        }

        public string Name { get => name; set => name = value; }
        public int Percent { get => percent; set => percent = value; }
        public string Qualification { get => qualification; set => qualification = value; }
    }

    class IterateStud
    {
         static void Main(string[] args)
         {
             List<studentt> ls = new List<studentt>();
             ls.Add(new studentt("Vicky", 90,"BE"));
             ls.Add(new studentt("Nidhi", 98, "BCS"));
             ls.Add(new studentt("Rahul", 70, "BCA"));
             ls.Add(new studentt("Jayu", 67, "BTech"));
             ls.Add(new studentt("Anu", 98, "BE"));

             foreach (var obj in ls)
                 Console.WriteLine(obj);
         }
    }
    
     //6.	WAP to convert List to array.
     class ConArr
     {
         static void Main(string[] args)
         {
             List<int> num = new List<int>();
             num.Add(10);
             num.Add(20);
             num.Add(30);
             num.Add(40);
             num.Add(50);
             num.Add(60);
             num.Add(70);
             num.Add(80);
             num.Add(90);
             num.Add(100);

             int[] a = num.ToArray();

             Console.WriteLine("Displaying Array Elements");
             foreach (int i in a)
                 Console.Write(i+" ");
         }
     }

    
     //7.WAP to print list in reverse order .
     class RevOrder
     {
         static void Main(string[] args)
         {
             List<string> restr = new List<string>();
             restr.Add("Jyoti");
             restr.Add("shubham");
             restr.Add("pritam");
             restr.Add("amruta");
             restr.Add("anu");
             restr.Add("shaml");
             restr.Add("meera");
             foreach (string k in restr)
                 Console.WriteLine(k);

             Console.WriteLine("...................");

             restr.Reverse();

             foreach (string k in restr)
                 Console.WriteLine(k);
         }
     }
    
     //8.	WAP to sort the elements of List that contains String objects. Print List.
     class SortEle
     {
         static void Main(string[] args)
         {
             List<string> s = new List<string>();
             s.Add("Welcome");
             s.Add("to");
             s.Add("Mahableshwar");
             s.Add("Enjoy");
             s.Add("View");

             foreach (string st in s)
                 Console.WriteLine(st);
             Console.WriteLine("....................");

             s.Sort();
             foreach (string st in s)
                 Console.WriteLine(st);
         }
     }

    
     //9.  WAP to create a class Employee with (name, designation and age).Now create and
     //    add Employee objects elements to list. Sort the List by age in descending order and print List
     public class Employees : IComparable<Employees>
     {

         string name;
         string desig;
         int age;

         public string Name { get => name; set => name = value; }
         public string Desig { get => desig; set => desig = value; }
         public int Age { get => age; set => age = value; }

         public Employees(string name, string desig, int age)
         {
             this.Name = name;
             this.Desig = desig;
             this.Age = age;
         }
         public int CompareTo(Employees obj)
         {
             return Age.CompareTo(obj.Age);

         }

         static void Main(string[] args)
         {
             List<Employees> lst = new List<Employees>();
             lst.Add(new Employees("Jyoti", "SoftwareDeveloper", 25));
             lst.Add(new Employees("Shubham", "FinancialAnalyst", 27));
             lst.Add(new Employees("Aardhana", "Trainer", 24));
             lst.Add(new Employees("Gitanjali", "SeniorDeveloper", 26));

             lst.Sort();
             foreach (Employees ss in lst)
                 Console.WriteLine(ss.age);
         }
     }

    
     //10.	WAP to add elements to a Dictionary and print content of it. Use int as Key and String as Value.
     //     Also iterate over dictionary and print key value pair.
     class Ddd
     {
         static void Main(string[] args)
         {
             Dictionary<int, string> dict = new Dictionary<int, string>
             {
                 {92,"Vijay"},
                 {98,"Omie" },
                 {199,"Arun"},
                 {122,"Yogesh"},
                 {57,"Madhura"}
             };
             foreach (var (key, value) in dict)
             {
                 Console.WriteLine(key + " : " + value);

             }
         }
     }

    
     //11.	WAP to get only the Keys from a Dictionary
     class GetKeys
     {
         public static void Main()
         {
             Dictionary<int, string> d = new Dictionary<int, string>();
             // dictionary elements
             d.Add(1, "Apple");
             d.Add(2, "Grapes");
             d.Add(3, "Cherry");
             d.Add(4, "Blackberries");
             d.Add(5, "Banana");
             d.Add(6, "Watermelon");
             d.Add(7, "Guva");
             d.Add(8, "Peach");

             // getting keys
             List<int> keys = new List<int>(d.Keys);

             Console.WriteLine("keys...");

             foreach (int res in keys)
             {
                 Console.WriteLine(res);
             }
         }
     }

    
     //12.	WAP to get only the Values from a Dictionary

     class GetValues
     {
         public static void Main()
         {
             Dictionary<int, string> d = new Dictionary<int, string>();
             // dictionary elements
             d.Add(1, "Apple");
             d.Add(2, "Grapes");
             d.Add(3, "Cherry");
             d.Add(4, "Blackberries");
             d.Add(5, "Banana");
             d.Add(6, "Watermelon");
             d.Add(7, "Guva");
             d.Add(8, "Peach");

             // getting values
             List<string> value = new List<string>(d.Values);

             Console.WriteLine("Values...");

             foreach (string res in value)
             {
                 Console.WriteLine(res);
             }
         }
     }


    //13.WAP to create a  Dictionary  using Custom class as key and any other object as value

    class Customerr : IComparable<Customerr>
    {
        int eno;
        string name;
        string depname;
        public Customerr(int eno, string name, string depname)
        {
            this.Eno = eno;
            this.Name = name;
            this.Depname = depname;
        }

        public int CompareTo(Customerr other)
        {
            return this.name.CompareTo(other.name);
        }
        public int Eno { get => eno; set => eno = value; }
        public string Name { get => name; set => name = value; }
        public string Depname { get => depname; set => depname = value; }

        public override string ToString()
        {
            return "Eno:" + Eno + "Name" + Name + "Departmentname" + Depname;
        }

    }

    class CusDic
    {
        static void Main(string[] args)
        {
            Dictionary<Customerr, int> d1 = new Dictionary<Customerr, int>();
            d1.Add(new Customerr(1,"Ashu", "It"), 01);
            d1.Add(new Customerr(2, "Amu", "It"), 02);
            d1.Add(new Customerr(3, "Anu", "It"), 04);


            foreach (KeyValuePair<Customerr, int> jp in d1)
                Console.WriteLine(jp.Key + "===>" + jp.Value);
        }
    }

    
    //14.WAP to create a Queue to add 5 objects and also remove first two and iterate over it. 
    class Que
    {
         static void Main(string[] args)
         {
             Queue<int> q = new Queue<int>();
             q.Enqueue(10);
             q.Enqueue(20);
             q.Enqueue(30);
             q.Enqueue(40);
             q.Enqueue(50);

             foreach (int c in q)
                 Console.WriteLine("Before Removing Queue: " + c);
             Console.WriteLine(".............................");

             q.Dequeue();
             q.Dequeue();

             foreach (int c in q)
                 Console.WriteLine("After Removing Queue: " + c);
         }
    }


     //15.WAP to create a Stack to store some objects and iterate over it. Also show use od push,pop,peek.
     class StackFlow
     {
         static void Main(string[] args)
         {
             Stack<string> ss = new Stack<string>();
             ss.Push("Alpha");
             ss.Push("Bita");
             ss.Push("sin");
             ss.Push("Cosx");

             string[] arr = new string[ss.Count];
             ss.CopyTo(arr, 0);

             foreach (string i in arr)
                 Console.WriteLine(i);
             Console.WriteLine("....................");

             ss.Push("Maths");
             string DataPop = ss.Pop();
             Console.WriteLine("Pop:" + DataPop);

             string DataPeek = ss.Peek();
             Console.WriteLine("Peek:" + DataPeek);
         }
     }

    //16.WAP to create a LinkedList<Emp> and search for Emp object whose eno=10 and
    //delete all the records whose dept is same as  eno 10. Emp(int eno, String name string deptnmae)
    class Empp
    {
        int eno;
        string name;
        string depname;
        public Empp(int eno, string name, string depname)
        {
            this.Eno = eno;
            this.Name = name;
            this.Depname = depname;
        }

        public int Eno { get => eno; set => eno = value; }
        public string Name { get => name; set => name = value; }
        public string Depname { get => depname; set => depname = value; }

        public override string ToString()
        {
            return "Eno:" + Eno + "Name" + Name + "Departmentname" + Depname;
        }

    }
    class Collection_test5
    {
        static void Main(string[] args)
        {
            LinkedList<Empp> ll = new LinkedList<Empp>();
            ll.AddLast(new Empp(1, "AA", "IT"));
            ll.AddLast(new Empp(2, "BB", "Testing"));
            ll.AddLast(new Empp(4, "CC", "HR"));
            ll.AddLast(new Empp(5, "DD", "IT"));
            ll.AddLast(new Empp(6, "EE", "IT"));
            ll.AddLast(new Empp(8, "FF", "HR"));
            ll.AddLast(new Empp(10, "GG", "Testing"));

            string dname = "";
            foreach (Empp e in ll)
            {
                if (e.Eno == 10)
                {
                    dname = e.Depname;
                    Console.WriteLine(dname);
                    break;
                }
            }

            foreach (Empp e in ll)
            {
                if (e.Depname == dname)
                {
                    Console.WriteLine(e);
                }
            }


        }
    }


    //17.WAP to show  exception and use multiple catch block with universal Exception handler
     class Exc
     {
         static void Main(string[] args)
         {
             int[] num = { 21, 32, 63, 40, 5, 60 };
             int[] div = { 2, 0, 0, 5 };
             for (int i = 0; i < num.Length; i++)
                 try
                 {
                     Console.WriteLine("Number:" + num[i]);
                     Console.WriteLine("Divisor:" + div[i]);
                     Console.WriteLine("Quotient:" + num[i] / div[i]);
                 }
                 catch (DivideByZeroException)
                 {
                     Console.WriteLine("Can't Possible to Divide by Zero");
                 }
                 catch (IndexOutOfRangeException)
                 {
                     Console.WriteLine("Index is Out of Range");
                 }
         }
     }

     //18.WAP to create custom Exception and show use of throw keyword
     class InvalidAgeException : ApplicationException
     {
         public InvalidAgeException(String message) : base(message)
         {

         }

     }
     public class TestUserDefinedException
     {
         static void validate(int age)
         {
             if (age < 18)
             {
                 throw new InvalidAgeException("Sorry, Age must be greater than 18");
             }
         }
         public static void Main(string[] args)
         {
             try
             {
                 validate(12);
             }
             catch (InvalidAgeException e)
             {
                 Console.WriteLine(e);
             }
         }

     }
}

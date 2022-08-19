using System;
using System.Collections.Generic;
using System.Text;

namespace MyWork
{
    //1.List methods
    class Collection_New
    {
        static void Main(string[] args)
        {
            List<string> l2 = new List<string>() { "Deepa", "Hema", "Rekha" };

            List<string> lst = new List<string>(20);
            Console.WriteLine(lst.Count);
            Console.WriteLine(lst.Capacity);

            lst.Add("A");
            lst.Add("B");
            lst.Add("V");
            lst.Add("G");
            lst.Add("A");
            lst.Add("Y");
            lst.Add("A");

            //lst.AddRange(l2);
            lst.InsertRange(0, l2);
            //lst.Remove("A");
           // lst.RemoveAt(0);
            //lst.Add("Chitra");
            //lst.Insert(3, "Chitra");

            foreach(string s in lst)
                Console.WriteLine(s);

            string[] str = lst.ToArray();
            //lst.Clear();
            int idx1 = lst.IndexOf("s");
            int idx2 = lst.LastIndexOf("k");

            Console.WriteLine(lst.Contains("Kavita"));
        }
    }

    //2.List 
    class student:IComparable<student>
    {
        string name;
        int percent;
        string qualification;

        public student(string name, int percent, string qualification)
        {
            this.Name = name;
            this.Percent = percent;
            this.Qualification = qualification;
        }

        public override string ToString()
        {
            return "Name: " + name + " Percent: " + percent + " Eduacation: " + qualification;
        }

        public int CompareTo(student other)
        {
            return this.percent.CompareTo(other.percent);
        }

        public string Name { get => name; set => name = value; }
        public int Percent { get => percent; set => percent = value; }
        public string Qualification { get => qualification; set => qualification = value; }
    }

    class Checkkk
    {
        static void Main(string[] args)
        {
            List<student> slist = new List<student>();
            slist.Add(new student("Ajinkya", 90, "BE"));
            slist.Add(new student("Vijay", 50, "BE"));
            slist.Add(new student("Jay", 80, "BE"));
            slist.Add(new student("Maya", 70, "BE"));
            slist.Add(new student("Chhaya", 90, "BE"));

            slist.Sort();
            slist.ForEach(s1 => Console.WriteLine(s1));

            List<student> ss = slist.FindAll(sobj => sobj.Percent > 90);
            foreach (student s in slist)
            {
                if (s.Percent > 70)
                    Console.WriteLine(s.Name + " " + s.Percent + " " + s.Qualification);
            }
        }
    }

    //3.

    class NewClass
    {
        static bool isOdd(int n)
        {
            Console.WriteLine("in odd "+n);
            return n % 2 == 1;
        }

        static void Main(string[] args)
        {
            List<string> l1 = new List<string>() { "Deepa", "Medha", "kirti", "Prajakta" };
            l1.Sort();
            l1.Reverse();
            foreach (string s in l1)
            {
                Console.WriteLine(s+" ");
            }

            List<int> l2 = new List<int>() { 12, 23, 34, 45 };
            List<int> oddlist = l2.FindAll(isOdd);
            foreach(int s in oddlist)
                Console.WriteLine(s+" ");
        }
    }

    //LinkedList

    class DemolinkedList
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddLast(100);
            ll.AddLast(200);
            ll.AddLast(300);

            ll.AddFirst(50);

            LinkedListNode<int> n1 = ll.Find(100);
            ll.AddAfter(n1, 150);
            ll.AddBefore(n1, 90);

            ll.Remove(150);

            foreach(int a1 in ll)
                Console.WriteLine(a1);
        }
    }

    class Demodictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dd = new Dictionary<string, int>();
            dd.Add("ajinkya", 90);
            dd.Add("Asma", 90);
            dd.Add("Kamal", 90);
            // dd.Add("ajinkya", 90);

            dd["ajinkya"] = 95;

            // Remove key
            dd.Remove("Asma");

            Console.WriteLine(dd.Count);
            //dd.Clear

            Console.WriteLine(dd.ContainsKey("Om"));
            Console.WriteLine(dd.ContainsValue(90));

            //List<string> keys = dd.Keys.ToList();

            Console.WriteLine(dd["Kamal"]);
            foreach (KeyValuePair<string, int> kv in dd)
                Console.WriteLine(kv.Key+"==>"+kv.Value);
        }
    }

    class aaaaa
    {
        static void Main(string[] args)
        {
            string s1 = "aayush";
            char[] arr = s1.ToCharArray();

            Dictionary<char, int> d1 = new Dictionary<char, int>();

            foreach(char ch in arr)
            {
                if(d1.ContainsKey(ch))
                {
                    int curval = d1[ch];
                    d1[ch] = curval + 1;
                }
                else
                {
                    d1.Add(ch, 1);
                }
            }
        }
    }

    //sorted list

    class c1
    {
        static void Main(string[] args)
        {
            SortedList<string, int> ss = new SortedList<string, int>();
            ss.Add("Priya", 99);
            ss.Add("Riya", 99);
            ss.Add("Jiya", 99);
            ss.Add("Siya", 99);
            ss.Add("Piya", 99);
            ss.Add("Tiya", 99);

            ss.Remove("Siya");
            ss["Piya"] = 90;
            Console.WriteLine(ss.ContainsKey("AA"));
            Console.WriteLine(ss.Count);

            foreach (var d in ss)
                Console.WriteLine(d.Key + "===>" + d.Value);
        }
    }

    //string builder in sorted list

    class SBSort : IComparer<StringBuilder>
    {
        public int Compare(StringBuilder x, StringBuilder y)
        {
            return x.ToString().CompareTo(y.ToString());
        }
    }

    class Demoss3
    {
        static void Main(string[] args)
        {
            SortedList<StringBuilder, int> sb = new SortedList<StringBuilder, int>(new SBSort());

            sb.Add(new StringBuilder("Amit"), 90);
            sb.Add(new StringBuilder("Sumit"), 90);
            sb.Add(new StringBuilder("Meet"), 90);
            sb.Add(new StringBuilder("Amita"), 90);
            sb.Add(new StringBuilder("Nameeta"), 90);

            foreach (var kv in sb)
                Console.WriteLine(kv.Key + "===>" + kv.Value);
        }
    }


}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyWork
{
    //List
    class Collectionn
    {
        static void Main(string[] args)
        {                                                             

            List<int> lst = new List<int>();
            lst.Add(100);
            lst.Add(200);
            lst.Add(300);
            lst.Add(400);
            lst.Add(500);
            lst.Add(300);
            lst.Add(300);
            lst.Add(300);
            lst.Add(300);
            lst.Remove(300);

            lst[0] = 1000;
            Console.WriteLine(lst.Count);
            Console.WriteLine(lst.Capacity);

            for (int i = 0; i < lst.Count; i++)
                Console.WriteLine(lst[i]);

            /*foreach (int data in lst)
                Console.WriteLine(data);
            lst.Clear();*/
            Console.WriteLine((lst.Contains(90)));

            Console.WriteLine("indexof" + lst.IndexOf(390));
            List<int> lst2 = new List<int>() { 111, 112, 113 };
            lst.InsertRange(1, lst);

            for (int i = 0; i < lst2.Count; i++)
                Console.WriteLine(lst2[i] + " ");
        }
    }

    //linked list
    class Colle2
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();                 

            ll.AddLast(100);
            ll.AddLast(200);
            ll.AddLast(300);
            ll.AddLast(200);

            LinkedListNode<int> nm = ll.Find(200);
            ll.AddBefore(nm, 1000);
            ll.AddAfter(nm, 2000);

            Console.WriteLine(ll.Count);
            Console.WriteLine(ll.Contains(34));
            LinkedListNode<int> x = ll.First;

            LinkedListNode<int> Last = ll.Last;

            ll.Remove(90);

            foreach (int d in ll)
                Console.WriteLine(d);
        }
    }

    //Dictionary
    //1.
    class Colle3
    { 
        static void Main(string[] args)
        {
           Dictionary<string, int> dd = new Dictionary<string, int>();
           dd.Add("nilesh", 90);
           dd.Add("Dhiraj", 90);
           dd.Add("shubham", 93);

           Console.WriteLine(dd["Dhiraj"]);
           dd["nilesh"] = 94;

        }
    }

    //2.
    class Dictionary1
    {
       static void Main(string[] args)
       {
          List<string> ll = new List<string>()
          { "red","pink","blue","red","pink","Yellow","red"};

          Dictionary<string, int> dd = new Dictionary<string, int>();
          foreach (string color in ll)
          {
            if (dd.ContainsKey(color))
            {
                int oldvalue = dd[color];
                dd[color] = oldvalue + 1;

            }
            else
            {
                dd.Add(color, 1);

            }
          }

       }
    }

    //3.
    class Collectiond
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dd = new Dictionary<string, int>();
            dd.Add("nilesh", 90);
            dd.Add("Dhiraj", 90);
            dd.Add("shubham", 93);
            dd.Add("Raj", 93);
            ICollection<string> cc = dd.Keys;

          foreach(string k in cc)
                Console.WriteLine(k);

          foreach(KeyValuePair<string,int>kv in dd)
                Console.WriteLine(kv.Key+"==>"+kv.Value);
        }
    }

    //4.
    class collD
    {
        static void Main(string[] args)
        {
            List<string> ll=new List<string>()
            { "red","pink","blue","red","pink","Yellow","red"};

            string colorTodeleted = "red";
            ll.Remove(colorTodeleted);

            while(true)
            {
                int idx = ll.IndexOf(colorTodeleted);
                if (idx != -1)
                    ll.RemoveAt(idx);
                else
                    break;
            }
        }
    }

    //5.

    class cDictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dd = new Dictionary<string, string>();
            dd.Add("Nilesh", "Java");
            dd.Add("Dhiraj","Csharp");
            dd.Add("shubham","Csharp");
            dd.Add("Raj","Java");
            dd.Add("shubhangi", "Python");
            dd.Add("Rani", "Python");

            Dictionary<string, List<string>> d2 = new Dictionary<string, List<string>>();
            //"Java"=>[Nilesh]
            //"Csharp"=>[Dhiraj]

            foreach(KeyValuePair<string,string> kv in dd)
            {
                string sname = kv.Key;
                string courseName = kv.Value;
                if(d2.ContainsKey(courseName))
                {
                    List<string> l2 = d2[courseName];
                    l2.Add(sname);
                    d2[courseName] = l2;
                }
                else
                {
                    List<string> lst = new List<string>();
                    lst.Add(sname);
                    d2.Add(courseName, lst);
                }
            }
        }
    }

    //Stack
    class DemoStack
    {
        static void Main(string[] args)
        {
            Stack<string> st = new Stack<string>();
            st.Push("A");
            st.Push("B");
            st.Push("C");
            st.Push("D");

            //st.Clear();
            string[] arr = new string[st.Count];
            st.CopyTo(arr, 0);
            foreach(string d in arr)
                Console.WriteLine(d);

            string dataremove = st.Pop();
            foreach (string d in st)
                Console.WriteLine(d);

            string datapeek = st.Peek();
            Console.WriteLine("Peek "+datapeek);

            foreach(string d in st)
                Console.WriteLine(d);

        }
    }

    //Queue

    class DemoQueue
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(100);
            q.Enqueue(200);
            q.Enqueue(300);
            q.Enqueue(400);
            q.Enqueue(500);

           // int remove = q.Dequeue();
            //q.Clear();

            int[] arr = new int[q.Count];
            q.CopyTo(arr,0);
            foreach (int d in q)
                Console.WriteLine(d);

            foreach (int d in q)
                Console.WriteLine(d);
        }
    }

    //

    class Emmp:IComparable<Emmp>
    {
        int eno;
        string name;
        string depname;
        public Emmp(int eno, string name, string depname)
        {
            this.Eno = eno;
            this.Name = name;
            this.Depname = depname;
        }

        public int CompareTo(Emmp other)
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


    //Sorted List
    class Stud:IComparable<Stud>
    {
        string name;
        long mobileno;
        int percent;

        public Stud(string name, long mobileno, int percent)
        {
            this.name = name;
            this.mobileno = mobileno;
            this.percent = percent;
        }

        public string Name { get => name; set => name = value; }
        public long Mobileno { get => mobileno; set => mobileno = value; }
        public int Percent { get => percent; set => percent = value; }

        public int CompareTo(Stud other)
        {
            return this.name.CompareTo(other.name);
        }

        public override string ToString()
        {
            return " name: "+name+"  mobileno: "+mobileno+"  percent: "+percent;
        }
    }
    class demoStud
    {
        static void Main(string[] args)
        {
            SortedList<Stud, string> ss = new SortedList<Stud, string>();
            ss.Add(new Stud("Raj", 998877656, 82), "Java");
            ss.Add(new Stud("Ovi", 9988776511, 58), "Java");
            ss.Add(new Stud("Radha", 998877666, 80), "Java");
            ss.Add(new Stud("Trisha", 998777656, 98), "Java");
            ss.Add(new Stud("Piya", 998277656, 45), "Java");
            ss.Add(new Stud("Diya", 997877656, 78), "Java");

           /* Console.WriteLine("deepa".CompareTo("Pratiksha"));
            Console.WriteLine("Pratiksha".CompareTo("deepa"));*/

            foreach(KeyValuePair<Stud,string> kv in ss)
                Console.WriteLine(kv.Key+"===>"+kv.Value);

            SortedList<Stud, string> ss2 = new SortedList<Stud, string>();
            ss2.Add(new Stud("riya",3434344344, 65), "MR A");
        }
    }

    //StringBuilder in sorted List

    class myStringBuilderSort : IComparer<StringBuilder>
    {
        public int Compare(StringBuilder x, StringBuilder y)
        {
            return x.ToString().CompareTo(y.ToString());
        }
    }

    class DemoSSS
    {
        static void Main(string[] args)
        {
            StringBuilder ss = new StringBuilder("Amit");
            SortedList<StringBuilder, int> sb = new SortedList<StringBuilder, int>(new myStringBuilderSort());
            sb.Add(ss, 90000);
            sb.Add(new StringBuilder("Amit"), 90000);
            sb.Add(new StringBuilder("Sumit"), 90000);
            sb.Add(new StringBuilder("Meet"), 90000);
            sb.Add(new StringBuilder("Amita"), 90000);
            sb.Add(new StringBuilder("Nameeta"), 90000);

            //ss.Append("Shah");
            foreach(KeyValuePair<StringBuilder,int> kv in sb)
                Console.WriteLine(kv.Key+"===>"+kv.Value);

            Dictionary<StringBuilder, int> dd = new Dictionary<StringBuilder, int>(sb);

        }
    }

    //Hashset

    class DemoHashset
    {
        static void Main(string[] args)
        {
            HashSet<String> hs1 = new HashSet<String>() { "Om", "Raj", "Ram", "Siya" };
            HashSet<String> hs2 = new HashSet<String>() { "Omkar", "Raja", "Ram", "Siya" };

            //Union,Intersection

           //HashSet<String> h3 = hs1.Intersect(hs2).ToHashset();
            hs1.IntersectWith(hs2);
            hs1.UnionWith(hs2);

            bool b1 = hs1.IsSubsetOf(hs2);
            bool b2 = hs1.IsSupersetOf(hs2);

            foreach(string d in hs1)
                Console.WriteLine(d+" ");

            Console.WriteLine();

            foreach(string d in hs2)
                Console.WriteLine(d+" ");

           /* Console.WriteLine();
            foreach(string d in h3)
                Console.WriteLine(d+" ");
            hs1.IntersectWith(hs2);*/
        }
    }
}

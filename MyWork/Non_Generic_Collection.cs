using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace MyWork
{

    class SS<T>
    {
        private T obj;
        public T Obj { get =>obj; set => obj = value; }
    }
    class S
    {
        private Object obj;
        public Object Obj { get => obj; set => obj = value; }
    }

    class Testt
    {
        static void Main(string[] args)
        {
            SS<float> s1 = new SS<float>();
            s1.Obj = 4.5f;
            float d = s1.Obj;

            S s = new S();
            s.Obj = "Omkar";
            s.Obj = 9000;

            int x = (int)s.Obj;
        }
    }


    //Demo of Generic and Non generic

    //Non Generic
    class K
    {
        private object ob;
        public object Ob { get => ob; set => ob = value; }
    }

    //generic
    class KK<T>
    {
        private T ob;
        public T Ob { get => ob; set => ob = value; }
    }

    class TTestt
    {
        static void Main(string[] args)
        {
            KK<string> obj = new KK< string > ();
            obj.Ob = "hello";
            string s = obj.Ob;

            K k = new K();
            k.Ob = "Welcome";
            k.Ob = 90;

            int m = (int)k.Ob;
        }
    }

    //demo Non generic 

    class DemoNonGeneric
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>() { 1, 2, 3, 4 };

            ArrayList al = new ArrayList(lst);
            Hashtable ht = new Hashtable();
            ht.Add(90, "A");
            ht.Add("Om", 890);
            ht.Add(9.4f, 78);
            ht.Add(new Emmp(12,"Ashu","IT"),01);

            foreach(DictionaryEntry kv in ht)
            {
                Console.WriteLine(kv.Key+"==>"+kv.Value);
            }

            SortedList sl = new SortedList();
            sl.Add("ora", "oracle");
            sl.Add("vb", 90);
            sl.Add("cs", 7.8f);
            // sl.Add(90, "asp.net");
            foreach (DictionaryEntry kv in sl)
                Console.WriteLine(kv.Key + "==>" + kv.Value);

        }
    }

    //
    class  demo2
    {
        static void Main(string[] args)
        {
           
            ArrayList al = new ArrayList();
            
            al.Add(12);
            al.Add("omkar");
            al.Add(true);
            al.Add(new StringBuilder("Siya"));

            foreach(object ob in al)
                Console.WriteLine(ob);

            for(int i=0;i<al.Count;i++)
                Console.WriteLine(al[i]);

            //String s = (string)al[2];
        }
    }
}

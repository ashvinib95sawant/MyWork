using System;
using System.Collections.Generic;
using System.Text;

namespace MyWork
{
    class StrBld
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello");
            Console.WriteLine(sb);
            sb.Append("c#");
            Console.WriteLine(sb);

            sb.Insert(3, "Pune");
            Console.WriteLine(sb);

            StringBuilder sb1 = new StringBuilder("Hello");
            StringBuilder sb2 = new StringBuilder("Hello");

            Console.WriteLine(sb1==sb2);
            Console.WriteLine(sb1.Equals(sb2));
            sb.Remove(3, 2);
            Console.WriteLine(sb);
        }
    }
}

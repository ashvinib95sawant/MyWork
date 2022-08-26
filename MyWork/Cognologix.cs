using System;
using System.Collections.Generic;
using System.Text;

namespace MyWork
{

    //Find vovels count
    class Cognologix
    {
        static void Main(string[] args)
        {
            string str = " Hello World";
            char[] c = str.ToCharArray();
            bool flag = false;
            int count = 1;
            for (int i = 0; i < c.Length; i++)
            {
                for (int k = i - 1; k >= 0; k--)
                {
                    if (c[i] == c[k])
                    {
                        flag = true;
                        break;

                    }
                }
                if (flag == false)
                {
                    for (int j = i + 1; j < c.Length; j++)
                    {
                        if (c[i] == c[j])
                            count++;
                    }
                    Console.WriteLine(c[i] + " " + count);
                    if (c[i] == ('a') || c[i] == ('e') || c[i] == ('i') || c[i] == ('o') || c[i] == ('u'))
                        Console.WriteLine(c[i] + " " + count);
                    foreach (char p in c)
                    {


                        
                    }

                }
                Console.WriteLine(c[i] + " " + count);
            }
        }
    }

   /*
    input: Ashvini Balu Sawant
   output: Ashvini_Balu_Sawant
    */
    class Ashvini
    {
        static void Main(string[] args)
        {
            string str = "Ashvini Balu sawant";
            string[] s = str.Split(" ");
            char[] ch1 = str.ToCharArray();


            foreach (string ss in s)
                Console.Write(ss + "_");
            Console.WriteLine(".......................");
            foreach (char c in ch1)
            {
                if (c == ' ')
                {
                    Console.Write('_');
                }
                else
                    Console.Write(c);
            }
        }
    }


    //Find occurrence of each element in array
    class Ashu
    {
        static void Main(string[] args)
        {
            int[] s = { 1, 2, 3, 4, 5, 8, 4, 2, 9, 4 };
            for (int i = 0; i < s.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (s[k] == s[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (s[i] == s[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(s[i] + " " + count);
                }
            }
        }
    }
}

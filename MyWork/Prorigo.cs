using System;
using System.Collections.Generic;
using System.Text;

namespace MyWork
{
    //1.Find Largest subarray length have equal zero and one 
    class subarray
    {
        static void Main(string[] args)
        {
            //Accept Size
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            //Accept data
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            int j;
            int max = 0;
            int zero, ones;

            

            for (int i = 0; i < arr.Length; i++)
            {
                zero = 0;
                ones = 0;
                for (j = i; j < arr.Length; j++)
                {
                    if (arr[j] == 0)
                        zero++;
                    else
                        ones++;

                    if (zero == ones)
                    {
                        max = max > (j - i + 1) ? max : j - i + 1;
                    }
                }

            }
            Console.WriteLine(max);
        }
    }

    class Cuckoo
    {
        int coo(int s)
        {
            if (s == 1)
            {
                s = 0;
            }
            if (s == 2)
            {
                s = 1;
            }

            return s;
        }
        static void Main(string[] args)
        {


            Cuckoo ck = new Cuckoo();
            int n = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            //int cu1 = 0;
            //int cu2 = 1;

            if (n == 1)
            {
                Console.WriteLine("0");
            }
            else if (n == 2)
            {
                Console.WriteLine("1");

            }
            else if (n > 2)
            {
                c = 1 * ck.coo(n - 1) + 2 * ck.coo(n - 2) + 3 * 1;

                Console.WriteLine(c);
            }
        }
    }

    //3.Arithmatic Progression
    class ArithmeticP
    {
        static void Main(string[] args)
        {
            
            int a2 = int.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());
            int d = a3 - a2;

            for (int i = 4; i <= n; i++)
            {
                a3 = a3 + d;

            }
            Console.WriteLine(a3);
        }
    }

    //4.find the number of coPrime of given number
    class CoPrime
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            int gcd = 0;
            int c = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0 && n % j == 0)
                    {
                        gcd = j;
                    }
                }
                if (gcd == 1)
                {
                    c++;
                }

            }
            Console.WriteLine("Number of CoPrime number" + c);

        }
    }

    //5.String Anagram
    class StringAnagram
    {
        public static bool Check(string str1, String str2)
        {
            if (str1.Length == str2.Length)
            {
                string s1 = str1.ToLower();
                string s2 = str2.ToLower();
                char[] ch1 = s1.ToCharArray();
                char[] ch2 = s2.ToCharArray();
                //sorting logic
                Array.Sort(ch1);
                Array.Sort(ch2);
                string st1 = new string(ch1);
                string st2 = new String(ch2);

                if (st1 == st2)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {


                return false;
            }
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st string");
            string str1 = Console.ReadLine();
            Console.WriteLine("enter 2nd string");
            string str2 = Console.ReadLine();

            bool isAnagram = StringAnagram.Check(str1, str2);

            if (isAnagram == true)
            {
                Console.WriteLine("String is Anagram");
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }



        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MyWork
{

   /*  2.	Write a program to merge two sorted array of number such that
     new array is sorted array and there should be no duplicate in new array.[1M]*/


    class MergeArray
    {

        static void Main(string[] args)
        {
            int[] a = { 111, 22, 313, 4 };
            int[] b = { 101, 12, 33, 103, 104, 22 };
            int[] c = new int[a.Length + b.Length];

            Array.Sort(a);
            Array.Sort(b);

            int j = 0;
            for (int i = 0; i < a.Length; i++)
            {
                c[j] = a[i];
                j++;
            }
            for (int i = 0; i < b.Length; i++)
            {
                bool isPresent = false;
                for (int k = j - 1; k >= 0; k--)
                {
                    if (c[k] == b[i])
                    {
                        isPresent = true;
                        break;
                    }
                }
                if (isPresent == false)
                {

                    c[j] = b[i];
                    j++;
                }
            }

            Console.WriteLine(string.Join(" ", a));
            Console.WriteLine();
            Console.WriteLine(string.Join(" ", b));
            Console.WriteLine("////////////////////");

            Array.Sort(c);

            for (int i = 1; i <= j; i++)
            {
                Console.Write(c[i] + " ");
            }
            Console.WriteLine();
           
            Console.WriteLine(".....................");

        }
    }


    /*3. Assume that there is already  list of members of Society Member{memberid,Wing_flatNo,name}.
    Write a program which creates Dictionary where key is Wing_FlatNo and
    value is List of all  names of family members [1M]*/

    class Society_Member : IComparable<Society_Member>
    {
        int member_id;
        string wing;
        int flat_No;

        public Society_Member(int member_id, string wing, int flat_No)
        {
            this.member_id = member_id;
            this.wing = wing;
            this.flat_No = flat_No;
           
        }
        
        public int Member_id { get => member_id; set => member_id = value; }
        public string Wing { get => wing; set => wing = value; }
        public int Flat_No { get => flat_No; set => flat_No = value; }

        public override string ToString()
        {
            return "Member_id: " + Member_id + " Wing: " + Wing + " Flat_No: " + Flat_No;
        }

        public int CompareTo(Society_Member other)
        {
            return other.Wing.CompareTo(this.Wing);
        }
    }

    class MemDic9
    {
        static void Main(string[] args)
        {
            Dictionary<Society_Member, string> d1 = new Dictionary<Society_Member, string>();
            d1.Add(new Society_Member(101, "Aboli", 111), "Shital, Mahesh, Varsha");
            d1.Add(new Society_Member(102, "Jaswandi", 112), "Kavya, Shivanya, Jeevan");
            d1.Add(new Society_Member(103, "Jai", 113), "Raj, Neetu, Sanavi");


            foreach (KeyValuePair<Society_Member, string> jp in d1)
                Console.WriteLine(jp.Key + "===>" + jp.Value);
        }
    }

    /*4.	Given two LinkedList, we need to combine two LinkedList  in such a way that
    the combined a List has alternate elements of both. If one list has extra element,
    then these elements are appended at the end of the combined list.[1M]

          Input : list1 = {1, 2, 3, 4, 5, 6}
          List2 = { 11, 22, 33, 44}
          List3: { 1, 11, 2, 22, 3, 33, 4, 44, 5, 6}*/

    class Merge_Linked_List
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddLast(100);
            ll.AddLast(200);
            ll.AddLast(300);

            LinkedList<int> l2 = new LinkedList<int>();
            ll.AddLast(101);
            ll.AddLast(202);
            ll.AddLast(303);

            LinkedList<int> l3 = new LinkedList<int>();


        }
    }




  /*  5.	Reverse middle words of a string [1M]
  Given a string str, print reverse all words except the first and last words.

  Examples:
           Input  : Hi how are you students
           Output  : Hi woh era uoy students
           Input : I am fine
           Output : I ma fine */

    class Bet_Word_reverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            string[] s = str.Split(" ");
            string revers = "";
            for (int i = 0; i < s.Length; i++)
            {
                string word = s[i];
                string wordrevers = "";
                if (i > 0 && i < s.Length - 1)
                {
                    for (int j = word.Length - 1; j >= 0; j--)
                    {
                        wordrevers = wordrevers + word[j];
                    }
                    revers = revers + wordrevers + " ";
                }
                else
                {
                    revers = revers + s[i] + " ";
                }
            }
            Console.WriteLine(revers);
        }
    }

    //6.	WAP to  Reverse a linked list using Stack. [1M]


    //7. WAP to find out frequency of each digit in given mobile number using only single loop. [1M]
    class freqstringg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a mobile number");
            string st = Console.ReadLine();
            char[] ch = st.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (ch[k] == ch[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < ch.Length; j++)
                    {
                        if (ch[i] == ch[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(ch[i] + " " + count);
                }
            }
        }
    }

    /*  8.	WAP to accept a string and make following changes[1M]
        •	Shift each letter right by two step eg A ->C ,Y->A,Z->B
        •	Each digit by next higher digit.
        •	Space by underscore */


    class Changes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();

            string[] s = str.Split(" ");

            for(int i=0;i<=str.Length;i++)
            {
                for (char ch= 'A'; ch <= 'Z'; ch++)
                {
                   
                }
            }
        }
    }

    /* 9.	WAP to draw the following pattern using . Note: Input is an odd number: [1M]*
    12345
    ABCD
    123
    AB
    1
    AB
    123
    ABCD
    12345
    */

    class MixPat
    {
        static void Main(string[] args)
        {
           
            for (int r = 5; r >= 1; r--)
            {
                char ch = 'A';
                for (int c = 1; c <= r; c++)
                { 
                    if (r % 2 != 0)
                    {
                        Console.Write(c);
                    }
                    else
                    {
                        Console.Write(ch);
                        ch++;
                    }
                    
                }
                Console.WriteLine();

            }

            for (int r = 1; r <= 5; r++)
            {
                 char ch = 'A';
                for (int c = 1; c <= r; c++)
                {
                    if (r % 2 != 0)
                    {
                        Console.Write(c);
                    }
                    else
                    {
                        Console.Write(ch);
                        ch++;
                    }

                }
                Console.WriteLine();
            }
        }
    }


    /* 10.	WAP to accept a number and check whether it is binary or not.
         If not  throw custom exception InvalidBinaryNumber.[1M]  */
    class InvalidNumberException : ApplicationException
    {
        public InvalidNumberException(string message) : base(message)
        {

        }
        
    }

    class Bin_num : Object
    {
        int n;

        public int N { get => n; set => n = value; }

        public override string ToString()
        {
            return "Number: " + n;
        }
        public int Binary_numberr
        {
            set
            {
                while (n != 0)
                {
                    int last = n % 10;

                    if (last > 1)
                    {
                        throw new InvalidNumberException("This number is not binary number");
                    }
                    else
                        this.n = value;
                    n = n / 10;
                }
               
            }
            get { return n; }
        }

       
    }

    class class1119
    {
        static void Main(string[] args)
        {
            Bin_num e1 = new Bin_num();
            Console.WriteLine("enter binary number");
            e1.N =int.Parse( Console.ReadLine());
            try
            {
                e1.N = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Entered Number is not binary number");
            }
            Console.WriteLine(e1);
        }
    }
   
    
}

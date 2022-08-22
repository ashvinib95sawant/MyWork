using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace MyWork
{
    /*
     1.	An IMEI number/ International Mobile Station Equipment Identity is a 15 digit number and it is
    said to be IMEI number if and only if the sum of the number is exactly divisible by 10.	 [1M]

    The IMEI (15 decimal digits: 14 digits plus a check digit) includes information on the origin,
    model, and serial number of the device.

    The IMEI number is used by a GSM network to identify valid devices and therefore can be used for 
    stopping a stolen phone from accessing that network

    The IMEI is validated in following steps:
    1.	Starting from the rightmost digit, double the value of every second digit (e.g., 7 becomes 14).
    2.	If doubling of a number results in a two digits number i.e greater than 9(e.g., 7 × 2 = 14), then
        add the digits of the product (e.g., 14: 1 + 4 = 5), to get a single digit number.
    3.	Now take the sum of all the digits.
    4.	Check if the sum is divisible by 10 i.e.(total modulo 10 is equal to 0) then
        the IMEI number is valid; else it is not valid.

     Input IMEI : 490154203237518

     Output : Since, 60 is divisible by 10, hence the given IMEI number is Valid.

     */
    class IMEI
    {

        // Function for finding and
        // returning sum of digits
        // of a number
        static int sumDig(int n)
        {
            int a = 0;
            while (n > 0)
            {
                a = a + n % 10;
                n = n / 10;
            }

            return a;
        }

        static Boolean isValidIMEI(long n)
        {

            // Converting the number into
            // String for finding length
            String s = n.ToString();
            int len = s.Length;

            if (len != 15)
                return false;

            int sum = 0;
            for (int i = len; i >= 1; i--)
            {
                int d = (int)(n % 10);

                // Doubling every alternate
                // digit
                if (i % 2 == 0)
                    d = 2 * d;

                // Finding sum of the digits
                sum += sumDig(d);
                n = n / 10;
            }

            return (sum % 10 == 0);
        }

        // Driver code
        public static void Main()
        {

            // 15 digits cannot be stored in
            // 'int' data type
            long n = 490154203237518L;

            if (isValidIMEI(n))
                Console.Write("Valid IMEI Code");
            else
                Console.Write("Invalid IMEI Code");

        }
    }

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

    class Member1
    {
        int member_id;
        string wing_FlatNo;
        string name;

        public int Member_id { get => member_id; set => member_id = value; }
        public string Wing_FlatNo { get => wing_FlatNo; set => wing_FlatNo = value; }
        public string Name { get => name; set => name = value; }

        public Member1(int member_id, string wing_FlatNo, string name)
        {
            this.Member_id = member_id;
            this.Wing_FlatNo = wing_FlatNo;
            this.Name = name;
        }

        public override string ToString()
        {
            return "Member_id: " + Member_id + " Wing_FlatNo: " + Wing_FlatNo + " Name: " + Name;
        }

        
    }

    class MemDic9
    {
        static void Main(string[] args)
        {
            List<Member1> slist = new List<Member1>();
            slist.Add(new Member1(1,"B-405","Ashvini"));
            slist.Add(new Member1(2, "B-406", "Amar"));
            slist.Add(new Member1(3, "B-407", "Akbar"));
            slist.Add(new Member1(4, "B-408", "Amit"));
            slist.Add(new Member1(5, "B-409", "Ajay"));
            slist.Add(new Member1(6, "B-410", "Akshay"));

            Dictionary<string, List<Member1>> dd = new Dictionary<string, List<Member1>>();

            foreach(Member1 m in slist)
            {
                if(dd.ContainsKey(m.Wing_FlatNo))
                {

                }
                else
                {
                    List<Member1> mlist = new List<Member1>();
                    mlist.Add(m);
                    dd.Add(m.Wing_FlatNo, mlist);
                }
            }


            foreach (KeyValuePair<string, List<Member1>> kv in dd)
            {
                Console.WriteLine("FlatNo : " +kv.Key);
                foreach(Member1 m in kv.Value)
                {
                    Console.WriteLine(m);
                }
            }
                
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
            LinkedList<int> l1 = new LinkedList<int>();
            l1.AddLast(1);
            l1.AddLast(2);
            l1.AddLast(3);
            l1.AddLast(4);
            l1.AddLast(5);
            l1.AddLast(6);

            LinkedList<int> l2 = new LinkedList<int>();
            l2.AddLast(11);
            l2.AddLast(22);
            l2.AddLast(33);
            l2.AddLast(44);

            LinkedList<int> l3 = new LinkedList<int>();
            int i = 0;
            int k = 0;
            while(l3.Count<l1.Count+l2.Count)
            {
                /*if(k<l1.Count&&k<l2.Count)
                {
                    l3.AddLast(l1.ElementAt(k));
                    l3.AddLast(l2.ElementAt(k));
                    k++;
                }
                else if(k<l1.Count)
                {
                    l3.AddLast(l1.ElementAt(k));
                    k++;
                }
                else
                {
                    l3.AddLast(l2.ElementAt(k));
                    k++;
                }
                i++;*/
            }
            foreach(int d in l1)
            {
                Console.WriteLine(d+" ");
            }
            Console.WriteLine("_________________");
            foreach (int d in l2)
            {
                Console.WriteLine(d + " ");
            }
            Console.WriteLine("_________________"); 
            foreach (int d in l3)
            {
                Console.WriteLine(d + " ");
            }
            Console.WriteLine("_________________");

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

    class Rev_ll
    {

        // Driver Code
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddNode(new LinkedList.Node(85));
            list.AddNode(new LinkedList.Node(15));
            list.AddNode(new LinkedList.Node(4));
            list.AddNode(new LinkedList.Node(20));

            // List before reversal
            Console.WriteLine("Given linked list:");
            list.PrintList();

            // Reverse the list
            list.ReverseList();

            // List after reversal
            Console.WriteLine("Reversed linked list:");
            list.PrintList();
        }
    }

    class LinkedList
    {
        Node head;

        public class Node
        {
            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        // function to add a new node at
        // the end of the list
        public void AddNode(Node node)
        {
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }

        // function to reverse the list
        public void ReverseList()
        {
            Node prev = null, current = head, next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }

        // function to print the list data
        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }

    //7. WAP to find out frequency of each digit in given mobile number using only single loop. [1M]
    class freqstringg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a mobile number");
            string st = Console.ReadLine();
            char[] ch = st.ToCharArray();

            Dictionary<char,int> dd = new Dictionary<char, int>();

            foreach (char c in ch)
            {
                if (dd.ContainsKey(c))
                {
                    int oldval = dd[c];
                    dd[c] = oldval + 1;
                }
                else
                {
                    dd.Add(c, 1);
                }

            }
            foreach (KeyValuePair<char, int> kv in dd)
                Console.WriteLine(kv.Key + "==>" + kv.Value);
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

            int step = 2;
            int newchar = 0;

            foreach (char ch in str)
            {
                if (char.IsLetter(ch))
                {
                    newchar = ch + step;
                    if (newchar > 90)
                        newchar = newchar - 26;
                }
                else if(char.IsDigit(ch))
                {
                    newchar = ch;
                    newchar++;
                }
                else if(ch ==' ')
                    newchar=('_');

                Console.Write((char)newchar);

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

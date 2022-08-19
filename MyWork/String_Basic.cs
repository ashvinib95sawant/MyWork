using System;
using System.Collections.Generic;
using System.Text;

namespace MyWork
{
    //string creation
    class string_Creation
    {
        static void Main(string[] args)
        {
            string s = "Hello";//Literal

            char[] ch = { 'H', 'E', 'L', 'L', 'O' };

            String str = new string("Hello");//USING NEW KEYWORD
            Console.WriteLine(str.GetHashCode());
            string s2 = "Hello";
            Console.WriteLine(s.GetHashCode()+" "+s2.GetHashCode());

            s = s + "Pune";
            Console.WriteLine(s+" "+s2);

            Console.WriteLine(s.GetHashCode()+" "+s2.GetHashCode());
        }
    }

    //string methods

    class methods_Demo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            int l = str.Length;
            Console.WriteLine("Number of char "+l);
            Console.WriteLine("................................");

            string capital = str.ToUpper();
            Console.WriteLine(capital);
            Console.WriteLine(".................................");

            string small = capital.ToLower();
            Console.WriteLine(small);
            Console.WriteLine("..................................");

            int index = str.IndexOf('i');
            Console.WriteLine(index);
            int last = str.LastIndexOf('i');
            Console.WriteLine(last);
            Console.WriteLine(".................................");

            string sub1 = str.Substring(4);
            Console.WriteLine(sub1);
            Console.WriteLine("....................................");

            string sub2 = str.Substring(4, 6);
            Console.WriteLine(sub2);
            Console.WriteLine("......................................");

            char[] ch = str.ToCharArray();
            foreach(char c in ch)
            {
                Console.Write(c+" ");
            }
            Console.WriteLine();
            Console.WriteLine("....................................");

            string[] word = str.Split(" ");
            for(int i=0;i<word.Length;i++)
            {
                Console.WriteLine(word[i]+" ");
            }
        }
    }

    //compare method of string

    class c_method
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 = "hello";

            Console.WriteLine(s1==s2);

            Console.WriteLine(s1.Equals(s2));

            string str = "       Hello   ";
            Console.WriteLine(str+"@");
            Console.WriteLine(str.Trim());
            Console.WriteLine(str.TrimEnd()+"#");

            Console.WriteLine(s1.Replace('l','g'));
        }
    }

    //reverse string

    class s_Reverse
    {
        static void Main(string[] args)
        {
            string str = "india is my country";
            char[] ch = str.ToCharArray();
            string revers = "";
            for (int i = ch.Length-1; i >=0; i--)
            {
                revers = revers + ch[i];
            }
            Console.WriteLine(revers);
        }
    }

    //Reverse each word of string

    class Word_rev
    {
        static void Main(string[] args)
        {
            string str = "India is my country";
            string[] s = str.Split(" ");
            string revers = "";
            for (int i =0; i <s.Length; i++)
            {
                string word = s[i];
                string wordrevers = "";
                for (int j = word.Length - 1; j >= 0; j--)
                {
                    wordrevers = wordrevers+word[j];
                }
                revers = revers + wordrevers + " ";
            }
            Console.WriteLine(revers);
        }
    }

    //Reverse string except 1st and 2nd word

    class Bet_Word_revers
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
                    revers = revers + s[i]+" ";
                }
            }
            Console.WriteLine(revers);
        }
    }


    //Add digits present in the string

    class Digits_sum
    {
        public int Sum_Of_Digits(string str)
        {
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    int x = (int)(char.GetNumericValue(str[i]));
                    sum = sum + x;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Digits_sum d = new Digits_sum();
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            int ans = d.Sum_Of_Digits(s);
            Console.WriteLine(ans);
        }
    }

    //write a code to perform average of digits from the string

    class Digits_avg
    {
        public int Avg_Of_Digits(string str)
        {
            int sum = 0;
            int count=0;
            
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    int x = (int)(char.GetNumericValue(str[i]));
                    count++;
                     sum =( sum + x);
                }
            }
            int avg = sum / count;
            return avg;
        }
        static void Main(string[] args)
        {
            Digits_avg d = new Digits_avg();
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            int ans = d.Avg_Of_Digits(s);
            Console.WriteLine(ans);
        }
    }

    //Check string is Palindrome or not

    class plmstring
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string st2 = Console.ReadLine();

            string rev = "";
            int j = st2.Length - 1;

            while (j >= 0)
            {
                rev = rev + st2[j];
                j--;
            }
            if (st2 == rev)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not palindrome");
        }
    }

    //Write a program to print string in pattern format
    class Pattern_string
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            string[] s = str.Split(" ");
            for (int r = 0; r < s.Length; r++)
            {
                for (int c = 0; c <= r; c++)
                {
                    Console.Write(s[c]+" ");

                }
                Console.WriteLine();
            }
        }
    }
    

    //Toggle case(Convert upper case to lower case and vice versa)

    class Togglecase
    {
        public string makeToggle(string str)
        {
            string tcase = "";
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i]>='A'&&str[i]<='Z')
                {
                    tcase = tcase + ((char)(str[i] + 32));
                }
                else if((str[i] >= 'a' && str[i] <= 'z'))
                {
                    tcase = tcase + ((char)(str[i] - 32));
                }
                else
                {
                    tcase = tcase + str[i];
                }
            }
            return tcase;
        }
        static void Main(string[] args)
        {
            Togglecase t = new Togglecase();
            Console.WriteLine("enter the string");
            string s = Console.ReadLine();
            string toggle = t.makeToggle(s);
            Console.WriteLine(toggle);
        }
    }

    //
    class Toggle_case
    {
        public string make_Toggle(string str)
        {
            string tcase = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    tcase = tcase + char.IsLower(str[i]);
                }
                else if (char.IsLower(str[i]))
                {
                    tcase = tcase + char.IsUpper(str[i]);
                }
                else
                {
                    tcase = tcase + str[i];
                }
            }
            return tcase;
        }

        static void Main(string[] args)
        {
            Toggle_case t = new Toggle_case();
            Console.WriteLine("enter the string");
            string s = Console.ReadLine();
            string toggle = t.make_Toggle(s);
            Console.WriteLine(toggle);
        }
    }



    //Frequency of each character in string
    class freq_Of_char_string
    {
        static void Main(string[] args)
        {
            string st = "India is my country";
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
}


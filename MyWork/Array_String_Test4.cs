using System;
using System.Collections.Generic;
using System.Text;

namespace MyWork
{ 
    //1.write a program to find the duplicate words and their number of occurences in a string.
    class Dupli_Words
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            string[] s = str.Split(" ");

            for (int i = 0; i < s.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (s[i] == s[k])
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
                    if (count > 1)
                    {
                        Console.WriteLine(s[i] + " " + count);
                    }
                }



            }


        }
    }


    //2.Write a program to count number of words in a string
    class Number_Of_words
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            string[] s = str.Split(" ");

            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {

                count++;
            }
            Console.WriteLine(count);
        }
    }

    // Write a program to count frequency of each word in string

    class freq_Of_word_string
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            string[] s = str.Split(" ");

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

  //3.Write a program to check string is anagram or not
    class String_Anagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string 1");
            string str1 = Console.ReadLine();
            Console.WriteLine("enter a string 2");
            string str2 = Console.ReadLine();

            string st1 = str1.ToLower();
            string st2 = str2.ToLower();

            if (st1.Length == st2.Length)
            {

                char[] ch1 = st1.ToCharArray();
                char[] ch2 = st2.ToCharArray();
                char tmp, tmp1;
                //sorting logic
                for (int i = 0; i < ch1.Length; i++)
                {
                    for (int j = i + 1; j < ch1.Length; j++)
                    {
                        if (ch1[i] > ch1[j])
                        {
                            tmp = ch1[i];
                            ch1[i] = ch1[j];
                            ch1[j] = tmp;
                        }
                    }
                }

                for (int i = 0; i < ch2.Length; i++)
                {
                    for (int j = i + 1; j < ch2.Length; j++)
                    {
                        if (ch2[i] > ch2[j])
                        {
                            tmp1 = ch2[i];
                            ch2[i] = ch2[j];
                            ch2[j] = tmp1;
                        }
                    }
                }

                // Array.Sort(ch1);
                // Array.Sort(ch2);
                string s1 = ch1.ToString();
                string s2 = ch2.ToString();

                if (s1 == s2)
                {
                    Console.WriteLine("Anagram");
                }
                else
                {
                    Console.WriteLine("Not anagram");
                }

            }
            else
            {


                Console.WriteLine("Not anagram");
            }
        }
    }

    //4. Create an array of 10 names and sort in descending order

    class Names_desc
    {
        static void Main(string[] args)
        {
            string[] names = new string[10];
            Console.WriteLine("Enter 10 names in array");
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = (Console.ReadLine());
            }

            Array.Sort(names);
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("Desc Orderd List");
            for (int i = names.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }

        }

    }

    //5.Write a program to find total number of alphabets, digits or special characters in a string

    class freq_Of_char_num_SpecialChar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;

            for (int i = 0; i < ch.Length; i++)
            {

                if(char.IsLetter(str[i]))
                {
                    count1++;
                }
                else if (char.IsDigit(str[i]))
                {
                    count2++;
                }
                else
                {
                    count3++;
                }
                
            }
            Console.WriteLine("alphabets = " + count1);
            Console.WriteLine("Numbers = " + count2);
            Console.WriteLine("Special characters = "+count3);
        }

    }

    //6.write a program to convert uppercase string to lowercase string

    class upper_Lower
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();

            string c = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    c = c + ((char)(str[i] + 32));
                }
               
                else
                {
                    c = c + str[i];
                }
            }
            Console.WriteLine(c);
        }
    }

    //7.Write a program to print array reverse without using temporary array
    //eg.{12,56,43,98,876,54}
    //output:{54,876,98,43,56,12}

    class Rev_arr
    {
        static void Main(string[] args)
        {
            int[] n = new int[6];
            Console.WriteLine("Enter 6 numbers in array");

            for (int i = 0; i < n.Length; i++)
            {
                n[i] =int.Parse (Console.ReadLine());
            }
            for (int j = 0; j < n.Length; j++)
            {
                Console.Write(n[j] + " ");

            }
            Console.WriteLine();

            for (int i = n.Length-1; i >= 0 ; i--)
            {
                Console.Write(n[i]+" ");
            }
            Console.WriteLine();
        }
    }

    //8. Write a program to merge 2 arrays to 3rd array. 3rd array should not have elements of same value.

    class Merge_2arrays
    {

        static void Main(string[] args)
        {
            int[] a = { 11, 22, 33, 44 };
            int[] b = { 101, 102, 33, 103, 104, 22 };
            int[] c = new int[a.Length + b.Length];
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
            for (int i = 0; i < j; i++)
            {
                Console.Write(c[i] + "     ");
            }
            Console.WriteLine();
            Console.WriteLine(".....................");

        }
    }

    //9.Write a program to sort array in ascending order

    class asc_order
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 76, 23, 54, 09, 18 };
            foreach(int num in arr)
            {
                Console.Write(num+" ");
            }
            Console.WriteLine();

            int tmp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                        
                    }
                }
                Console.Write(arr[i]+" ");
                
            }
        }
    }

    //10.Write a program to replace all the 0's with 1's
    //{26,0,67,45,0,78,54,34,10,0,34}
    
    class Replace_zero_By_One
    {
        static void Main(string[] args)
        {
            int[] arr = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]==0)
                Console.Write("1 ");
                else
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
    

    //11.write a program to replace all negative value with its immidiate left elements square.
    //arr{12,3,-19,29,5,-61,44,7,-9}
    //Output={12,3,9,29,5,25,44,7,49}

    class Replace_Neg
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 3, -19, 29, 5, -61, 44, 7, -9 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    Console.Write(arr[i-1]* arr[i - 1]+" ");
                else
                    Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }

    //12.Write a program to find min character in character array 
    //eg.{'A', 'D','E','x','z','R'}
    //output : A

    class Min_Of_Char
    {
        static void Main(string[] args)
        {
            char[] arr2 = { 'A', 'D', 'E', 'x', 'z', 'R' };
            char min = arr2[0];
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] < min)
                {
                    min = arr2[i];
                }
            }
            Console.WriteLine("min= " + min);
        }
    }

    //13.Write a program to print all unique elements in the array

    class Unique_Element
    {
        static void Main(string[] args)
        {


            int[] a = { 4, 1, 3, 1, 5, 1, 4, 2, 9, 11};

            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (a[i] == a[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                    if (count == 1)
                    {
                        Console.WriteLine(a[i] + " " );
                    }
                }

            }

        }
    }
}

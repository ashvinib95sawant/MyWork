using System;
using System.Collections.Generic;
using System.Text;

namespace MyWork
{
    //sort integer type of array
    class I_sort_array
    {
        public static int[] SortIarray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[] i = { 12,87,34,10,28,24,47,32 };
            int[] c = I_sort_array.SortIarray(i);
            Console.WriteLine(string.Join(" ", c));
            Console.WriteLine();
            // char[]c = C_sot_array.SortCarray(ch);
        }
    }


    //sort character type of array

    class C_sort_array
    {
        public static char[] SortCarray(char []arr)
        {
            for (int i = 0; i< arr.Length;i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if(arr[i]>arr[j])
                    {
                        char temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                  
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            char[] ch = { 'g','f','x','b','n','t' };
            char[] c = C_sort_array.SortCarray(ch);
            Console.WriteLine(string.Join(" ",c));
            Console.WriteLine();
           // char[]c = C_sot_array.SortCarray(ch);
        }
    }

    //prime number in array

    class Prime_From_array
    {
        public static void P_array(int[] arr)
        {
            int count = 0;
            Console.WriteLine("Prime numbers in array are: ");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j <= arr[i]; j++)
                {
                    if (arr[i] % j==0)
                    {
                        count++;
                    }
                   
                }
                if (count == 2)
                {
                    Console.WriteLine(arr[i]);
                   
                }
                count = 0;
            }
            
            
        }
        static void Main(string[] args)
        {
            int[] p = { 16,17,23,39,45,101,105 };
             Prime_From_array.P_array(p);
           // Console.WriteLine(string.Join(" ", c));
           
            Console.WriteLine();
            // char[]c = C_sot_array.SortCarray(ch);
        }
    }

    //Rotation program
    class rotation
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 8, 5, 3, 9, 11 };
            int temp = a[0];
            for(int i=0;i<a.Length;i++)
            {
                if(i<a.Length-1)
                {
                    a[i] = a[i + 1];
                }
                if(i==a.Length-1)
                {
                    a[i] = temp;
                }
            }
            Console.WriteLine(string.Join(" ",a));
        }
    }
}

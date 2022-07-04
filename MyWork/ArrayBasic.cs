using System;
using System.Collections.Generic;
using System.Text;

namespace MyWork
{
    class SumOfEvenNum
    {
        static void Main(string[] args)
        {
            int[] a = { 43, 51, 30, 76, 45, 62, 87 };
            int sum = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]%2==0)
                {
                    sum = sum + a[i];
                }
            }
            Console.WriteLine("sum of even elements in array = "+sum);
        }
    }

    class SomOfArrayElements
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 43, 51, 30, 76, 45, 62, 87 };
            int sum = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                sum = sum + arr1[i];
            }
            Console.WriteLine("sumof array elements = "+sum);
        }
    }

    class MinOfChar
    {
        static void Main(string[] args)
        {
            char[] arr2 = { 'w', 'd', 'k', 'x', 'j', 'h' };
            char min = arr2[0];
            for(int i=0;i<arr2.Length;i++)
            {
                if(arr2[i]<min)
                {
                    min = arr2[i];
                }
            }
            Console.WriteLine("min= "+min);
        }
    }

    class MinOfInt
    {
        static void Main(string[] args)
        {
            int[] arr3 = {29,35,82,17,95,206,503,11};
            int min = arr3[0];
            for (int i = 0; i < arr3.Length; i++)
            {
                if (arr3[i] < min)
                {
                    min = arr3[i];
                }
            }
            Console.WriteLine("min= " + min);
        }
    }

    class ReverseChar
    {
        static void Main(string[] args)
        {
            char[] arr4= { 'w', 'd', 'k', 'x', 'j', 'h' };
            Console.WriteLine(string.Join(" ",arr4));
            int j = arr4.Length - 1;
            for (int i = 0; i < arr4.Length/2; i++)
            {
                char temp = arr4[i];
                arr4[i] = arr4[j];
                arr4[j] = temp;
                j--;
            }
            Console.WriteLine(string.Join(" ",arr4));
        }
    }

    class ReverseInt
    {
        static void Main(string[] args)
        {
            int[] arr5 = { 29, 35, 82, 17, 95, 206, 503, 11 };
            Console.WriteLine(string.Join(" ", arr5));
            int j = arr5.Length - 1;
            for (int i = 0; i < arr5.Length / 2; i++)
            {
                int temp = arr5[i];
                arr5[i] = arr5[j];
                arr5[j] = temp;
                j--;
            }
            Console.WriteLine(string.Join(" ", arr5));
        }
    }

    class AlternateElement
    {
        static void Main(string[] args)
        {
            int[] arr6 = { 29, 35, 82, 17, 95, 206, 503, 11 };
            Console.WriteLine(string.Join(" ", arr6));
           
            for (int i = 0; i < arr6.Length; i=i+2)
            {
                Console.Write(arr6[i] + " ");

            }
        } 
    }

    class SearchChar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the elements");
            char[] arr7 = new char[5];
            for (int i = 0; i < arr7.Length; i++)
            {
                arr7[i]=char.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ",arr7));
            Console.WriteLine("enter the character for search");
            char ch= char.Parse(Console.ReadLine());
            bool ispresent = false;
            for (int i = 0; i < arr7.Length;i++)
            {
                if (ch == arr7[i])
                {
                    ispresent = true;
                    break;
                }
            }
            if (ispresent == true)
            {
                Console.WriteLine("character is present");
            }
            else
            {
                Console.WriteLine("not present");
            }

        }
    }


    class SearchInt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers");
            int[] arr8 = new int[5];
            for (int i = 0; i < arr8.Length; i++)
            {
                arr8[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", arr8));
            Console.WriteLine("enter the number for search");
            int num = int.Parse(Console.ReadLine());
            bool ispresent = false;
            for (int i = 0; i < arr8.Length; i++)
            {
                if (num == arr8[i])
                {
                    ispresent = true;
                    break;
                }
            }
            if (ispresent == true)
            {
                Console.WriteLine("number is present");
            }
            else
            {
                Console.WriteLine("not present");
            }

        }
    }

    class Primeee
    {
        static void Main(string[] args)
        {
            int[] arr9 = { 29, 35, 82, 17, 95, 206, 503, 11 };
            Console.WriteLine(string.Join(" ", arr9));
     
            for (int i = 0; i < arr9.Length; i++)
            {
                int n = arr9[i];
                bool isprime = true;
                for(int j=2;j<n;j++)
                {
                    if(n%j==0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime == true)
                {
                    Console.WriteLine(arr9[i]);
                }
               
            }
            
        }
    }

    class PrimeeeSum
    {
        static void Main(string[] args)
        {
            int[] arr10 = { 29, 35, 82, 17, 95, 206, 503, 11 };
            Console.WriteLine(string.Join(" ", arr10));
            int sum = 0;
            Console.WriteLine("prime numbers in array are: ");
            for (int i = 0; i < arr10.Length; i++)
            {
                int n = arr10[i];
                bool isprime = true;
                for (int j = 2; j < n; j++)
                {
                    if (n % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime == true)
                {
                    Console.WriteLine(arr10[i]);
                    sum = sum + n;
                }

            }
            Console.WriteLine("sumof prime numbers= "+sum);

        }
    }
}

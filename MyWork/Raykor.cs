using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace MyWork
{
    class Missing_Num_Array
    {
        static void Main(string[] args)
        {
            int[] s = { 1, 2, 3, 4, 5, 6, 8 };
            int l = s.Length + 1;

            int result = l * (l + 1) / 2;

            int sum = 0;
            foreach (int r in s)
            {
                sum = sum + r;

            }
            int miss_num = result - sum;
            Console.WriteLine("Missing number is :" + miss_num);
        }
    }

    class Arr11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of array ");
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            int add = 0;
            int subarrays = 0;
            Console.WriteLine("Enter Array Elements");
            for (int i = 0; i < nums.Length; i++)
            {

                int x = int.Parse(Console.ReadLine());
                nums[i] = x;
            }

            Console.WriteLine("Enter value of k");
            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < nums.Length; i++)
            {

                for (int j = i; j < nums.Length; j++)
                {
                    if ((add + nums[j]) <= k)
                    {
                        add += nums[j];

                    }
                    else
                    {
                        add = 0;
                        break;
                    }
                    if (add == k)
                    {
                        subarrays++;
                        add = 0;
                        break;
                    }

                }


            }
            Console.WriteLine("No of possible subarrays are " + subarrays);
        }
    }

    class overloading
    {
        public void convert(int a)
        {
            string s = a.ToString();
            Console.WriteLine("string conversion:" + s);
        }
        public void convert(double b)
        {
            string s = b.ToString();
            Console.WriteLine("string conversion:" + s);
        }
        static void Main(string[] args)
        {
            overloading o = new overloading();
            o.convert(7);
            o.convert(7.7);

        }
    }

    class Vehicle_Type1
    {
        public virtual void Engine()
        {
            int power_of_engine = 900;
            int RPM = 20;
            int no_of_cylinders = 10;

            Console.WriteLine("Properties of parent Engine:" + " power_of_engine: " +
                power_of_engine + " RPM: " + RPM + " no_of_cylinders:" + no_of_cylinders);
        }
    }
    class Vehicle_Type2 : Vehicle_Type1
    {
        public override void Engine()
        {
            int power_of_engine = 500;
            int RPM = 21;
            int no_of_cylinders = 14;

            Console.WriteLine("Properties of child Engine:" + " power_of_engine: " +
                power_of_engine + " RPM: " + RPM + " no_of_cylinders:" + no_of_cylinders);
        }
    }
    class check_Engine
    {
        static void Main(string[] args)
        {
            Vehicle_Type1 v2 = new Vehicle_Type2();
            v2.Engine();
        }
    }

    class newArray13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of array ");
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];

            Console.WriteLine("Enter Array Elements");
            for (int i = 0; i < nums.Length; i++)
            {

                int x = int.Parse(Console.ReadLine());
                nums[i] = x;
            }
            Array.Sort(nums);
            int element = 1;
            for (int j = 0; j < n; j++)
            {
                if (element == nums[j])
                {

                }
                else
                    Console.WriteLine("Missing numbers: " + nums[j]);

                element++;
            }


        }
    }

    class SearchInt56
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
            int number = 1;
            Array.Sort(arr8);
            //  bool ispresent = false;
            for (int i = 0; i < arr8.Length; i++)
            {
                if (number == arr8[i])
                {
                    //ispresent = true;
                    number++;
                    break;
                }
                else
                {
                    Console.WriteLine(arr8[i]);
                    number++;
                }
            }
            /*if (ispresent == true)
            {
                Console.WriteLine("number is present");
            }
            else
            {
                Console.WriteLine("not present");
            }*/

        }
    }

    class Title_Case
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();

            string[] s = str.Split(" ");

            string c = "is as and to the ";
            string[] a = c.Split(" ");
            char[] ch1 = c.ToCharArray();
            bool flag = false;


            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if ((a[i][j] >= 65) && (a[i][j] <= 90))
                    {
                        flag = false;
                        break;
                    }

                }

                if (s[i] == a[i])
                {
                    flag = true;
                }

                /* if (s[i] == "is" || s[i] == "as" || s[i] == "and" || s[i] == "to" || s[i] == "the")
                 {
                     flag = true;

                 }*/
                else
                {
                    for (int j = 0; j < s[i].Length; j++)
                    {
                        if (j == 0)
                        {

                            if ((s[i][j] >= 65) && (s[i][j] <= 90))
                            {
                                flag = true;

                            }
                            else
                            {
                                flag = false;
                                break;
                            }
                        }
                        else
                        {
                            if ((s[i][j] >= 97) && (s[i][j] <= 122))
                            {
                                flag = true;

                            }
                            else
                            {
                                flag = false;
                                break;
                            }
                        }
                    }
                    if (flag == false)
                        break;

                }
            }
            if (flag == true)
            {
                Console.WriteLine("Title case");
            }
            else
            {
                Console.WriteLine("not Title case");
            }

        }
    }


    class Sort_By_Length_Name
    {
        static void Main(string[] args)
        {
            string[] arr = new string[5];
            Console.WriteLine("Enter the elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }
            string tmp;
            string tmp1;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].Length > arr[j].Length)
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                    else if(arr[i].Length == arr[j].Length)
                    {
                        for (int k = 0; k < arr[i].Length; k++)
                        {
                            if(arr[i][k] > arr[j][k])
                            {
                                tmp1 = arr[i];
                                arr[i] = arr[j];
                                arr[j] = tmp1;
                                break;
                            }

                        }

                    }
                    else
                    {
                        /* Do Nothing*/
                    }
                }

                Console.WriteLine(arr[i]);
            }
           
        }
    }

    class Dddd
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Apple");
            d.Add(2, "Grapes");
            d.Add(3, "Cherry");
            d.Add(4, "Blackberries");
            d.Add(5, "Banana");
            d.Add(6, "Watermelon");
            d.Add(7, "Guava");
            d.Add(8, "Peach");

            Console.WriteLine("Enter Key");
            int n = int.Parse(Console.ReadLine());
            foreach (var number in d)
            {
                if (d.ContainsKey(n))
                {
                    d.Remove(n);

                }
                else
                {
                    //Do Nothing
                }
            }

            bool flag = false;
            Console.WriteLine("Enter Key");
            int n1 = int.Parse(Console.ReadLine());
            foreach (var number in d)
            {
                if (d.ContainsKey(n1))
                {
                    flag = true;
                    break;
                }
                else
                {
                    flag = false;
                    
                }
            }

            if(flag==false)
            {
                d.Add(n1, "Orange");
            }

            foreach (KeyValuePair<int, string> kv in d)
                Console.WriteLine(kv.Key + "==>" + kv.Value);
        }
    }
}

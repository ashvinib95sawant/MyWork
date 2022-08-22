using System;
using System.Collections.Generic;
using System.Text;

namespace MyWork
{
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

    class overloading
    {
        public void convert(int a)
        {
            string s = a.ToString();
            Console.WriteLine("string conversion:"+s);
        }
        public void convert(double b)
        {
            string s = b.ToString();
            Console.WriteLine("string conversion:"+s);
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

            Console.WriteLine("Properties of parent Engine:"+ " power_of_engine: "+
                power_of_engine + " RPM: "+RPM+ " no_of_cylinders:"+ no_of_cylinders);
        }
    }
    class Vehicle_Type2:Vehicle_Type1
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
            int element= 1;
            for(int j=0;j<n;j++)
            {
                if (element==nums[j])
                {

                }
                else
                    Console.WriteLine("Missing numbers: "+nums[j]);

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

                if (s[i]==a[i])
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
                        if (j==0)
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
            if (flag==true)
            {
                Console.WriteLine("Title case");
            }
            else
            {
                Console.WriteLine("not Title case");
            }

        }
    }
}

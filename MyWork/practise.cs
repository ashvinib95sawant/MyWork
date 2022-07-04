using System;
using System.Collections.Generic;
using System.Text;

namespace MyWork
{
    public abstract class B
    {
        public abstract void MethodA();
    }
    public interface IA
    {
        void MethodA();
    }
    public class C : B, IA
    {
        public override void MethodA()
        {
            Console.WriteLine("A-1");
        }
        void IA.MethodA()
        {
            Console.WriteLine("A-2");
        }
    }
    class f
    {
        static void Main(string[] args)
        {
            C ia = new C();
            ia.MethodA();

        }
    }

    class prs
    {
        static void Main(string[] args)
        {
            int i;
            int j = new int();
            i = 10;
            j = 20;
            string str;
            str = i.ToString();
            str = j.ToString();
            Console.WriteLine(str);
        }


    }

    class midp
    {
        static void Main(string[] args)
        {
            int i, j;
            i = 100;
            j = 200;
            while (++i < --j) ;
            Console.WriteLine(i);

        }
    }

    public class qq40
    {
       public static void Main(string[] args)
        {
            sum(10, 20);
        }
        static void sum(long l1, long l2)
        {
            Console.WriteLine("long");
        }
        static void sum(float f1, float f2)
        {
            Console.WriteLine("float");
        }
    }

    public class Test
    {
        void display(Test t)
        {
            Console.WriteLine("Test");
        }
        void display(string str)
        {
            Console.WriteLine("string");
        }
        public static void Main(string[] args)
        {
           // new Test().display(null);
        }
    }

    //1.(a-b)cube

    class cubee
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b");
            int b = int.Parse(Console.ReadLine());
            int result;
            result = (a - b) * (a - b) * (a - b);
            Console.WriteLine(result);

            int ans=1;
            Console.WriteLine("enter exponent");
            int exp=int.Parse(Console.ReadLine());
            for(int i=1;i<=exp; i++)
            {
                ans = ans * (a - b);
            }
            Console.WriteLine(ans);
        }
    }

    //2.Prime number
    class primee
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter value of n");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i=1;i<=n;i++)
            {
                if(n%i==0)
                {
                    count++;
                }
            }
            if(count==2)
                Console.WriteLine("prime");
            else
                Console.WriteLine("Not prime");
        }
    }
    class primee2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                    Console.WriteLine(i);
            }
           
        }
    }

    //3.fionacci

    class fnc
    {
        static void Main(string[] args)
        {
            int n = 1;
            int sum = 0;
            
            for (int i=1;i<=10;i++)
            {
                int result = sum + n;
                Console.Write(n+" ");
                sum = n;
                n = result;
            }
           
        }
    }

    //4.print first 5 numbers using for while and do while loop

    class loop
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(">>>>>>>>>>>");
            int n = 1;
            while( n<=5)
            {
                Console.WriteLine(n);
                n++;
            }
            Console.WriteLine(">>>>>>>>>>>>");
            n = 1;
            do
            {
                Console.WriteLine(n);
                n++;
            } while (n <= 5);
        }
    }

    //5.Palindrome

    class plndm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int temp = n;
            int rev = 0;
            while(n!=0)
            {
                int last = n % 10;
                rev = rev*10 + last;
                n = n / 10;
            }
            if(temp==rev)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not palindrome");
        }
    }

    //6.Even odd

    class Eveod
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num");
            int n = int.Parse(Console.ReadLine());
            if(n%2==0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
        }
    }

    //7.Calculate speed and time & velocity and acceleration
    //distance=speed*time
    //velocity=displacement/time
    //Force=mass*acceleration
    class st
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter distance");
            int distance = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter time");
            int time = int.Parse(Console.ReadLine());

           int speed = distance / time;
            Console.WriteLine(speed);
        }
       
    }
   
    //8.sum of array elements

    class sumarray
    {
        static void Main(string[] args)
        {
            int[] ar = { 23, 45, 56, 67, 78 };
            int sum = 0;
            foreach(int value in ar)
            {
                sum = sum + value;
            }
            Console.WriteLine(sum);
        }
    }
    class revarray
    {
        static void Main(string[] args)
        {
            int[] ar1 = { 23, 45, 56, 67, 78 };
            int j = ar1.Length - 1;
            for(int i=0;i<ar1.Length/2;i++)
            {
                int temp = ar1[i];
                ar1[i] = ar1[j];
                ar1[j] = temp;
            }
            Console.WriteLine(string.Join(" ",ar1));
        }
    }

    //reverse string
     
    class revstring
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            string rev = "";
            int j = str.Length - 1;

            while (j >= 0)
            {
                rev = rev + str[j];
                j--;
            }
            Console.WriteLine(rev);


            //Using for loop
            /*for (int i=str.Length-1; i>=0;i--)
            {
                rev = rev + str[i];
            }
            Console.WriteLine(rev);*/


            //with inbuilt reverse method
            /*string ar2 = "ashu";
            char[] ch1 = ar2.ToCharArray();
            Array.Reverse(ch1);
            Console.WriteLine(new string(ch1));*/
        }
    }

    //frequency of string

    class fstring
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string st1 = Console.ReadLine();
            char[] ch1 = st1.ToCharArray();
           
           
            for(int i=0;i<st1.Length;i++)
            {
                 int count = 0;
                foreach (char c in st1)
                {
                    
                    if (c == ch1[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine("occerence of " + ch1[i] + "= " + count);
            }

        }
    }


    //Palindrome string

    class pmstring
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
            if(st2==rev)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not palindrome");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MyWork
{
    class Exception_Handling
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Enter Number");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Division:" + a / b);
                Console.WriteLine("Try ends");

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("1");
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("2");
                Console.WriteLine(e.Message);
            }
            catch (SystemException e)
            {
                Console.WriteLine(e.Message);
            }
            for (int i = 1; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }

        }
    }



    class Exception_Handling1
    {
        static void Main(string[] args)
        {

           Console.WriteLine("welcome");
           Console.WriteLine("enter number");
          try
          {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("division:" + a / b);
            try
            {
              Console.WriteLine("enter age");
              int c = int.Parse(Console.ReadLine());
              Console.WriteLine();
            }
            catch (NullReferenceException e)
            {
              Console.WriteLine(e.Message);
            }

            Console.WriteLine("try ends");

          }
          catch (DivideByZeroException e)
          {
            Console.WriteLine("1");
            Console.WriteLine(e.Message);
          }
        }
    }


    class Exception_H2
    {
       static void m1()
       {

          Console.WriteLine("m1 starts");
          Console.WriteLine("Enter number");
          int a = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("M1 ends");
       }

       public static void m2()
       {
         m1();
         Console.WriteLine("in m2222");
       }

       static void Main(string[] args)
       {
         Console.WriteLine("Main starts");
         try
         {
            m2();
         }
         catch (Exception e)
         {
            Console.WriteLine(e.Message);
         }
         Console.WriteLine("Main ends");
       }
    }


    class Streamreaderclass
    {
        static void Main(string[] args)
        {

            StreamReader sr = null;
            try
            {
                Console.WriteLine("Enter number");
                int a = int.Parse(Console.ReadLine());
                sr = new StreamReader("D.//text");
                Console.WriteLine(sr.Read());
                Console.WriteLine(sr.ReadLine());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("in finally");

                if (sr != null)
                    sr.Close();

            }
        }
    }

    //Custom Exception

    class InvalidExperienceException:ApplicationException
    {

    }
    class Emp:Object
    {
        string nm;
        int experience;
       
        public string Nm
        {
            set { this.nm = value; }
            get { return nm; } 
        }
        public override string ToString()
        {
            return "Name:" + nm + "Experience:" + experience;
        }


        public int Experience
        {
            set
            {

                if (value < 0)
                    throw new InvalidExperienceException();
                else
                    this.experience = value;
            }
            get { return experience; }
        }
    }

    class class111
    {
        static void Main(string[] args)
        {
            Emp e1 = new Emp();
            Console.WriteLine("enter name and experience");
            e1.Nm = Console.ReadLine();
            try
            {
                e1.Experience = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Experience can't be negative");
            }
            Console.WriteLine(e1);
        }
    }
}

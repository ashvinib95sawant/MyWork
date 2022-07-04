using System;
using System.Collections.Generic;
using System.Text;

namespace MyWork
{
    class I
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 10; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if(c==3||r==1||r==10)
                    Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }

    class L
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 10; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if (c == 1 || r == 10)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }

    class E
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 10; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if (c == 1 || r == 1 || r==5 ||r == 10)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }

    class T
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 10; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if (c == 3 || r == 1 )
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }

    class P
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 10; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if (c == 1 || r == 1 || r == 5 || (r<=5&&c==5))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }

    class O
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 10; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if (c == 1||c== 5|| r == 1 || r == 10)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }

    class F
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 10; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if (c == 1 || r == 1 || r == 5)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }

    class X
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 9; r++)
            {
                for (int c = 1; c <= 9; c++)
                {
                    if (r == c||r+c==10)
                    {
                        Console.Write("*");

                    }
                     else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }


    //*
    //**
    //***
    //****
    //*****
    class One
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                     Console.Write("*");
                   
                }
                Console.WriteLine();
            }
        }
    }


    //*****
    //****
    //***
    //**
    //*
    class Two
    {
        static void Main(string[] args)
        {
            for (int r = 5; r >= 1; r--)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    //1
    //12
    //123
    //1234
    //12345

    class Three
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c);

                }
                Console.WriteLine();

            }
        }
    }

    //1
    //22
    //333
    //4444
    //55555
    class Four
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(r);

                }
                Console.WriteLine();

            }
        }
    }

    //12345
    //1234
    //123
    //12
    //1

    class Five
    {
        static void Main(string[] args)
        {
            for (int r = 5; r >= 1; r--)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c);

                }
                Console.WriteLine();

            }
        }
    }


    //54321
    //5432
    //543
    //54
    //5
    class Six
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 5; c >= r; c--)
                {
                    Console.Write(c);

                }
                Console.WriteLine();

            }
        }
    }

    //6
    //67
    //678
    //6789

    class Eight
    {
        static void Main(string[] args)
        {
            for (int r = 6; r <= 9; r++)
            {
                for (int c = 6; c <= r; c++)
                {
                    Console.Write(c);

                }
                Console.WriteLine();

            }
        }
    }

    //1
    //21
    //321
    //4321
    //54321
    class Nine
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = r; c >= 1; c--)
                {
                    Console.Write(c);
                   

                }
                Console.WriteLine();

            }
        }
    }

    //54321
    //4321
    //321
    //21
    //1
    class Ten
    {
        static void Main(string[] args)
        {
            for (int r = 5;  r >= 1; r--)
            {
                for (int c = r; c >= 1; c--)
                {
                    Console.Write(c);


                }
                Console.WriteLine();

            }
        }
    }


    //12345
    //2345
    //345
    //45
    //5
    class Eleven
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = r; c <= 5; c++)
                {
                    Console.Write(c);


                }
                Console.WriteLine();

            }
        }
    }


    //12345
    //2345
    //345
    //45
    //5
    //45
    //345
    //2345
    //12345
    class Twelve
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = r; c <= 5; c++)
                {
                    Console.Write(c);


                }
                Console.WriteLine();

            }
            for (int r = 4; r >= 1; r--)
            {

                for (int c = r; c <= 5; c++)
                {
                    Console.Write(c);

                }
                Console.WriteLine();
            }
        }
    }


    //A
    //AB
    //ABC
    //ABCD
    //ABCDE
    //ABCDEF
    //ABCDE
    //ABCD
    //ABC
    //AB
    //A
    class Thirteen
    {
        static void Main(string[] args)
        {
            for (char r = 'A'; r <= 'F'; r++)
            {
                for (char c = 'A'; c <= r; c++)
                {
                    Console.Write(c);

                }
                Console.WriteLine();

            }
            for (char r = 'E'; r >= 'A'; r--)
            {
                for (char c = 'A'; c <= r; c++)
                {
                    Console.Write(c);

                }
                Console.WriteLine();

            }
        }
    }

    /* 1
       10
       101
       1010
       10101 
       0
       12
       345
       6789
     */
    class Fourteen
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c%2);
                }
                Console.WriteLine();
            }

            int k = 0;
            for (int r = 1; r <= 4; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(k);
                    k++;
                }
                Console.WriteLine();
            }

        }
    }

    /*
         1
        12
       123
      1234
     12345

    */
    class Fifteen
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for(int space=4;space>=r;space--)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }

           

        }
    }
    /*
     
     *
     ***
     *****
     *******
     *********

    */
    class Sixteen
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of lines");
            int Line = int.Parse(Console.ReadLine());

            for (int r = 1; r <= Line; r++)
            {
                
                for (int c = 1; c <2*r; c++)
                {
                    
                    Console.Write("*");
                

                }
                Console.WriteLine();
            }
        }
    }

    /*
          *
         ***
        *****
       *******
      *********
      
    */

    class Seventeen
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of lines");
            int Line = int.Parse(Console.ReadLine());

            for (int r = 1; r <= Line; r++)
            {
                for(int sp=1;sp<=Line-r;sp++)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c < 2 * r; c++)
                {

                    Console.Write("*");


                }
                Console.WriteLine();
            }
        }
    }

    /*
        1
       121
      12321
     1234321
    123454321
      
     
     */

    class Eighteen
    {
        static void Main(string[] args)
        {
           

            for (int r = 1; r <= 5; r++)
            {
                for (int sp = r; sp <= 4 ; sp++)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c);
                }
                for(int k=r-1;k>=1;k--)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
        }
    }

    class fourty
    {
        static void Main(string[] args)
        {
            for(int r=1; r<=5; r++)
            {
                for(int c=r; c<=5;c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyWork
{
    class TwoD_Declaration
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 4,5,6},
                            {2,5,8 },
                            {7,8,9 } };

            //2nd way of declaring array
            int[,] a1 = new int[2, 2] { { 1, 5 }, { 5, 6 } };

            //3rd way of declaration
            int[,] a2 = new int[2, 2];
            a2[0, 0] = 6;
            a2[0, 1] = 8;
            a2[1, 0] = 3;
            a2[1, 1] = 7;

            //user inputs
            int[,] a3 = new int[2, 2];
            Console.WriteLine("Enter array elements");
            for(int i=0;i<=a3.GetUpperBound(0);i++)
            {
                for (int j = 0; j <= a3.GetUpperBound(1); j++)
                {
                    a3[i, j] = int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("............................");
            for (int i = 0; i <= a3.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a3.GetUpperBound(1); j++)
                {
                    Console.Write(a3[i,j]+" ");
                }

            }
            Console.WriteLine();
           
        }
    }

    //sum of row elements
    
    class  Srow
    {
        static void Main(string[] args)
        {
            int[,] a4 = { { 4,5,6},
                            {2,5,8 },
                            {7,8,9 } };

            for (int i = 0; i < a4.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < a4.GetLength(1); j++)
                {
                    sum = sum + a4[i, j];
                    Console.Write(a4[i, j] + " ");
                }
                Console.WriteLine("   sum="+sum);
                Console.WriteLine();
            }
        }
    }

    //display 2d array and pattern

    class Pat_array
    {
        static void Main(string[] args)
        {
            int[,] ar1 = new int[4, 4];
            Console.WriteLine("Enter array elements");

            for (int i = 0; i < ar1.GetLength(0); i++)
            {
                for (int j = 0; j < ar1.GetLength(1); j++)
                {
                    ar1[i, j] = int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("..................................");
            Console.WriteLine();

            for (int i = 0; i < ar1.GetLength(0); i++)
            {
                for (int j = 0; j < ar1.GetLength(1); j++)
                {
                    Console.Write(ar1[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("/////////////////////////////////////");
            Console.WriteLine();
            for (int i = 0; i <= ar1.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= ar1.GetUpperBound(1); j++)
                {
                   if(i==0||j==0||i==ar1.GetUpperBound(0)||j==ar1.GetUpperBound(1))
                   {
                        Console.Write(ar1[i,j]);
                   }
                   else
                   {

                        Console.Write(" ");  }
                }
                Console.WriteLine();

            }
        }

    }

    //columnwise sum

    class csum
    {
        static void Main(string[] args)
        {
            int[,] ar4 = { { 4,5,6},
                            {2,5,8 },
                            {7,8,9 } };

            int sum = 0;
            int[] r = new int[3];
            for (int i = 0; i < ar4.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < ar4.GetLength(1); j++)
                {
                    Console.Write(ar4[i, j] + "      ");
                    sum = sum + ar4[j, i];
                    
                   
                }
                r[i] = sum;

                Console.WriteLine();
                
            }
            Console.WriteLine();
            foreach (int p in r)
            {
                Console.Write("s=" + p+"  ");
            }
           
        }
    }


    //Rowwise average
    class Srow_Avg
    {
        static void Main(string[] args)
        {
            int[,] ar = { { 4,5,6},
                            {2,5,8 },
                            {7,8,9 } };
           

            for (int i = 0; i < ar.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    sum = sum + ar[i, j];
                    Console.Write(ar[i, j] + " ");
                }
                Console.WriteLine("   average=" + sum / ar.GetLength(0));
                Console.WriteLine();
            }
        }
    }

    //N pattern
    class N_Pat_array
    {
        static void Main(string[] args)
        {
            int[,] a = new int[4, 4];
            Console.WriteLine("Enter array elements");

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("..................................");
            Console.WriteLine();

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("/////////////////////////////////////");
            Console.WriteLine();
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    if (j == 0 || j == a.GetUpperBound(1)||j==i)
                    {
                        Console.Write(a[i, j]);
                    }
                    else
                    {

                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

            }
        }

    }

    //Perform addition of two matrices

    class MatAdd
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 7, 2, 3 }, { 4, 5, 6, 7 } };
            int[,] b = { { 9, 8, 9, 6 }, { 9, 4, 5, 7 }, { 1, 9, 9, 8 }, { 7, 6, 8, 4 } };
            int[,] c = new int[4,4];
           

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(".......................................");
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,");
            Console.WriteLine("Sum of above two matrices is");
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    
                  
                    //Console.Write(b[i,j]);
                    c[i, j] = a[i, j] + b[i, j];
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }

   
   
}

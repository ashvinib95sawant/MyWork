using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace MyWork
{
    class sagitech
    {
        static void Main(string[] args)
        {
            int A =int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C;
            int N = int.Parse(Console.ReadLine());

            ArrayList a1 = new ArrayList();
            ArrayList a2 = new ArrayList();

            if (A % 2 != 0)
                a1.Add(A);
            else
                a2.Add(A);

            if (B % 2 != 0)
                a1.Add(B);
            else
                a2.Add(B);

            for (int i = 2; i < N; i++)
            {
                C = A + B;

                if (C % 2 != 0)
                    a1.Add(C);
                else
                    a2.Add(C);
                A = B;
                B = C;
            }

            foreach (int y in a2)
                Console.Write(y + " ");
            Console.WriteLine();

            foreach (int z in a1)
                Console.Write(z+" ");

           
        }
    }

    class difference
    {

        public static int mDiff(int[] arr, int n)
        {
            int maxdiff = 0;
          
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (Math.Abs(arr[i] - arr[i + 1]) > maxdiff)
                    maxdiff = Math.Abs(arr[i] - arr[i + 1]);

            }
            return maxdiff;
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 55, 7, 110, 25, 120 };
            int n = arr.Length - 1;
            Console.WriteLine(mDiff(arr, n));
        }


    }
}

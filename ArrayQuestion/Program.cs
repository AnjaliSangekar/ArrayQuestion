using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQuestion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reverse();
            Console.WriteLine();
            SortDescending();
            Console.WriteLine();
            Console.WriteLine(SumNumber());
            Console.WriteLine();
            MissingNo();
            Console.WriteLine();
            MovezeroEnd();
        }


        public static void Reverse()
        {
            int[] a = { 1, 2, 3, 4, 5, 6 };

            foreach (int i in a)
            {
                Console.Write(i + " ");
            }

            Array.Reverse(a);

            Console.WriteLine("\nReverse array");

            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
        }


        public static void SortDescending()
        {
            int[] a = { 3, 5, 7, 8, 1, 2, 4, 6 };

            foreach(int i in a)
            {
                Console.Write(i + " ");
            }

            Array.Sort(a);

            Array.Reverse(a);

            Console.WriteLine("\nSort in Descending order");

            foreach(int i in a)
            {
                Console.Write(i + " ");
            }
        }


        public static bool SumNumber()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };

            foreach (int i in a)
            {
                Console.Write(i + " ");
            }

            int num = 20;
            int sum = 0;
            Console.WriteLine("\nSum find " + num);

            for (int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j < a.Length; j++)
                {
                    if(i != j)
                    {
                        sum = a[i] + a[j];

                        if(sum == num)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }


        public static void MissingNo()
        {
            int[] a = { 1, 2, 4, 5, 7, 9, 10 };

            foreach(int i in a)
            {
                Console.Write(i + " ");
            }

            int diff = a[0] - 0;

            Console.WriteLine("\nMissing number");

            for (int i=0; i<a.Length; i++)
            {
                if (a[i]-i != diff)
                {
                    while(diff < a[i]-i)
                    {
                        Console.WriteLine(i + diff + " ");

                        diff++;
                    }
                }
            }
        }


        public static void MovezeroEnd()
        {
            int[] a = { 1, 2, 0, 4, 0, 5, 0, 7 };

            foreach(int i in a)
            {
                Console.Write(i + " ");
            }

            int index = 0;

            for(int i=0; i<a.Length;i++)
            {
                if (a[i] != 0)
                {
                    a[index] = a[i];
                    index++;
                }
            }

            for(int i=index; i<a.Length;i++)
            {
                a[i] = 0;
            }

            Console.WriteLine("\nMove Zero to end");

            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
        }
    }
}

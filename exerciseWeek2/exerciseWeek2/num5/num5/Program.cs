using System;

namespace num5
{
    class Program
    {
        public static int Multifunction(int[] n, int[]b)
        {
            Console.WriteLine("Calcul des tables en cour...");
            int totalmulti=0;
            for(int i=0;i<n.Length;i++)
            {
                totalmulti = n[i] * b[i];
                Console.WriteLine(totalmulti);
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int[] tab1 = {3,4,5,6,1,2,3,4,8};

            int[] tab2 = {4,7,3,2,6,7,8,1,2};

            Multifunction(tab1, tab2);
        }
    }
}

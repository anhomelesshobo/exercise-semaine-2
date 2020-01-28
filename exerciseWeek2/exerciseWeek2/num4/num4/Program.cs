using System;

namespace num4
{
    class Program
    {
        public static int Somme(int[] n)
        {
            int total = 0;
            for(int i=0; i<n.Length; i++)
            {
                total += n[i];
            }
            return total;
        }
        static void Main(string[] args)
        {
            int[] nombres = { 10, 11, 5 ,15, 12, 8, 9, 6, 5, 3, 4, 6, 13, 16, 14 };

            Console.WriteLine(Somme(nombres));
        }
    }
}

using System;

namespace num3
{
   
    class Program
    {
        public static bool isPrime(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));

            if(n==1)
            {
                return false;
            }
            if(n==2)
            {
                return true;
            }
            else
            {
                int i = 2;

                while(i <= x)
                {
                    
                    if(n%i==0)
                    {
                        return false;
                    }
                    
                        i++;
                    
                }
                
                return true;
                
            }
        }
        public static void Main()
        {
           
            Console.WriteLine("\nSum of the first 500 prime numbers: ");

            long sum = 0;
            int ctr = 0;
            int n = 2;

            while(ctr < 500)
            {
                if(isPrime(n))
                {
                    sum += n;
                    ctr++;
                }
                n++;
            }

            Console.WriteLine(sum.ToString());
        }
    }
}

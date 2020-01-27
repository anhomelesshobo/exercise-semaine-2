using System;

namespace num2
{
    class Program
    {
        static void Main(string[] args)
        {
            int line;
            int line2;
            Console.WriteLine("entrer votre premier nombre: ");
            line = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("entrer votre deuxieme nombre: ");
            line2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quel arithmetique voulez vous faire ? ( + , - , * , / )");

            string arithmetique;
            arithmetique = Console.ReadLine();
            int reponse;
            if(arithmetique == "*")
            {
                reponse = line * line2;
                Console.WriteLine("le total avec une multiplication est de: " + reponse);
            }

            if (arithmetique == "+")
            {
                reponse = line + line2;
                Console.WriteLine("le total avec une addition est de: " + reponse);
            }

            if (arithmetique == "/")
            {
                reponse = line / line2;
                Console.WriteLine("le total avec une division est de: " + reponse);
            }

            if (arithmetique == "-")
            {
                reponse = line - line2;
                Console.WriteLine("le total avec une soustraction est de: " + reponse);
            }
        }
    }
}

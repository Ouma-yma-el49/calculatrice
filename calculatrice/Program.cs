using System;

namespace Calculatrice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez deux nombres : ");
            Console.Write("Nombre 1 : ");
            int nombre1 = int.Parse(Console.ReadLine());
            Console.Write("Nombre 2 : ");
            int nombre2 = int.Parse(Console.ReadLine());

            int resultat = Addition(nombre1, nombre2);
            Console.WriteLine($"La somme est : {resultat}");
        }

        public static int Addition(int a, int b)
        {
            return a + b;
        }
    }
}

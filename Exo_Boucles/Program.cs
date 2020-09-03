using System;

namespace Exo_Boucles
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exo_1 - Suite de Fibonacci
            //int nb0, nb1, nb2;

            //nb0 = 0;
            //nb1 = 1;
            //for (int i = 0; i < 25; i++)
            //{
            //    nb2 = nb0 + nb1;
            //    Console.WriteLine(nb1);
            //    nb0 = nb1;
            //    nb1 = nb2;
            //}
            #endregion

            #region Exo_2 - Factorielle

            int number;
            do
            {
                Console.WriteLine("Veuillez introduire le nombre à soumettre en factorielle : ");
            } while (!int.TryParse(Console.ReadLine(), out number));
            int result = 1;
            for (int i = number; i > 1; i--)
            {
                result *= i;
            }
            Console.WriteLine($"La factorielle de {number} est {result}");
            #endregion
        }
    }
}

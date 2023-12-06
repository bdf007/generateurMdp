using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCS
{
    static class outils
    {
        public static int DemanderNombrePositifNonNul(string question)
        {

            return DemanderNombreEntre(question, 1, int.MaxValue, "Erreur : Le nombre doit être supérieur à zéro");
        }

        public static int DemanderNombreEntre(string question, int min, int max, string messageErreurPersonalise = "")
        {
            int nombre = DemanderNombre(question);
            while (nombre < min || nombre > max)
            {
                if (messageErreurPersonalise != "")
                {
                    Console.WriteLine(messageErreurPersonalise);
                }
                else
                {

                Console.WriteLine($"Erreur : Vous devez saisir un nombre entre {min} et {max}");
                }
                Console.WriteLine();
                nombre = DemanderNombre(question);
            }
            return nombre;
        }
        static int DemanderNombre(string question)
        {
            while (true)
            {

                Console.Write(question);
                string reponse = Console.ReadLine();
                try
                {
                    int reponseInt = int.Parse(reponse);
                    return reponseInt;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erreur : Vous devez saisir un nombre");
                    Console.WriteLine();
                }
            }

        }
    }
}

using System;
using FormationCS;

namespace generateurMdp
{
    class Program
    {
        static string genererMdp ()
        {
            int nombreCaractere = outils.DemanderNombrePositifNonNul($"Choisir la longueur du mot de passe  : ");
            Console.WriteLine($"nombre de caracteres choisi : {nombreCaractere}");
            string alphabet = "";
            string minuscule = "abcdefghijklmnopqrstuvwxyz";
            string majuscule = minuscule.ToUpper();
            string chiffre = "0123456789";
            string symbole = "!&#*+";
            int typeDeMdp = 0;
            while (typeDeMdp <= 0)
            {
                typeDeMdp = outils.DemanderNombrePositifNonNul("quel type de mot passe souhaitée?\n" +
                "1 - uniquement des caratères en minuscule\n" +
                "2 - Des catactères minuscules et majuscules\n" +
                "3 - Des caractères et des chiffres\n" +
                "4 - Caractères, chiffres et caractères spéciaux\n" +
                "");
                switch (typeDeMdp)
                {
                    case 1:
                        alphabet = minuscule;
                        break;
                    case 2:
                        alphabet = minuscule + majuscule;
                        break;
                    case 3:
                        alphabet = minuscule + majuscule + chiffre;
                        break;
                    case 4:
                        alphabet = minuscule + majuscule + chiffre + symbole;
                        break;
                    default:
                        Console.WriteLine("Erreur : Vous devez saisir un nombre entre 1 et 4");
                        typeDeMdp = 0;

                        break;
                }
            }

            Random rand = new Random();
            string mdp = "";
            for (int i = 0; i < nombreCaractere; i++)
            {
                int index = rand.Next(0, alphabet.Length);
                mdp += alphabet[index];
            }
            return mdp;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans le générateur de mot de passe");
            string motDePasse= genererMdp();
            Console.WriteLine(motDePasse);

        }
    }
}

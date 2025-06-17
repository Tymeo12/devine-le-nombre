using System;
using System.Net.Http.Headers;

namespace DevineLeNombre
{
    class Program
    {
        static void playagame(int intervalle, int NBtry)
        {
           

            // Ici on va construire notre jeu étape par étape
            Random random = new Random();
            int nombreSecret = random.Next(1, intervalle);
            bool win = false;
            Console.WriteLine("J'ai choisi un nombre entre 1 et " + intervalle + ".");
            Console.WriteLine("À toi de le deviner !");
            int nbtry = NBtry;
            int essai = nbtry;
            Console.WriteLine("effectue ta premiere tentative: ");
            for (int i = 0; i < NBtry; i++)
            {

                if (essai == 1) { Console.WriteLine("il te reste " + essai + " essai"); }
                else { Console.WriteLine("il te reste " + essai + " essais"); }

                int tentative = int.Parse(Console.ReadLine());
                if (tentative == nombreSecret)
                {
                    Console.WriteLine("Bravo ta reussi !");
                    win = true;
                    break;
                }
                else if (tentative > nombreSecret)
                {
                    Console.WriteLine("le nombre secret est inferieur");
                }
                else
                {
                    Console.WriteLine("le nombre secret est superieur");

                }
                essai -= 1;

            }
            if (win) { }
            else { Console.WriteLine("tu as perdu ressaye le nombre secret etait " + nombreSecret); }



        }
        static void Main(string[] Args)
        {
            Console.WriteLine("=== DEVINE LE NOMBRE ===");
            Console.WriteLine("Bienvenue dans le jeu !");
            bool retry = true;
            while (retry)
            {
                Console.WriteLine("Choisie ta difficulter \n" +
                "1. niveau facile \n" +
                "2. niveau intermediaire\n" +
                "3. niveau difficile\n" +
                "4. niveau impossible (1 chance sur 1 000 000)\n" +
                "5. pas envie de jouer");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        playagame(50, 15);
                        break;
                    case "2":
                        playagame(100, 6);
                        break;
                    case "3":
                        playagame(200, 5);
                        break;
                    case "4":
                        playagame(1000000, 1);
                        break;
                    case "5":
                        Console.WriteLine("aurevoire!");
                        retry = false;
                        break;
                    default:
                        Console.WriteLine("choix invalide");
                        break;



                }
            }
        }

    }

}
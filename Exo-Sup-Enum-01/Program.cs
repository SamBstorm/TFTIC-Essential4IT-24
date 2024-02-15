namespace Exo_Sup_Enum_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Exo sup 01 :

Dans une application console .Net 8.0, créez un jeu du pierre-feuille-ciseaux à l'aide d'une énumération.

1. Créez l'énumération
2. L'ordinateur choisi une valeur de l'énumération de manière aléatoire (utilisation du Random)
3. Affichage des choix pour le joueur
4. Le joueur entre un choix
5. Selon les règles indiqué si perdu, gagné ou égalité

Indice pour l'aléatoire :
-------------------------
Random RNG = new Random();
int valeur = RNG.Next(0, 10); // => donne une valeur entre 0 et 9 (10 non-inclus)*/


            Console.WriteLine("Bienvenu dans le jeu 'Pierre-Feuille-Ciseaux'");
            Console.WriteLine("L'ordinateur choisi...");

            Random RNG = new Random();
            int valeur = RNG.Next(0, 3);
            ValeurJeu choix_ordinateur = (ValeurJeu)valeur;

            //Console.WriteLine("L'ordinateur a choisi " + choix_ordinateur);

            string[] choix_possibles = Enum.GetNames<ValeurJeu>();
            Console.WriteLine("Veuillez faire votre choix entre :");

            foreach (string choix in choix_possibles)
            {
                Console.WriteLine(choix);
            }
            Console.Write("Votre choix :");
            string input = Console.ReadLine();
            ValeurJeu choix_joueur;
            bool convertOk = Enum.TryParse<ValeurJeu>(input, out choix_joueur);
            while (convertOk == false)
            {
                Console.WriteLine("La valeur " + input + " n'est pas un choix valide...");
                Console.WriteLine("Veuillez faire votre choix entre :");

                foreach (string choix in choix_possibles)
                {
                    Console.WriteLine(choix);
                }
                Console.Write("Votre choix :");
                input = Console.ReadLine();
                convertOk = Enum.TryParse<ValeurJeu>(input, out choix_joueur);
            }

            if(choix_joueur == choix_ordinateur)
            {
                Console.WriteLine("Égalité...");
            }
            else if( 
                (choix_joueur == ValeurJeu.Pierre && choix_ordinateur == ValeurJeu.Ciseaux)
                || (choix_joueur == ValeurJeu.Ciseaux && choix_ordinateur == ValeurJeu.Feuille)
                || (choix_joueur == ValeurJeu.Feuille && choix_ordinateur == ValeurJeu.Pierre)
                )
            {
                Console.WriteLine("Gagné!");
            }
            else
            {
                Console.WriteLine("Perdu...");
            }
        }
    }
}

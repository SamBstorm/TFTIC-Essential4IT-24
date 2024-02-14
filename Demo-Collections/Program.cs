namespace Demo_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomsEleves = new List<string>();
            string input;
            do
            {
                Console.WriteLine("Veuillez inscrire un élève au concours :");
                input = Console.ReadLine();
                if(input != "FIN")
                {
                    nomsEleves.Add(input);
                }
            } while (input != "FIN");

            /* La do {...} while (...) ; est identique à la while, sauf que nous exécuton une première fois le contenu sans condition, ce qui économise les lignes de codes répétitives...
             * 
             * 
            Console.WriteLine("Veuillez inscrire un élève au concours :");
            input = Console.ReadLine();
            if (input != "FIN")
            {
                nomsEleves.Add(input);
            }

            while (input != "FIN")
            {
                Console.WriteLine("Veuillez inscrire un élève au concours :");
                input = Console.ReadLine();
                if (input != "FIN")
                {
                    nomsEleves.Add(input);
                }
            }*/

            while (nomsEleves.Count > 1)
            {
                Console.WriteLine("Veuillez indiquer l'élève éliminé du concours :");
                input= Console.ReadLine();
                if( nomsEleves.Contains(input) )
                {
                    Console.WriteLine("Désolé, " + input + ", vous n'avez pas été sélectionné...");
                    nomsEleves.Remove(input);
                }
                else
                {
                    Console.WriteLine(input + " ne fait pas partie de la liste de participants.");
                }
            }

            Console.WriteLine("Bravo " + nomsEleves[0] + " vous avez gagné le concours!");
        }
    }
}

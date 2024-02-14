namespace Exo_Sup_Tableau01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Exo sup 1:
Dans une application Console .net 8.0, créez un  tableau contenant les différents noms des mois (Janvier, Février, Mars, Avril, ... ) et grâce à notre DateTime, afficher la phrase suivante :

Nous sommes le 13 février 2024.

Pour obtenir la date d'aujourd'hui : DateTime.Now

Dans la structure DateTime, les propiétés Month vous permettent d'obtenir les données manquantes pour cet exercice.*/

            string[] nomsMois = new string[] {
                "Janvier",
                "Février",
                "Mars",
                "Avril",
                "Mai",
                "Juin",
                "Juillet",
                "Août",
                "Septembre",
                "Octobre",
                "Novembre",
                "Décembre"
            };

            DateTime aujourdhui = DateTime.Now;

            Console.WriteLine(aujourdhui);
            Console.WriteLine(aujourdhui.Day);
            Console.WriteLine(aujourdhui.Month);
            Console.WriteLine(aujourdhui.Year);

            int indice_mois = aujourdhui.Month - 1;

            Console.WriteLine("Nous sommes le " + aujourdhui.Day + " " + nomsMois[indice_mois] + " " + aujourdhui.Year);
        }
    }
}

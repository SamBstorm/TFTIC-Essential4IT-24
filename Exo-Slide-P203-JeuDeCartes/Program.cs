namespace Exo_Slide_P203_JeuDeCartes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carte[] paquet = new Carte[52];

            /* Boucle for avec méthode mathématique
            for (int i = 0; i < paquet.Length; i++)
            {
                paquet[i].couleur = (Couleurs)(i % 4);
                paquet[i].valeur = (Valeurs)((i%13) + 2);
            }*/

            /* Boucles for avec indice calculé
            for (int c = 0; c < 4; c++)
            {
                for (int v = 0; v < 13; v++)
                {
                    paquet[(c * 13) + v].valeur = (Valeurs)(v + 2);
                    paquet[(c * 13) + v].couleur = (Couleurs) c;
                }
            }*/

            /* Boucles foreach avec méthodes des slides
            string[] tabDeCouleurs = Enum.GetNames<Couleurs>();
            string[] tabDeValeurs = Enum.GetNames<Valeurs>();
            int i = 0;
            foreach (string couleur in tabDeCouleurs)
            {
                foreach (string valeur in tabDeValeurs)
                {
                    paquet[i].couleur = Enum.Parse<Couleurs>(couleur);
                    paquet[i].valeur = Enum.Parse<Valeurs>(valeur);
                    i++;
                }
            }*/

            int i = 0;
            foreach (Couleurs couleur in Enum.GetValues<Couleurs>())
            {
                foreach (Valeurs valeur in Enum.GetValues<Valeurs>())
                {
                    paquet[i].couleur = couleur;
                    paquet[i].valeur = valeur;
                    i++;
                }
            }

            foreach (Carte carte in paquet)
            {
                Console.WriteLine(carte.valeur + " de " + carte.couleur);
            }
        }
    }
}

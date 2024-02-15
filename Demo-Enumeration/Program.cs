namespace Demo_Enumeration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FeuRouge f1 = new FeuRouge();

            Console.WriteLine("Veuillez indiquer la couleur du feu rouge :");
            Console.WriteLine("Vous avez le choix entre :");

            string[] couleurs = Enum.GetNames<CouleurFeuRouge>();
            for (int i = 0; i < couleurs.Length; i++)
            {
                Console.WriteLine(couleurs[i]);
            }
            string input = Console.ReadLine();
            bool convertOk = Enum.TryParse<CouleurFeuRouge>(input, out f1.couleur);
            while (convertOk == false)
            {
                Console.WriteLine("Mauvais choix, veuillez réessayer...");
                Console.WriteLine("Vous avez le choix entre :");
                for (int i = 0; i < couleurs.Length; i++)
                {
                    Console.WriteLine(couleurs[i]);
                }
                input = Console.ReadLine();
                convertOk = Enum.TryParse<CouleurFeuRouge>(input, out f1.couleur);
            }

            f1.ChangerCouleur();

            Console.Write("Mon feu rouge est de couleur ");
            switch (f1.couleur)
            {
                case CouleurFeuRouge.Vert:
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case CouleurFeuRouge.Orange:
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    break;
                case CouleurFeuRouge.Rouge:
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
            }

            Console.WriteLine(f1.couleur);
            Console.ResetColor();

            if (f1.PeutPasser)
            {
                Console.WriteLine("J'avance!");
            }
            else
            {
                Console.WriteLine("Je m'arrête!");
            }
        }
    }
}

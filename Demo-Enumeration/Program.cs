namespace Demo_Enumeration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FeuRouge f1 = new FeuRouge();
            f1.PeutPasser = false;
            f1.couleur = CouleurFeuRouge.Rouge;

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

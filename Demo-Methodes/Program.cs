namespace Demo_Methodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] noms = new string[]
            {
                "Anthony",
                "Nathan",
                "Amandine",
                "Ayoub",
                "Christian",
                "Jonathan"
            };

            TabToolBox tb = new TabToolBox();

            Console.WriteLine("Bonjour, quel élève veux-tu vérifier la présence ?");
            string eleve = Console.ReadLine();
            int position = tb.SearchInArray(noms, eleve);
            if (position < 0)
            {
                Console.WriteLine($"Attention, {eleve} est absent...");
            }
            else
            {
                Console.WriteLine($"{eleve} est bien présent.");
            }
        }
    }
}

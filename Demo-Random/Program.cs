namespace Demo_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random RNG = new Random();
            for (int i = 0; i < 10; i++)
            {
                int valeur = RNG.Next(0, 10);
                Console.WriteLine(valeur);
            }
        }
    }
}

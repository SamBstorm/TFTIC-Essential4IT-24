namespace Demo_Enumeration_Flags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Direction vent = Direction.Nord | Direction.Est;

            Console.WriteLine("Le vent souffle en direction : " + (int)vent);

            if (vent.HasFlag(Direction.Nord))
            {
                Console.WriteLine("le nord");
            }
            if (vent.HasFlag(Direction.Sud))
            {
                Console.WriteLine("le sud");
            }
            if (vent.HasFlag(Direction.Ouest))
            {
                Console.WriteLine("l'ouest");
            }
            if (vent.HasFlag(Direction.Est))
            {
                Console.WriteLine("l'est");
            }
        }
    }
}

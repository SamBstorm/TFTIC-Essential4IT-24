namespace Exo_Sup_Tableau_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Exo sup 3:
Dans une application console .net 8.0, à l'aide d'un tableau de double, on veut pouvoir calculer la moyenne des notes d'un élève.

Premièrement	: Renseigner le nombre de notes (min. 2 max. 5)
Deuxièment 	: Encoder les notes (entre 0 et 20)
Dernièrement 	: Afficher la moyenne*/

            /*Premièrement	: Renseigner le nombre de notes (min. 2 max. 5)*/

            Console.WriteLine("Veuillez indiquer le nombre de notes de l'élève (entre 2 et 5):");
            string input = Console.ReadLine();

            int nbNotes;
            bool convertOk = int.TryParse(input, out nbNotes);
            while (convertOk == false || nbNotes < 2 || nbNotes > 5)
            {
                Console.WriteLine("Désolé, mauvaise valeurs, veuillez recommencer...");
                Console.WriteLine("Veuillez indiquer le nombre de notes de l'élève (entre 2 et 5):");
                input = Console.ReadLine();
                convertOk = int.TryParse(input, out nbNotes);
            }

            double[] notes = new double[nbNotes];   //[0,0,0,0,0]
                                                    // 0 1 2 3 4
            /*Deuxièment 	: Encoder les notes (entre 0 et 20)*/

            for (int i = 0; i < notes.Length; i++)
            {
                Console.WriteLine("Veuillez indiquer la note " + (i+1) + " (entre 0 et 20):");
                input = Console.ReadLine();
                convertOk = double.TryParse(input, out notes[i]);
                while (convertOk == false || notes[i] < 0 || notes[i] > 20)
                {
                    Console.WriteLine("Désolé, mauvaise valeurs, veuillez recommencer...");
                    Console.WriteLine("Veuillez indiquer la note " + (i + 1) + " (entre 0 et 20):");
                    input = Console.ReadLine();
                    convertOk = double.TryParse(input, out notes[i]);
                }
            }

            /*Dernièrement 	: Afficher la moyenne*/

            double total = 0;
            for (int i = 0; i < notes.Length; i++)
            {
                total = total + notes[i];
            }
            /*On peut remplacer la boucle for par foreach (Attention, la collection ne peut pas changer)
            foreach(double note in notes)
            {
                total = total + note;
            }*/

            Console.WriteLine("La moyenne de l'élève est de " + (total/nbNotes) + " sur 20.");
        }
    }
}

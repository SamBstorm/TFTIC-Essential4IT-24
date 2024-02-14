namespace Exo_Sup_List_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Exo sup 02 :

Dans une application console .Net 8.0, à l'aide de listes de string, crée une application qui permet de lister des tâches à faire, et de les tranférer dans une liste de tâches finies.

1. Ajouter des tâches à faire
2. Demander si nouvelle tâche, si oui, on recommence encodage, sinon on stoppe.
3. Afficher les tâches avec un numéro.
4. Demander à l'utilisateur un numéro pour définir une tâche finie.
5. Transférer la tâche sélectionnée
6. Afficher la liste de tâche en cours et la liste tâches finies.*/
        
            List<string> taskToDo = new List<string>();
            List<string> taskEnded = new List<string>();
            string input;
            do
            {
                Console.WriteLine("Quelle est la nouvelle tâche ?");
                input = Console.ReadLine();
                if (taskToDo.Contains(input))
                {
                    Console.WriteLine("La tâche " + input + " est déjà présente.");
                }
                else
                {
                    taskToDo.Add(input);
                }
                Console.WriteLine("Ajouter de nouvelle tâche ? (Oui ou non)");
                input = Console.ReadLine(); 
            } while (input == "Oui");

            do
            {
                Console.Clear();
                Console.WriteLine("Votre liste de tâches à faire :");
                for (int i = 0; i < taskToDo.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + taskToDo[i]);
                }
                Console.WriteLine();
                Console.WriteLine("Votre liste de tâches finies :");
                if (taskEnded.Count > 0)
                {
                    for (int i = 0; i < taskEnded.Count; i++)
                    {
                        Console.WriteLine("- " + taskEnded[i]);
                    }
                }
                else
                {
                    Console.WriteLine(" Aucune tâches finies...");
                }
                Console.WriteLine();
                Console.WriteLine("Quelle tâche est finie ?");
                input = Console.ReadLine();
                int choice;
                bool convertOk = int.TryParse(input, out choice);
                while (convertOk == false || choice < 1 || choice > taskToDo.Count)
                {
                    Console.WriteLine("Désolé, mauvaise valeur...");
                    Console.WriteLine("Quelle tâche est finie ?");
                    input = Console.ReadLine();
                    convertOk = int.TryParse(input, out choice);
                }

                string task = taskToDo[choice - 1];

                taskEnded.Add(task);
                taskToDo.Remove(task);
            } while (taskToDo.Count > 0);
        }
    }
}

namespace Exo_Sup_List_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Exo sup 01 :

Dans une application console .Net 8.0, à l'aide d'une liste de string, créez une application qui permet d'encoder une liste d'achat.

1. Demander à l'utilisateur d'encoder un achat.
2. Après chaque encodage demandé si oui ou non il y a un autre article.
3. Si oui, encoder le nouvel article, sinon arrêter l'encodage
4. Afficher la liste de course
5. BONUS : vérifier que l'article ne soit pas 2 fois dans la liste.*/
            
            List<string> course = new List<string>();
            string input;   //ATTENTION : dans la condition du do...while, nous utilisons la variable input.
                            //Si celle-ci est déclarée dans le bloc du 'do', alors on ne peut pas la tester dans le 'while'
                            //Nous devons donc la déclarer avant le bloc 'do'

            /*CTRL + K + S : Permet d'entourer le code sélectionné par un bloc (ici le bloc do...while)*/
            do
            {
                Console.WriteLine("Veuillez indiquer votre achat :");
                input = Console.ReadLine();
                if (course.Contains(input))
                {
                    Console.WriteLine("L'article " + input + " est déjà dans votre liste.");
                }
                else
                {
                    course.Add(input);
                }

                Console.WriteLine("A-t-il un nouvel achat? (Oui ou Non)");
                input = Console.ReadLine(); 
            } while (input == "Oui");

            Console.Clear();
            Console.WriteLine("Voici votre liste de course :");
            for (int i = 0; i < course.Count; i++)
            {
                Console.WriteLine(course[i]);
            }
        }
    }
}

namespace Exo_Sup_Tableau_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Exo sup 2:
Créez un tableau de 10 cases contenant des entiers :
[2, 4, 8, 16, 32, 64, 128, 256, 512, 1024]

Les valeurs du tableaux doivent être introduite par l'application, pas durant l'initialisation.*/

            int[] tableau = new int[10];

            tableau[0] = 2;

            for (int i = 1; i < tableau.Length; i++)
            {
                tableau[i] = tableau[i - 1] * 2;
            }
            
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine(tableau[i]);
            }
        }
    }
}

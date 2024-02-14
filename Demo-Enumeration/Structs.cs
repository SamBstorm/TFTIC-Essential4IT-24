using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Enumeration
{
    public struct FeuRouge
    {
        public bool PeutPasser;
        public CouleurFeuRouge couleur;

        public void ChangerCouleur()
        {
            /* méthode simple à comprendre, mais compliqué à mettre en place...
            if(couleur == CouleurFeuRouge.Rouge)
            {
                couleur = CouleurFeuRouge.Vert;
                PeuPasser = true;
            }
            else if(couleur == CouleurFeuRouge.Orange)
            {
                couleur = CouleurFeuRouge.Rouge;
                PeuPasser = false;
            }
            else if(couleur == CouleurFeuRouge.Vert)
            {
                couleur = CouleurFeuRouge.Orange;
                PeuPasser = false;
            }*/

            couleur = (CouleurFeuRouge)(((int)couleur + 1) % 3);
            PeutPasser = couleur == 0;
        }
    }
}

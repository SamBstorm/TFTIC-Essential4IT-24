using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Enumeration_Flags
{
    public enum Direction
    {
        Nord = 1,
        Sud = 2,
        Ouest = 4,
        Est = 8
    }

    //Valeur voulue = 6 = Sud-Ouest

    //Tableau de bits
    //1 2 4 8 
    //0 1 1 0
}

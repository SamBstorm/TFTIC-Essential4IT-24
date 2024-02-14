using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Methodes
{
    struct TabToolBox
    {
        public int SearchInArray(string[] tab, string value)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == value) return i;
            }
            return -1;
        }


    }
}

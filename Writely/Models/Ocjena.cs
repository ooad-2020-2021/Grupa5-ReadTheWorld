using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Writely.Models
{
    public class Ocjena
    {
        private int ocjena;

        public int get()
        {
            return ocjena;
        }

        public void set(int nova)
        {
            if (nova < 1 || nova > 5)
            {
                //izuzetak
                return;
            }
            ocjena = nova;
        }

        Ocjena (int ocjena)
        {
            if (ocjena < 1 || ocjena > 5)
            {
                //izuzetak
                return;
            }
            this.ocjena = ocjena;
        }
    }
}

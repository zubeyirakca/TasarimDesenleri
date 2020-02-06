using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Ucgen : Sekil
    {

        public Ucgen(CizimKalibi kalip)
        {
            base.(kalip, "Ucgen");
        }


        public override ciz()
        {
            base.ciz();
            kalip.cizgiCiz();
            kalip.cizgiCiz();
            kalip.cizgiCiz();
        }
    }
}

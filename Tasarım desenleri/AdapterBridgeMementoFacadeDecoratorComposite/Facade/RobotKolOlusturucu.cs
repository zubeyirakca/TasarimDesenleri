using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class robotKolOlusturucu
    {
        public IskeletOlusturucu Iskelet { get; set; }
        public MotorOlusturucu Motor { get; set; }
        public robotKolOlusturucu(IskeletOlusturucu Iskelet, MotorOlusturucu Motor)
        {
            this.Iskelet = Iskelet;
            this.Motor = Motor;
        }

        public robotKol Olustur(Renkler renk)
        {
            return new robotKol(Iskelet, Motor, renk);
        }
    }
}

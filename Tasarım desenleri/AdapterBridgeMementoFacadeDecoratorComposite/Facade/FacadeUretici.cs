using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    enum Renkler
    {
        Kırmızı,
        Mavi,
        Mor,
        Yeşil,
        Sarı
    }
    class FacadeUretici
    {

        IskeletOlusturucu iskelet;
        MotorOlusturucu motor;
        robotKolOlusturucu olustur;

        public FacadeUretici()
        {
            iskelet = new IskeletOlusturucu() { x = 3, y = 5, z = true };
            motor = new MotorOlusturucu() { x = 2, y = 4, z = false };
            olustur = new robotKolOlusturucu(iskelet, motor);
        }

        public void robotKolUret()
        {
            robotKol uretilenRobotKol = olustur.Olustur(Renkler.Kırmızı);
        }
    }
}

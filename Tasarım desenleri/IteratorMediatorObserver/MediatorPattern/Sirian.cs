using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    
    class Sirian : Uzayli
    {
        public override void SetGorusIzni(bool Izin)
        {
            Console.WriteLine("Sirian Uzaylı Kodu:{0} görüş izni istiyor...", GorusmeNo);
            base.SetGorusIzni(Izin);
        }
    }
}

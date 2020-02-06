using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
class ZetaReticulums : Uzayli
    {

        public override void SetGorusIzni(bool Izin)
        {
            Console.WriteLine("ZetaReticulums Uzaylı Kodu:{0} görüş izni istiyor...", GorusmeNo);
            base.SetGorusIzni(Izin);
        }
    }
}

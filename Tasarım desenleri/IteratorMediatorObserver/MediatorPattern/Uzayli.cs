using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    abstract class Uzayli
    {
        public IDrLouiseBanks Arabulucu { get; set; }
        public string GorusmeNo { get; set; }
        public bool MesajIzni { get; set; }
        public void GorusIzniIste()
        {
            Arabulucu.GorusIzniCevap(GorusmeNo);
        }
        public virtual void SetGorusIzni(bool Izin)
        {
            MesajIzni = Izin;
            if (MesajIzni)
                Console.WriteLine("Görüş izni verildi.");
            else
                Console.WriteLine("Görüş izni red edildi.");
        }
    }
}

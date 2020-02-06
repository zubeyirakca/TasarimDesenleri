using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IDrLouiseBanks kadin = new BilimAdamlari();
            Uzayli Zeta002 = new ZetaReticulums { GorusmeNo = "Zeta002" };
            Uzayli Zeta1244 = new ZetaReticulums { GorusmeNo = "Zeta1244" };
            Uzayli Sirian145 = new ZetaReticulums { GorusmeNo = "Sirian145" };

            kadin.MesajKayit(Zeta002);
            kadin.MesajKayit(Zeta1244);
            kadin.MesajKayit(Sirian145);
            Zeta002.GorusIzniIste();
            Zeta1244.GorusIzniIste();
            Zeta002.MesajIzni = false;
            Zeta1244.GorusIzniIste();
            Console.ReadKey();
        }
    }
}

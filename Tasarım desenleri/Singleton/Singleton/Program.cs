using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton
{
    public  class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Konya tahmin1 = Konya.nesneUret();
            Konya tahmin2 = Konya.nesneUret();
            Konya tahmin3 = Konya.nesneUret();

            tahmin1.SetData(1500000);

            Console.WriteLine(tahmin1.Sayi());
            Console.WriteLine(tahmin2.Sayi());
            Console.WriteLine(tahmin3.Sayi());

            tahmin1.SetData(1800000); // nüfus değerini değiştirerek nesnenin de değerini değiştiriyoruz.

            Console.WriteLine(tahmin1.Sayi());
            Console.WriteLine(tahmin2.Sayi());
            Console.WriteLine(tahmin3.Sayi());






        }
    }
}

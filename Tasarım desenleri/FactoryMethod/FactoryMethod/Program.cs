using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMethod
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Creator creator = new Creator();
            Product product1 = creator.FactoryMethod(Yakitlar.Benzin);
            Product product2 = creator.FactoryMethod(Yakitlar.Dizel);
            Product product3 = creator.FactoryMethod(Yakitlar.LPG);

            product1.Sec();
            product2.Sec();
            product3.Sec();

            
        }
    }
}

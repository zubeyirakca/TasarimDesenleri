using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Konya
    {
        private static Konya instance; // Kurucumuzu private tanımladık
        private int nufus;
        protected Konya()
        {
        }
        public static Konya nesneUret()
        {
            if(instance==null)
        {
        instance = new Konya();
        }
            return instance;
        }


        public int Sayi()
        {
            return nufus;
        }

        public void SetData(int deger) // yeni değeri atıyoruz.
        {
            nufus = deger;
        }
    }
}
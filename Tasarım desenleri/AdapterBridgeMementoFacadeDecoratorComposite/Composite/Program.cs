using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeSample
{
    //yardımcı enum
    enum enPozisyon
    {
        Baskan = 1,
        TeknikDirektör = 2,
        TeknikEkipYardımcıları = 3,
        Futbolcu = 4
    }

    //component yapısı
    abstract class Klup
    {
        protected string Ad;
        protected enPozisyon Pozisyon;
        public Klup(string Ad, enPozisyon Pozisyon)
        {
            this.Ad = Ad;
            this.Pozisyon = Pozisyon;
        }

        public abstract void Goster(); //Leaf ve Composite de uygulanacak metot
    }

    //Leaf yapısı
    class Futbolcular : Klup
    {
        public Futbolcular(string Ad, enPozisyon Pozisyon)
            : base(Ad, Pozisyon)
        {

        }

        public override void Goster()
        {
            Console.WriteLine("{0} {1}", base.Pozisyon.ToString(), base.Ad);
        }
    }


    //Composite  yapısı
    class TeknikEkip : Klup
    {
        List<Klup> Calisanlari;
        public TeknikEkip(string Ad, enPozisyon Pozisyon)
            : base(Ad, Pozisyon)
        {
            Calisanlari = new List<Klup>();
        }

        public void Ekle(Klup c)
        {
            Calisanlari.Add(c);
        }

        public override void Goster()
        {
            Console.WriteLine("{0} {1}", base.Pozisyon.ToString(), base.Ad);
            foreach (Klup item in Calisanlari)
            {
                item.Goster();
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //İlk olarak Root Composite yi oluşturuyoruz
            TeknikEkip Baskan = new TeknikEkip("Kemalettin", enPozisyon.Baskan);

            //Genel müdürün altında çalışan diğer çalışanları hiyerarşik olarak ekliyoruz
            //Altında eleman olmayan çalışanlar LeafCalisan sınıfı ile ifade edilir.
            TeknikEkip TeknikDirektor = new TeknikEkip("Ahmet ", enPozisyon.TeknikDirektör);
            TeknikDirektor.Ekle(new Futbolcular("mehmet ", enPozisyon.Futbolcu));
            TeknikDirektor.Ekle(new Futbolcular("ayşe ", enPozisyon.Futbolcu));

            //Root komposite altındaki Composite yi ekliyoruz.
            Baskan.Ekle(TeknikDirektor);

            //Composite için döngü ile altındaki Calisan sınıfları, Leaf için sadece kendisi
            Baskan.Goster();

            Console.ReadKey();

        }
    }
}

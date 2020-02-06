using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern___Adapter_App
{
    class Program
    {
        public class Client
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Düşman tankı");
                Console.WriteLine();

                DusmanTankı x11 = new DusmanTankı();
                x11.marka();
                x11.SurucuIsmi("Reha");
                x11.AracSurusHızı();

                Console.WriteLine();
                Console.WriteLine("Robot");
                Console.WriteLine();

                Lastik robot216 = new Lastik();
                robot216.Genislik();
                robot216.Degistiren("Baha");
                robot216.ZeminTutus();


                Console.WriteLine();
                Console.WriteLine("Düşman Robotu");
                Console.WriteLine();

                // Robotumuzu bu şekilde tanımlıyoruz ve yeni robotumuzun da türü IDusman.

                IAraba lastik = new Lastikci(robot216);

                lastik.marka();
                lastik.SurucuIsmi("Esra");
                lastik.AracSurusHızı();



                Console.ReadLine();

            }

        }

    }

    //  Adapter tasarım deseni Structural (Yapısal) bir tasarım deseni olmakla beraber en çok
    //  kullanılan tasarım desenleri arasında yer almaktadır.
    //  Adapter tasarım deseninde 4 temel yapı vardır.Bunlar ;

    //  1- Adaptee : Mevcut sisteme uydurulmak istenen nesne. 
    //  2- Adapter: Mevcut sisteme uydurma işlemini yapan nesne. 
    //  3- Target: İstemcinin ihtiyaç duyduğu interface.
    //  4- Client: İşlemleri gerçekleştirdiğimiz ortak sınıf. İstemci , uygulama. 

    //  Karşılıklı savaş yapılabilecek bir oyun tasarlayacağız.
    //  Oyunumuzda kullanacağımız düşmanlar genelde araçlardan oluşmaktadır ve düşmanların tahmini
    //  metodları interface'imizde tanımlanmıştır.


    public interface IAraba  // Target
    {
        void marka();                        // Aracın üstünde bulunan herhangi bir silah
        void AracSurusHızı();                // Aracın hızı
        void SurucuIsmi(string isim);        // Aracı kullanan kişinin ismi
    }

    // Tanımladığımız interface'i oyunumuzda kullanacağımız tank'a implement ediyoruz ve interface
    // içindeki metodları tankımızda kullanıyoruz.

    // Not implement yapmak için classı tanımladığımız satıra gelip CTRL + . kombinasyonunu kullanıyoruz.

    public class DusmanTankı : IAraba  //  örnek
    {
        Random randomSayi = new Random();

        public void marka()
        {
            int tutusArtisi = randomSayi.Next(20) + 1;
            string tutus = Convert.ToString(tutusArtisi);
            Console.WriteLine("Tank  " + tutus + " hasar vermiştir.");

        }

        public void AracSurusHızı()
        {
            int arachizi = randomSayi.Next(40) + 1;
            string hiz = Convert.ToString(arachizi);
            Console.WriteLine("Tank  " + hiz + " km " + " hizla gitmektedir.");

        }

        public void SurucuIsmi(string isim)
        {
            Console.WriteLine("Tankı " + isim + " kullanmaktadır.");

        }


    }


    //  Tankımız tamamlandı.Tanımladığımız tank oyunumuzda istediğimiz şekilde çalışıyor.
    //  Ancak oyunumuza ilerleyen zamanlarda bir robot eklemek istedik ve robot tankın kullandığı
    //  metodlardan farklı işlevlere sahip.Ancak ekleyeceğimiz yeni robot da aynı zamanda
    //  bir düşman.Yani yine Dusman interface'ini kullanmak istiyoruz.İşte bu noktada
    //  Structural (Yapısal) bir tasarım deseni olan "Adapter" i kullanıyoruz.
    //  İlk olarak robotumuzu "DusmanRobot" adında bir class tanımlıyıoruz.Tanımladığımız classda da
    //  ihtiyacımız olan metodları tanımlıyoruz.


    public class Lastik  // Adaptee
    {
        Random randomSayi = new Random();

        public void Genislik()
        {
            int yumrumHasari = randomSayi.Next(40) + 1;
            string hasar = Convert.ToString(yumrumHasari);
            Console.WriteLine("Robot yumruk atarak  " + hasar + " hasar vermiştir.");

        }

        public void ZeminTutus()
        {
            int robothizi = randomSayi.Next(20) + 1;
            string hiz = Convert.ToString(robothizi);
            Console.WriteLine("Robotun hizi  " + hiz + " km'dir.");
        }

        public void Degistiren(string kullanici)
        {
            Console.WriteLine("Robot  " + kullanici + " tarafından yönetilmektedir.");
        }



    };

    // Şimdi ise en önemli kısım olan Adapter imizi tanımlama kısmındayız.

    public class Lastikci : IAraba  // Adapter
    {

        Lastik robot;

        // İlk olarak Constructor metod yazılır.Bunun nedeni ise yeni yaratacağımız robotun IDusmandan 
        // türünde olmasını istiyor olmamızdır.

        public Lastikci(Lastik yeniRobot)
        {
            robot = yeniRobot;
        }


        public void marka()
        {
            robot.Genislik();
        }

        public void AracSurusHızı()
        {
            robot.ZeminTutus();
        }

        public void SurucuIsmi(string isim)
        {
            robot.Degistiren(isim);
        }


    }
}

using System;

namespace chain_of_res_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            ErkekKuaforu koltuk1 = new KuaforAli();
            ErkekKuaforu koltuk2 = new KuaforIsmet();
            ErkekKuaforu koltuk3 = new KuaforEyup();

            koltuk1.SonrakiHandler = koltuk2;
            koltuk2.SonrakiHandler = koltuk3;

            koltuk1.Tras("İlk kişi");
            koltuk1.Tras("İkinci kişi");
            koltuk1.Tras("Üçüncü kişi");
            koltuk1.Tras("Dördüncü kişi");
            koltuk1.Tras("Besinci kişi");


            Console.ReadKey();

        }
    }
}

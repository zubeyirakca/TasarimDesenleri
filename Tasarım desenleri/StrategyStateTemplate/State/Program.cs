using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template

{
    public abstract class YemekYapan
    {
        public virtual void servisYap()
        {
            Console.WriteLine("Servis Yapıldı.");
        }

        // PrimitiveOperation
        public abstract void Icerik();

        public virtual void MalzemeleriHazirla()
        {
            Console.WriteLine("Malzemeler Hazırlandı");
        }

        // TemplateMethod
        public void Pisir()
        {
            servisYap();
            Icerik();
            MalzemeleriHazirla();
            Console.WriteLine("Pişirildi");
        }
    }

    public class Corbaci : YemekYapan
    {
        public override void Icerik()
        {
            Console.WriteLine("Çorba yapıldı.");
        }
    }

    public class Pilavci : YemekYapan
    {
        public override void Icerik()
        {
            Console.WriteLine("Pilav yapıldı.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            YemekYapan corba = new Corbaci();
            corba.Pisir();

            Console.WriteLine();

            YemekYapan pilav = new Pilavci();
            pilav.Pisir();

            Console.ReadLine();
        }
    }
}


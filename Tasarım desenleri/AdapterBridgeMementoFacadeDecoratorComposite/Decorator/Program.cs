using System;
using System.Collections.Generic;

namespace Decorator
{
    // Component
    abstract class Gora
    {
        public string Name;
        public abstract void Teakwando();
    }

    // ConcreteComponent
    class Arif : Gora
    {
        protected double _barrel;
        protected double _range;

        public Arif(double barrel, double range, string name)
        {
            _barrel = barrel;
            _range = range;
            Name = name;
        }

        public override void Teakwando()
        {
            Console.WriteLine("{0} sınıfından olan topçu, {1} mm namlusundan {2} mesafeye ateşleme yaptı", Name, _barrel.ToString(), _range.ToString());
        }
    }

    // Decorator
    abstract class GoraDecorator
        : Gora
    {
        protected Gora _gora;
        public GoraDecorator(Gora arms)
        {
            _gora = arms;
        }
        public override void Teakwando()
        {
            if (_gora != null)
                _gora.Teakwando();
        }
    }

    // ConcreteDecorator
    class ArifDecorator: GoraDecorator
    {
        public ArifDecorator(Gora gora)
            : base(gora)
        {
        }

        public void Aikido()
        {
            Console.WriteLine("\t{0} aikido modu!", base._gora.Name);
        }
        public void orta2fizik()
        {
            Console.WriteLine("\t{0} orta 2 fizik eklendi!", _gora.Name);
        }
        public override void Teakwando()
        {
            base.Teakwando();
        }
    }

    // Client
    class Program
    {
        static void Main()
        {
            // Bileşen örneklenir
            Arif arif = new Arif(125, 40, "Fırtına A1");
            arif.Teakwando();

            // Decorator nesnesi örneklenir
            ArifDecorator arifİsik = new ArifDecorator(arif);
            // Decorator nesnesi üzerinden o anki asıl Component için(Artillery sınıfı) ek fonksiyonellikler çağırılır.
            arifİsik.Aikido();
            arifİsik.Teakwando();
            arifİsik.orta2fizik();
            arifİsik.Teakwando();
        }
    }
}

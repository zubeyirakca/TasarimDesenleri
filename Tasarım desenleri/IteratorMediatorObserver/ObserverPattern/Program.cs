using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        public static void Main(string[] args)
        {

            ConcreteSubject araba = new ConcreteSubject();
            araba.Subscribe(new ConcreteObserver.Galerici());
            araba.Subscribe(new ConcreteObserver.Sahsisurucu());
            araba.Subscribe(new ConcreteObserver.Koleksiyoner());

            araba.Tipi = "Otomobil";
            araba.Model = 2002;
            araba.Hacim = 1800;
            araba.Degeri = 45000;
            araba.MTVguncellendi = true;

            Console.ReadKey(true);
        }
    }
}

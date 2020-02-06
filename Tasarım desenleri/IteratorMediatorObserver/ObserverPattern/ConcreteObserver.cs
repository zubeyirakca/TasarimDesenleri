using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class ConcreteObserver
    {
        public class Galerici : Observer
        {
            public override void Update()
            {
                Console.WriteLine("Galericiler MTV'ye gelen zamı öğrendi.");
            }
        }

        public class Sahsisurucu : Observer
        {
            public override void Update()
            {
                Console.WriteLine("Şahsi sürücüler MTV'ye gelen zamı öğrendi.");
            }
        }

        public class Koleksiyoner : Observer
        {
            public override void Update()
            {
                Console.WriteLine("Koleksiyonerler MTV'ye gelen zamı öğrendi.");
            }
        }
    }
}

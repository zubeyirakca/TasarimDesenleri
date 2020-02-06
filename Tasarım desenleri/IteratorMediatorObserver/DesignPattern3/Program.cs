using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern3
{
    class Program
    {
        static void Main(string[] args)
        {
            EntegreAggregate aggregate = new EntegreAggregate();
            aggregate.Add(new Entegreler { Id = 1, Adi = "MCP1525T", Gorev = "Voltaj referans entegresidir." });
            aggregate.Add(new Entegreler { Id = 2, Adi = "INA114AU ", Gorev = "Ölçüm amplifikatörleri entegresidir. " });
            aggregate.Add(new Entegreler { Id = 3, Adi = "DS1232 ", Gorev = "Güç kontrol entegresidir." });
            aggregate.Add(new Entegreler { Id = 4, Adi = "74LS04 ", Gorev = "Invertör ve kapı entegresidir." });
            aggregate.Add(new Entegreler { Id = 5, Adi = "ULN2003 ", Gorev = "NPN tipi transistörlerden oluşan seri transistör entegresidir." });

            IIterator iterasyon = aggregate.CreateIterator();
            while (iterasyon.HasItem())
            {
                Console.WriteLine($"ID : {iterasyon.CurrentItem().Id}\nAdı : {iterasyon.CurrentItem().Adi}\nGörevi : {iterasyon.CurrentItem().Gorev}\n");
                iterasyon.NextItem();
            }

            Console.Read();
        }
    }
}

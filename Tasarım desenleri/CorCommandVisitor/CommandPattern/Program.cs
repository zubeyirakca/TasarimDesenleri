using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Araba ileri mi gitsin geri mi ?");
            string cmd = Console.ReadLine();

            UzaktanKumandaliAraba car = new UzaktanKumandaliAraba();
            ICommand arabaileri = new Ilerigit(car);
            ICommand arabageri = new Gerigit(car);

            Kumanda s = new Kumanda();

            if (cmd == "ileri")
            {
                s.StoreAndExecute(arabaileri);
            }
            else if (cmd == "geri")
            {
                s.StoreAndExecute(arabageri);
            }
            else
            {
                Console.WriteLine("Command \"ON\" or \"OFF\" is required.");
            }

            Console.ReadKey();
        }
    }
}

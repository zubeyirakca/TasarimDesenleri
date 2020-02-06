using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _163301060_Odev5
{
    class Program


    {
        static void Main()
        {
            Console.WriteLine("Hello!, Please select the mode of transport to get the travel time between source and destination: \ndurantop \nkontratak \nuzaktansut");
            var userStrategy = Console.ReadLine().ToLower();
            Console.WriteLine("\nUser has selected *" + userStrategy + "* as mode of transport\n");
            Console.WriteLine("\n*****************************************************************************************************\n");
            switch (userStrategy)
            {
                case "durantop":
                    new GolTarzi(new DuranTop()).GoalTactic("Fenerbahçe", "Galatasaray");
                    break;
                case "kontratak":
                    new GolTarzi(new Kontratak()).GoalTactic("Fenerbahçe", "Galatasaray");
                    break;
                case "uzaktansut":
                    new GolTarzi(new UzaktanSut()).GoalTactic("Fenerbahçe", "Galatasaray");
                    break;
                default:
                    Console.WriteLine("You have chosen an invalid mode of transport.");
                    break;
            }
        }
    }
}

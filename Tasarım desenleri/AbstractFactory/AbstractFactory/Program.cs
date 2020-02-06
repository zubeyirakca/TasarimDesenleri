using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main()
        {
            IRoman yasark = new YasarKemal();
            BookClient yasarC = new BookClient(yasark);

            Console.WriteLine("Yaşar Kemal Kitapları");
            Console.WriteLine(yasarC.GetDBookDetails());
            Console.WriteLine(yasarC.GetEBookDetails());

            IRoman albert = new AlbertCamus();
            BookClient albertC = new BookClient(albert);

            Console.WriteLine("Albert Camus Kitapları");
            Console.WriteLine(albertC.GetDBookDetails());
            Console.WriteLine(albertC.GetEBookDetails());

            Console.ReadKey();
        }
    }
}

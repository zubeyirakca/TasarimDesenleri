using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Footballer ftb = new Footballer(); // ftb adında bir nesne ürettik ve özelliklerini girdik.
            ftb.Name = "Mehmet";
            ftb.Position = "Midfielder";
            ftb.Nationality = "Turkish";

            Footballer ftbCopy = (Footballer)ftb.Clone(); // ftb nesnesinin klonunu oluşturuyoruz.
            ftbCopy.Name = "Arif"; 

            Console.WriteLine(ftb.GetDetails()); //ana nesnemizi ekrana bastırıyoruz
            Console.WriteLine(ftbCopy.GetDetails());//klon nesnemizi ekrana bastırıyoruz

            BasketballPlayer bskt = new BasketballPlayer(); //bskt adında bir nesne ürettik ve özelliklerini girdik.
            bskt.Name = "Klay Thompson";
            bskt.Team = "Golden State Warriors";
            bskt.Points = 33;

            BasketballPlayer bsktCopy = (BasketballPlayer)bskt.Clone(); //bskt nesnesinin klonunu oluşturuyoruz.
            bsktCopy.Name = "Kevin Durant";
            bsktCopy.Points = 37;

            Console.WriteLine(bskt.GetDetails()); //ana nesnemizi ekrana bastırıyoruz
            Console.WriteLine(bsktCopy.GetDetails());//klon nesnemizi ekrana bastırıyoruz


        }
    }
}
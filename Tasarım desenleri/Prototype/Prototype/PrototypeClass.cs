using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public interface IEmployee // Prototype interface'ini kuruyoruz.
    {
        IEmployee Clone();
        string GetDetails();
    }

   
    public class Footballer : IEmployee //Özelliklerin bulunduğu ana sınıf
    {
        public int WordsPerMinute { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Nationality { get; set; }

        public IEmployee Clone()
        {
            return (IEmployee)MemberwiseClone(); // Klon veriyi geri döndürüyoruz

        
        }

        public string GetDetails()
        {
            return string.Format("{0} - {1} - {2}", Name, Position, Nationality);
        }
    }

    public class BasketballPlayer : IEmployee//Özelliklerin bulunduğu ana sınıfımız
    {
        public int WordsPerMinute { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }

        public int Points { get; set; }

        public IEmployee Clone()
        {
            return (IEmployee)MemberwiseClone(); //Klon veriyi geri döndürüyoruz.

        }

        public string GetDetails() // Ekrana basma formatımızı belirliyoruz
        {
            return string.Format("{0} - {1} - {2}pts", Name, Team, Points);
        }
    }
}

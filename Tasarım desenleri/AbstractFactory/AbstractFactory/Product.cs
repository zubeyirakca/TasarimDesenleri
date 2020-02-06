using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class İnceMemed : IBaskıKitap
    {
        public string GetBookDetails()
        {
            return "Kitap İsmi: İnce Memed\nSayfa Sayısı: 476\nFiyatı: 45TL \n";
        }
    }

    class Yabanci : IBaskıKitap
    {
        public string GetBookDetails()
        {
            return "Kitap İsmi: Yabancı\nSayfa Sayısı: 246\nFiyatı: 25TL \n";
        }
    }

    class Teneke : IEKitap
    {
        public string GetBookDetails()
        {
            return "Kitap İsmi: Teneke \nSayfa Sayısı: 401 \nFiyatı: 17 \n\n";
        }
    }

    class Dusus : IEKitap
    {
        public string GetBookDetails()
        {
            return "Kitap İsmi: Düşüş \nSayfa Sayısı: 332 \nFiyatı: 21 \n";
        }
    }

}

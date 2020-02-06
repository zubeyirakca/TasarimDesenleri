using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class BookClient
    {
        IBaskıKitap dBook;
        IEKitap eBook;

        public BookClient(IRoman factory)
        {
            dBook = factory.GetBaskıKitap();
            eBook = factory.GetEKitap();
        }

        public string GetDBookDetails()
        {
            return dBook.GetBookDetails();
        }

        public string GetEBookDetails()
        {
            return eBook.GetBookDetails();
        }
    }
}

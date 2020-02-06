using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class YasarKemal : IRoman
    {
        public IBaskıKitap GetBaskıKitap()
        {
            return new İnceMemed();
        }

        public IEKitap GetEKitap()
        {
            return new Teneke();
        }

       
    }
}

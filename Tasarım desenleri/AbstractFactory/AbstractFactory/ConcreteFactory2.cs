using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AlbertCamus : IRoman
    {
        public IBaskıKitap GetBaskıKitap()
        {
            return new Yabanci();
        }

        public IEKitap GetEKitap()
        {
            return new Dusus();
        }
    }
}

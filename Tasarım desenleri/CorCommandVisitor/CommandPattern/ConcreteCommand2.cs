using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Gerigit : ICommand
    {
        private UzaktanKumandaliAraba _araba;

        public Gerigit(UzaktanKumandaliAraba araba)
        {
            _araba = araba;
        }

        public void Execute()
        {
            _araba.geri();
        }
    }
}

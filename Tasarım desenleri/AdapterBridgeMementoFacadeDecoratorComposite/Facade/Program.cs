﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            FacadeUretici uretici = new FacadeUretici();
            uretici.robotKolUret();

            Console.Read();
        }
    }
}

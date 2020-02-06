using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern3
{
    interface IIterator
    {
        
        bool HasItem();
        Entegreler NextItem();
        Entegreler CurrentItem();
    }
}

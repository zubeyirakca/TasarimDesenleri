using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _163301060_Odev5
{
    public interface IStrategy
    {
        string GoalTactic(string source, string destination);
    }
}

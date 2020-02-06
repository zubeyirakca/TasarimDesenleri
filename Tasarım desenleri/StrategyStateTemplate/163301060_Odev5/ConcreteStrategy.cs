using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _163301060_Odev5
{
    public class DuranTop : IStrategy
    {
        public string GoalTactic(string source, string destination)
        {
            return "It takes 70 minutes to reach from " + source + " to " + destination + " using Durantop.";
        }
    }
    public class Kontratak : IStrategy
    {
        public string GoalTactic(string source, string destination)
        {
            return "It takes 60 minutes to reach from " + source + " to " + destination + " using Kontratak.";
        }
    }
    public class UzaktanSut : IStrategy
    {
        public string GoalTactic(string source, string destination)
        {
            return "It takes 65 minutes to reach from " + source + " to " + destination + " UzaktanSut.";
        }
    }
}

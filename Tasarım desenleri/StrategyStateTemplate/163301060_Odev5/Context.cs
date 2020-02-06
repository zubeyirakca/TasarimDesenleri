using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _163301060_Odev5
{
    public class GolTarzi
    {
        private IStrategy _strategy;
        public GolTarzi(IStrategy chosenStrategy)
        {
            _strategy = chosenStrategy;
        }
        public void GoalTactic(string source, string destination)
        {
            var result = _strategy.GoalTactic(source, destination);
            Console.WriteLine(result);
        }
    }
}

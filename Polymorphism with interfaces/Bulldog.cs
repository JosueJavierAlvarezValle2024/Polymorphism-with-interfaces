using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_with_interfaces
{
    internal class Bulldog : IDog
    {
        public string Bark()
        {
            return "Bulldog barks";
        }

        public string Sleep()
        {
            return "Bulldog sleeps";
        }

        public string Eat()
        {
            return "Bulldog eating";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_with_interfaces
{
    internal class Chihuahua : IDog
    {
        public string Bark()
        {
            return "Chihuahua barks";
        }

        public string Sleep()
        {
            return "Chihuahua sleeps";
        }

        public string Eat()
        {
            return "Chihuahua eating";
        }
    }
}

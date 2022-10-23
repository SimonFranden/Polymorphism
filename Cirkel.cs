using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Cirkel : Geometri
    {
        public double Radius { get; set; }

        public Cirkel()
        {
            Radius = 5;
        }
        public override double Area()
        {
            return Radius * Radius * 3.1415;
        }
    }
}

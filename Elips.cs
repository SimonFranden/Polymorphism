using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Elips : Geometri
    {
        public double MajorAxis { get; set; }
        public double MinorAxis { get; set; }

        public Elips()
        {
            MajorAxis = 14;
            MinorAxis = 8;
        }
        public override double Area()
        {
            return (MajorAxis / 2) * (MinorAxis / 2) * 3.1415;
        }
    }
}

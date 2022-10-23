using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Fyrkant : Geometri
    {
        public double Width { get; set; }
        public Fyrkant()
        {
            Width = 5;
        }

        public override double Area()
        {
            return Width * 2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Rektangel : Geometri
    {

        public double Height { get; set; }
        public double Width { get; set; }

        public Rektangel()
        {
            Height = 10;
            Width = 5;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }
}

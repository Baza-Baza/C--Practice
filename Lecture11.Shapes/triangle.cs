using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture11.Shapes
{
    class triangle : Shape
    {
        public int height = 6;

        public override void Area()
        {
            base.Area();
            S = 1/2 * side * height;
        }

    }
}

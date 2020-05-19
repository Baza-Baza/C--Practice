using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture11.Shapes
{
    class Circle : Shape
    {
        public int R = 4;

        public override void Area()
        {
            base.Area();
            S = 3 / 14 * R ^ 2;
        }
    }
}

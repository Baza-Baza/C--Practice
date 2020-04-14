using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture11.Shapes
{
    class Shape
    {
        public int side = 2;
        public int S;

      public virtual void Area() 
        {
            S = side ^ 2;
        }
    }
}

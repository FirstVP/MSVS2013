using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task1
{
    abstract class Shape
    {
        protected Point CenterPoint;

        protected Shape(Point CenterPoint)
        {
            this.CenterPoint = CenterPoint;
        }

        protected abstract void Draw();
    }
   
}

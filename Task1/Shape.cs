using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Task1
{
    abstract class Shape
    {
        protected Point CenterPoint;
        protected int Colour;

        protected Shape(int firstCentralCoordinate, int secondCentralCoordinate, int colour)
        {
            this.CenterPoint.X = firstCentralCoordinate;
            this.CenterPoint.Y = secondCentralCoordinate;
            this.Colour = colour;
        }

        public abstract void Draw(Panel drawPanel);
    }
   
}

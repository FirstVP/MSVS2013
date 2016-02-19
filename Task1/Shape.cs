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

        protected Shape(int firstCentralCoordinate, int secondCentralCoordinate)
        {
            this.CenterPoint.X = firstCentralCoordinate;
            this.CenterPoint.Y = secondCentralCoordinate;
        }

        public abstract void Draw(Panel drawPanel);
    }
   
}

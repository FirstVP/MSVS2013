using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
   abstract class OneParametricShape: Shape
    {
        protected int MainParameter;

        protected OneParametricShape(int firstCentralCoordinate, int secondCentralCoordinate, int mainParameter)
            : base(firstCentralCoordinate, secondCentralCoordinate)
        {
            this.MainParameter = mainParameter;
        }

        public abstract override void Draw(Panel drawPanel);
    }
}

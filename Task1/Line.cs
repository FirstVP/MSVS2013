using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Task1
{
    class Line: Shape
    {
        Point EndPoint;
       
        public Line (int firstCentralCoordinate, int secondCentralCoordinate, int firstEndCoordinate, int secondEndCoordinate, int color): base (firstCentralCoordinate, secondCentralCoordinate, color)
        {
            this.EndPoint.X = firstEndCoordinate;
            this.EndPoint.Y = secondEndCoordinate;
        }

        public override void Draw(Panel drawPanel)
        {
            Graphics mainGrapics = drawPanel.CreateGraphics();
            mainGrapics.DrawLine(new Pen(Color.FromArgb(Colour)), CenterPoint.X, CenterPoint.Y, EndPoint.X, EndPoint.Y);
        }

    }
}

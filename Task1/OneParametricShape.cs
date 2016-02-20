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

        protected OneParametricShape(int firstCentralCoordinate, int secondCentralCoordinate, int mainParameter, int colour)
            : base(firstCentralCoordinate, secondCentralCoordinate, colour)
        {
            this.MainParameter = mainParameter;
        }

        public abstract override void Draw(Panel drawPanel);
    }


    class Square: OneParametricShape
    {
        public Square(int firstCentralCoordinate, int secondCentralCoordinate, int mainParameter, int colour)
            : base(firstCentralCoordinate, secondCentralCoordinate, mainParameter, colour)
        {
            
        }
        public override void Draw(Panel drawPanel)
        {
            Graphics mainGrapics = drawPanel.CreateGraphics();
            mainGrapics.DrawRectangle(new Pen(Color.FromArgb(Colour)), CenterPoint.X - MainParameter / 2, CenterPoint.Y - MainParameter / 2, MainParameter, MainParameter);
        }
    }



    class Circle : OneParametricShape
    {
        public Circle(int firstCentralCoordinate, int secondCentralCoordinate, int mainParameter, int colour)
            : base(firstCentralCoordinate, secondCentralCoordinate, mainParameter, colour)
        {

        }
        public override void Draw(Panel drawPanel)
        {
            Graphics mainGrapics = drawPanel.CreateGraphics();
            mainGrapics.DrawEllipse(new Pen(Color.FromArgb(Colour)), CenterPoint.X - MainParameter, CenterPoint.Y - MainParameter, MainParameter * 2, MainParameter * 2);
        }
    }

    class EquilateralTriangle : OneParametricShape
    {
        public EquilateralTriangle(int firstCentralCoordinate, int secondCentralCoordinate, int mainParameter, int colour)
            : base(firstCentralCoordinate, secondCentralCoordinate, mainParameter, colour)
        {

        }

        public override void Draw(Panel drawPanel)
        {
            const int pointCount = 3;

            int halfMainParameter = MainParameter / 2;

            Point[] points = new Point[pointCount];
            points[0] = new Point(CenterPoint.X, CenterPoint.Y - halfMainParameter);
            points[1] = new Point(CenterPoint.X - halfMainParameter, CenterPoint.Y + halfMainParameter);
            points[2] = new Point(CenterPoint.X + halfMainParameter, CenterPoint.Y + halfMainParameter);

            Graphics mainGrapics = drawPanel.CreateGraphics();

            Pen currentPen = new Pen(Color.FromArgb(Colour));

            mainGrapics.DrawLine(currentPen, points[0], points[1]);
            mainGrapics.DrawLine(currentPen, points[1], points[2]);
            mainGrapics.DrawLine(currentPen, points[2], points[0]);
   
        }
    }
      
}

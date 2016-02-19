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


    class Square: OneParametricShape
    {
         public Square(int firstCentralCoordinate, int secondCentralCoordinate, int mainParameter)
            : base(firstCentralCoordinate, secondCentralCoordinate, mainParameter)
        {
            
        }
        public override void Draw(Panel drawPanel)
        {
            Graphics mainGrapics = drawPanel.CreateGraphics();
            mainGrapics.DrawRectangle(new Pen(Color.Red), CenterPoint.X - MainParameter / 2, CenterPoint.Y - MainParameter / 2, MainParameter, MainParameter);
        }
    }



    class Circle : OneParametricShape
    {
        public Circle(int firstCentralCoordinate, int secondCentralCoordinate, int mainParameter)
            : base(firstCentralCoordinate, secondCentralCoordinate, mainParameter)
        {

        }
        public override void Draw(Panel drawPanel)
        {
            Graphics mainGrapics = drawPanel.CreateGraphics();
            mainGrapics.DrawEllipse(new Pen(Color.Red), CenterPoint.X - MainParameter, CenterPoint.Y - MainParameter, MainParameter * 2, MainParameter * 2);
        }
    }

    class EquilateralTriangle : OneParametricShape
    {
        public EquilateralTriangle(int firstCentralCoordinate, int secondCentralCoordinate, int mainParameter)
            : base(firstCentralCoordinate, secondCentralCoordinate, mainParameter)
        {

        }
        public override void Draw(Panel drawPanel)
        {
            int halfMainParameter = MainParameter / 2;
            Graphics mainGrapics = drawPanel.CreateGraphics();
            mainGrapics.DrawLine(new Pen(Color.Red), CenterPoint.X, CenterPoint.Y - halfMainParameter, CenterPoint.X - halfMainParameter, CenterPoint.Y + halfMainParameter);
            mainGrapics.DrawLine(new Pen(Color.Red), CenterPoint.X - halfMainParameter, CenterPoint.Y + halfMainParameter, CenterPoint.X + halfMainParameter, CenterPoint.Y + halfMainParameter);
            mainGrapics.DrawLine(new Pen(Color.Red), CenterPoint.X + halfMainParameter, CenterPoint.Y + halfMainParameter, CenterPoint.X, CenterPoint.Y - halfMainParameter);
        }
    }
      
}

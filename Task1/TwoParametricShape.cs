using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Task1
{
    abstract class TwoParametricShape: OneParametricShape
    {
        protected int SecondaryParameter;

        protected TwoParametricShape(int firstCentralCoordinate, int secondCentralCoordinate, int mainParameter, int secondaryParameter, int colour)
            : base(firstCentralCoordinate, secondCentralCoordinate, mainParameter, colour)
        {
            this.SecondaryParameter = secondaryParameter;
        }

        public abstract override void Draw(Panel drawPanel);
    }

    class Rectangle : TwoParametricShape
    {
        public Rectangle(int firstCentralCoordinate, int secondCentralCoordinate, int mainParameter, int secondaryParameter, int colour)
            : base(firstCentralCoordinate, secondCentralCoordinate, mainParameter, secondaryParameter, colour)
        {
            
        }
        public override void Draw(Panel drawPanel)
        {
            Graphics mainGrapics = drawPanel.CreateGraphics();
            mainGrapics.DrawRectangle(new Pen(Color.FromArgb(Colour)), CenterPoint.X - MainParameter / 2, CenterPoint.Y - SecondaryParameter / 2, MainParameter, SecondaryParameter);
        }
    }
    class Ellipse : TwoParametricShape
    {
        public Ellipse(int firstCentralCoordinate, int secondCentralCoordinate, int mainParameter, int secondaryParameter, int colour)
            : base(firstCentralCoordinate, secondCentralCoordinate, mainParameter, secondaryParameter, colour)
        {

        }
        public override void Draw(Panel drawPanel)
        {
            Graphics mainGrapics = drawPanel.CreateGraphics();
            mainGrapics.DrawEllipse(new Pen(Color.FromArgb(Colour)), CenterPoint.X - MainParameter, CenterPoint.Y - SecondaryParameter, MainParameter * 2, SecondaryParameter * 2);
        }
    }
}

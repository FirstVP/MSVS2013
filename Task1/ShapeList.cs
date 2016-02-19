using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    class ShapeList
    {
        public ShapeList(Panel drawPanel)
        {
            List<Shape> exampleList = new List<Shape>();
            Line line = new Line(15, 0, 15, 100);
            Square square = new Square(250, 100, 100);
            Circle circle = new Circle(250, 100, 100);
            EquilateralTriangle triangle = new EquilateralTriangle(250, 100, 100);

            exampleList.Add(line);
            exampleList.Add(square);
            exampleList.Add(circle);
            exampleList.Add(triangle);

            foreach (Shape currentShape in exampleList)
            {
                currentShape.Draw(drawPanel);
            }

        }
    }
}

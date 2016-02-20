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
        private List<Shape> currentList;
        public ShapeList()
        {
            currentList = new List<Shape>();
            Line line = new Line(15, 0, 15, 100, 0x78FF0000);
            Square square = new Square(550, 110, 100, 0x71FFAA55); 
            Circle circle = new Circle(250, 100, 100, 0x780000FF);
            EquilateralTriangle triangle = new EquilateralTriangle(350, 200, 100, 0x780FF0FF);
            Rectangle rectangle = new Rectangle(70, 300, 100, 50, 0x78AAAAC0);
            Ellipse ellipse = new Ellipse(250, 300, 100, 50, 0x78FF0FB0);

            currentList.Add(line);
            currentList.Add(square);
            currentList.Add(circle);
            currentList.Add(triangle);
            currentList.Add(rectangle);
            currentList.Add(ellipse);

        }

        public void DrawList(Panel drawPanel)
        {
            foreach (Shape currentShape in currentList)
            {
                currentShape.Draw(drawPanel);
            }
        }
    }
}

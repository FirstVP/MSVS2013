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
            Line line = new Line(10, 20, 10, 50);


            exampleList.Add(line);

            foreach (Shape currentShape in exampleList)
            {
                currentShape.Draw(drawPanel);
            }

        }
    }
}

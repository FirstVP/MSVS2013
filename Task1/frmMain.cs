using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Task1
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

           

          //  Line line = new Line(10, 10, 10, 10);
          //  line.Draw(panel1);

            



        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            ShapeList mainList = new ShapeList(panel1);
        }

      




    }
}

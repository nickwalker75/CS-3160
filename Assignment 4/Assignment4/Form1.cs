using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // init pen colors
            Pen black = new Pen(Color.Black, 5);

            // grid points
            // vertical lines
            Point vert1start = new Point(150,150);
            Point vert1end = new Point(150,375);
            Point vert2start = new Point(225, 150);
            Point vert2end = new Point(225, 375);

            // horizopntal lines
            Point hor1start = new Point(75, 225);
            Point hor1end = new Point(300, 225);
            Point hor2start = new Point(75, 300);
            Point hor2end = new Point(300, 300);

            // outer square
            Point topLeft = new Point(75, 150);
            Point bottomLeft = new Point(75, 375);
            Point topRight = new Point(300, 150);
            Point bottomRight = new Point(300, 375);

            // Draw grid
            e.Graphics.DrawLine(black, vert1start, vert1end);
            e.Graphics.DrawLine(black, vert2start, vert2end);
            e.Graphics.DrawLine(black, hor1start, hor1end);
            e.Graphics.DrawLine(black, hor2start, hor2end);



        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}

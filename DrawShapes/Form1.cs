using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawShapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Exercise 1a
        private void buttonDrawLine_Click(object sender, EventArgs e)
        {
            Graphics canvas = pictureBoxDisplay.CreateGraphics();
            Pen bluePen = new Pen(Color.Blue, 5);
            canvas.DrawLine(bluePen, 10, 10, 100, 100);
        }

        // Exercise 1b 
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Exercise 1c
        private void buttonDrawSquare_Click(object sender, EventArgs e)
        {
            Graphics canvas = pictureBoxDisplay.CreateGraphics();
            Pen bluePen = new Pen(Color.Blue, 5);
            Pen redPen = new Pen(Color.Red, 5);
            Pen greenPen = new Pen(Color.Green, 5);
            Pen blackPen = new Pen(Color.Black, 5);

            canvas.DrawLine(bluePen, 10, 10, 10, 100);
            canvas.DrawLine(redPen, 10, 100, 100, 100);
            canvas.DrawLine(greenPen, 100, 100, 100, 10);
            canvas.DrawLine(blackPen, 100, 10, 10, 10);
        }
    }
}

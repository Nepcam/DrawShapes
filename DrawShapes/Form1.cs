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

        private void buttonDrawLine_Click(object sender, EventArgs e)
        {
            // Creates the Graphics object and links it to the pictureBoxDisplay
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            // Created Pen objects
            Pen bluePen = new Pen(Color.Blue, 5);
            Pen redPen = new Pen(Color.Red, 5);

            // Created a DrawLine object and combined the paper and Pen objects
            paper.DrawLine(bluePen, 10, 10, 100, 100);
            paper.DrawLine(redPen, 200, 200, 400, 400);
        }
        // Closes the application 
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDrawSquare_Click(object sender, EventArgs e)
        {
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen bluePen = new Pen(Color.Blue, 5);
            Pen redPen = new Pen(Color.Red, 5);
            Pen greenPen = new Pen(Color.Green, 5);
            Pen blackPen = new Pen(Color.Black, 5);

            paper.DrawLine(bluePen, 10, 10, 10, 100);
            paper.DrawLine(redPen, 10, 100, 100, 100);
            paper.DrawLine(greenPen, 100, 100, 100, 10);
            paper.DrawLine(blackPen, 100, 10, 10, 10);

        }
    }
}

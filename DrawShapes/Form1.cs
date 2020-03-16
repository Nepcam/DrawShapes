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
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen pen1 = new Pen(Color.Blue, 5);
            Pen pen2 = new Pen(Color.Red, 5);

            paper.DrawLine(pen1, 10, 10, 100, 100);
            paper.DrawLine(pen2, 200, 200, 400, 400);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDrawSquare_Click(object sender, EventArgs e)
        {
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen pen1 = new Pen(Color.Blue, 5);
            Pen pen2 = new Pen(Color.Red, 5);
            Pen pen3 = new Pen(Color.Green, 5);
            Pen pen4 = new Pen(Color.Black, 5);

            paper.DrawLine(pen1, 10, 10, 10, 100);
            paper.DrawLine(pen2, 10, 100, 100, 100);
            paper.DrawLine(pen3, 100, 100, 100, 10);
            paper.DrawLine(pen4, 100, 10, 10, 10);

        }
    }
}

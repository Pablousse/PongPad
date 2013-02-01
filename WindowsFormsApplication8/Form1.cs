using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            drawObstacle(e);
            base.OnPaint(e);
        }
        int y;

        public void drawObstacle(PaintEventArgs e)
        {
            // Create solid brush.
            SolidBrush redBrush = new SolidBrush(Color.Black);

            // Create rectangle for ellipse. 
            Rectangle rect = new Rectangle(0, y, 10, 150);

            // Fill ellipse on screen.
            e.Graphics.FillRectangle(redBrush, rect);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down) 
            {
                y += 10;
                Refresh();
            }
            else if (e.KeyData == Keys.Up)
            {
                y -= 10;
                Refresh();
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_1
{
    class Square : Figure
    {
        int sideLength;
        Rectangle rectangle;

        public Square(int x, int y, int sideLength)
        {
            this.x = x;
            this.y = y;
            this.sideLength = sideLength;
        }

        public override void DrawBlack(Graphics graphics)
        {
            rectangle = new Rectangle(x, y, sideLength, sideLength);
            graphics.FillRectangle(Brushes.Black, rectangle);
        }

        public override void HideDrawingBackGround(Graphics graphics)
        {
            graphics.FillRectangle(Brushes.Black, rectangle);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_1
{
    class Circle : Figure
    {
        int radius;

        public Circle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void DrawBlack(Graphics graphics)
        {
            Rectangle rectangle = new Rectangle(x, y, radius, radius);
            graphics.FillEllipse(Brushes.Black, rectangle);
        }

        public override void HideDrawingBackGround(Graphics graphics)
        {
            Rectangle rectangle = new Rectangle(x, y, radius, radius);
            graphics.FillEllipse(Brushes.White, rectangle);
        }
    }
}

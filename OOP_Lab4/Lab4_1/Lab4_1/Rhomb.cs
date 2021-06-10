using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    class Rhomb : Figure
    {
        private int horDiag;
        private int vertDiag;

        public Rhomb(int x, int y, int horDiag, int vertDiag)
        {
            this.horDiag = horDiag;
            this.vertDiag = vertDiag;
            this.x = x;
            this.y = y;
        }

        public override void DrawBlack(Graphics graphics)
        {
            Rectangle rectangle = new Rectangle(x, y, horDiag, vertDiag);

            using (GraphicsPath myPath = new GraphicsPath())
            {
                myPath.AddLines(new[]
                {
                  new Point(rectangle.X, rectangle.Y + (rectangle.Height / 2)),
                  new Point(rectangle.X + (rectangle.Width / 2), rectangle.Y),
                  new Point(rectangle.X + rectangle.Width, rectangle.Y + (rectangle.Height / 2)),
                  new Point(rectangle.X + (rectangle.Width / 2), rectangle.Y + rectangle.Height),
                  new Point(rectangle.X, rectangle.Y + (rectangle.Height / 2))
                });
                using (Pen pen = new Pen(Color.Black, 1))
                    graphics.DrawPath(pen, myPath);
            }
        }

        public override void HideDrawingBackGround(Graphics graphics)
        {
            Rectangle rectangle = new Rectangle(x, y, horDiag, vertDiag);

            using (GraphicsPath myPath = new GraphicsPath())
            {
                myPath.AddLines(new[]
                {
                  new Point(rectangle.X, rectangle.Y + (rectangle.Height / 2)),
                  new Point(rectangle.X + (rectangle.Width / 2), rectangle.Y),
                  new Point(rectangle.X + rectangle.Width, rectangle.Y + (rectangle.Height / 2)),
                  new Point(rectangle.X + (rectangle.Width / 2), rectangle.Y + rectangle.Height),
                  new Point(rectangle.X, rectangle.Y + (rectangle.Height / 2))
                });
                using (Pen pen = new Pen(Color.White, 1))
                    graphics.DrawPath(pen, myPath);
            }
        }
    }
}

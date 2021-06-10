using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Lab4_1
{
    abstract class Figure : PictureBox
    {
        public int x;
        public int y;
        Random random = new Random();
        public void MoveRight()
        {
            x += 1;
        }
        public abstract void DrawBlack(Graphics graphics);
        public abstract void HideDrawingBackGround(Graphics graphics);
    }
}

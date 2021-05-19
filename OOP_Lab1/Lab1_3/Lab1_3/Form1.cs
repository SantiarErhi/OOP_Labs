using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_3
{
    public partial class Form1 : Form
    {
        private Color curColor;
        private Dictionary<int, Color> colors = new Dictionary<int, Color>(3);
        
        public Form1()
        {
            InitializeComponent();
            colors.Add(0, Color.Red);
            colors.Add(1, Color.Yellow);
            colors.Add(2, Color.Blue);

        }

        private void Colors_SelectedIndexChanged(object sender, EventArgs e)
        {
            curColor = colors[Colors.SelectedIndex];
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Green;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.BackColor = curColor;
        }
    }
}

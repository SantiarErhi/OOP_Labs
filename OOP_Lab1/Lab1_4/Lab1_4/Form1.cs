using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_4
{
    public partial class Form1 : Form
    {
        int x = 0;
        int y = 0;
        int labelWidth = 100;
        int labelHeight = 20;
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateLabelButton_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Size = new Size(labelWidth, labelHeight);
            label.Location = new Point(x, y);
            y += labelHeight;
            if(y > Size.Height)
            {
                x += labelWidth;
                y = 0;
            }
            label.Font = new Font("Arial", 10, FontStyle.Bold | FontStyle.Italic);
            label.Text = "Text " + counter;
            counter++;

            label.Click += labelN_Click;
            Controls.Add(label);

        }
        void labelN_Click(object sender, EventArgs e)
        {
                NumberLabel.Text = "Number of pressed label " + ((Label)sender).Text.Split()[1];

        }
        
    }
}

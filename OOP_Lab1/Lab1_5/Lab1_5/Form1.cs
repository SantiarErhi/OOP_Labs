using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            this.BackColor = Color.FromArgb(random.Next(0, 100), random.Next(0, 100), random.Next(0, 100));
            var iter = Controls.GetEnumerator();
            while (iter.MoveNext())
            {
                ((Control)iter.Current).Visible = false;
}
            

        }

        private void ActivateButton_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void DeactivateButton_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }
    }
}

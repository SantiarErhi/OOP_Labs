using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void OpenForm3Button_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }
    }
}

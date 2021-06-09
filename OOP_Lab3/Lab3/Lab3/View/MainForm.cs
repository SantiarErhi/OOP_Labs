using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                
            }
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog openFileDialog = new SaveFileDialog())
            {
                
            }
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            Form makeOrderForm = new View.MakeOrderForm();
            if (makeOrderForm.ShowDialog(this) == DialogResult.OK)
            {
                
                
            }
        }
    }
}

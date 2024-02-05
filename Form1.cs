using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_Pool_Puzzle_NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.ShowDialog();
            saveFileDialog1.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pineapple.PineappleMain();
            
        }

    }
}

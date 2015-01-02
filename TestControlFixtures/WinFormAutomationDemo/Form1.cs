using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAutomationDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            textBox1.Text = "clicked";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "clicked toolStripButton1";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "clicked toolStripButton2";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "clicked toolStripButton3";
        }

        private void cSharpFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "clicked cSharpFileToolStripMenuItem";
        }

 
 
    }
}

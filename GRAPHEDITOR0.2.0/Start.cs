using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRAPHEDITOR0._2._0
{
    public partial class Start : Form
    {
        int theme=1;
        public Start()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            theme = 1;
            this.BackColor = Color.White;
            label1.ForeColor = Color.CadetBlue;
            radioButton1.ForeColor = Color.LightSlateGray;
            radioButton2.ForeColor = Color.LightSlateGray;
            button1.BackColor = Color.LightGray;
            button2.BackColor = Color.LightGray;
            button1.ForeColor = Color.Gray;
            button2.ForeColor = Color.Gray;
            pictureBox1.Image = Image.FromFile("../../Resources/cat.gif");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            theme = 2;
            this.BackColor = Color.Black;
            label1.ForeColor = Color.LightCyan;
            radioButton1.ForeColor = Color.MediumPurple;
            radioButton2.ForeColor = Color.MediumPurple;
            button1.BackColor = Color.DarkSlateBlue;
            button2.BackColor = Color.DarkSlateBlue;
            button1.ForeColor = Color.LightCyan;
            button2.ForeColor = Color.LightCyan;
            pictureBox1.Image = Image.FromFile("../../Resources/blackCat.gif");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Editor ed = new Editor(theme);
            ed.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }
    }
}

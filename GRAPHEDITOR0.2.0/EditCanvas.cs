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
    public partial class EditCanvas : Form
    {
        int x;
        int y;
        int theme;
        Color colorResult;
        public EditCanvas(Color color)
        {
            InitializeComponent();
            RedBarr.Tag = numericUpDownRed;
            GreenBarr.Tag = numericUpDownGreen;
            BlueBarr.Tag = numericUpDownBlue;

            numericUpDownRed.Tag = RedBarr;
            numericUpDownGreen.Tag = GreenBarr;
            numericUpDownBlue.Tag = BlueBarr;

            numericUpDownRed.Value = color.R;
            numericUpDownGreen.Value = color.G;
            numericUpDownBlue.Value = color.B;
        }
        private void UpdateColor()
        {
            colorResult = Color.FromArgb(RedBarr.Value, GreenBarr.Value, BlueBarr.Value);
            Color_Pic.BackColor = colorResult;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            x = 300;
            y = 300;
            pictureBox1.Size = new Size(x / 4, y / 4);
            //pictureBox1.Location=
        }

        private void RedBarr_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrl = (ScrollBar)sender;
            NumericUpDown nmrUpDown = (NumericUpDown)scrl.Tag;
            nmrUpDown.Value = scrl.Value;
            UpdateColor();
        }

        private void GreenBarr_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrl = (ScrollBar)sender;
            NumericUpDown nmrUpDown = (NumericUpDown)scrl.Tag;
            nmrUpDown.Value = scrl.Value;
            UpdateColor();
        }


        private void BlueBarr_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrl = (ScrollBar)sender;
            NumericUpDown nmrUpDown = (NumericUpDown)scrl.Tag;
            nmrUpDown.Value = scrl.Value;
            UpdateColor();
        }

        private void numericUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nmrUpDown = (NumericUpDown)sender;
            ScrollBar scrl = (ScrollBar)nmrUpDown.Tag;
            scrl.Value = (int)nmrUpDown.Value;
            UpdateColor();
        }

        private void numericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nmrUpDown = (NumericUpDown)sender;
            ScrollBar scrl = (ScrollBar)nmrUpDown.Tag;
            scrl.Value = (int)nmrUpDown.Value;
            UpdateColor();
        }

        private void numericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nmrUpDown = (NumericUpDown)sender;
            ScrollBar scrl = (ScrollBar)nmrUpDown.Tag;
            scrl.Value = (int)nmrUpDown.Value;
            UpdateColor();
        }

        private void OtherColors_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                RedBarr.Value = colorDialog.Color.R;
                GreenBarr.Value = colorDialog.Color.G;
                BlueBarr.Value = colorDialog.Color.B;
                colorResult = colorDialog.Color;
                UpdateColor();
            }
        }

        private void Ok_btn_Click(object sender, EventArgs e)
        {
            Editor ed = new Editor(theme,new Size(x,y),colorResult);
            this.Close();
            ed.Show();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void w_ValueChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            x = Convert.ToInt32(w.Value);
            pictureBox1.Width = Convert.ToInt32(w.Value / 4);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            x = 600;
            y = 400;
            pictureBox1.Size = new Size(x / 4, y / 4);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            x = 450;
            y = 200;
            pictureBox1.Size = new Size(x / 4, y / 4);
        }

        private void Color_Pic_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Color_Pic.BackColor.ToString(), "Color", MessageBoxButtons.OK);
        }

        private void h_ValueChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            y = Convert.ToInt32(h.Value);
            pictureBox1.Height = Convert.ToInt32(h.Value / 4);
        }

        private void EditCanvas_Load(object sender, EventArgs e)
        {

        }

        private void theme_numeric_ValueChanged(object sender, EventArgs e)
        {
            theme = Convert.ToInt32(theme_numeric.Value);
        }
    }

}

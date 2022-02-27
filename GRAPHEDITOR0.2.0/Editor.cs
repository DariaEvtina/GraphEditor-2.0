using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRAPHEDITOR0._2._0
{
    public partial class Editor : Form
    {
        public Color color = Color.Black;
        public Color Backcolor = Color.White;
        bool drawing;
        int historyCounter;
        GraphicsPath currentPath;
        Point oldLocation;
        public Pen currentPen;
        List<Image> History;
        public Editor(int theme)
        {
            InitializeComponent();
            drawing = false;
            currentPen = new Pen(color);
            History = new List<Image>();
            if (theme==1)
            {
                this.BackColor = Color.AntiqueWhite;
                toolStrip1.BackColor = Color.Silver;
                label2.ForeColor = Color.SlateGray;
                labe_XY.ForeColor = Color.Gray;
                panel2.BackColor = Color.Gainsboro;
                trackBar.BackColor = Color.Gainsboro;
                panel1.BackColor = Color.LightGray;
                menuStrip1.BackColor = Color.Silver;
                menuStrip1.ForeColor = Color.Black;
                pictureBox1.Image = Image.FromFile("../../Resources/cat.gif");
            }
            else if (theme == 2)
            {
                this.BackColor = Color.DarkSlateBlue;
                toolStrip1.BackColor = Color.FromArgb(68, 0, 129);
                label2.ForeColor = Color.LightCyan;
                labe_XY.ForeColor = Color.LightCyan;
                panel2.BackColor = Color.Black;
                trackBar.BackColor = Color.Black;
                panel1.BackColor = Color.DarkSlateGray;
                menuStrip1.BackColor = Color.FromArgb(68,0,129);
                menuStrip1.ForeColor = Color.LightBlue;
                pictureBox1.Image = Image.FromFile("../../Resources/blackCat.gif");
            }
        }
        public Editor(int theme,Size size,Color pic)
        {
            InitializeComponent();
            drawing = false;
            currentPen = new Pen(color);
            History = new List<Image>();
            Backcolor = pic;
            picDrawingSurface.BackColor = pic;
            picDrawingSurface.Size = size;
            if (theme == 1)
            {
                this.BackColor = Color.AntiqueWhite;
                toolStrip1.BackColor = Color.Silver;
                label2.ForeColor = Color.SlateGray;
                labe_XY.ForeColor = Color.Gray;
                panel2.BackColor = Color.Gainsboro;
                trackBar.BackColor = Color.Gainsboro;
                panel1.BackColor = Color.LightGray;
                menuStrip1.BackColor = Color.Silver;
                menuStrip1.ForeColor = Color.Black;
                pictureBox1.Image = Image.FromFile("../../Resources/cat.gif");
            }
            else if (theme == 2)
            {
                this.BackColor = Color.DarkSlateBlue;
                toolStrip1.BackColor = Color.FromArgb(68, 0, 129);
                label2.ForeColor = Color.LightCyan;
                labe_XY.ForeColor = Color.LightCyan;
                panel2.BackColor = Color.Black;
                trackBar.BackColor = Color.Black;
                panel1.BackColor = Color.DarkSlateGray;
                menuStrip1.BackColor = Color.FromArgb(68, 0, 129);
                menuStrip1.ForeColor = Color.LightBlue;
                pictureBox1.Image = Image.FromFile("../../Resources/blackCat.gif");
            }
        }

        private void picDrawingSurface_MouseUp(object sender, MouseEventArgs e)
        {
            History.RemoveRange(historyCounter + 1, History.Count - historyCounter - 1);
            History.Add(new Bitmap(picDrawingSurface.Image));
            if (historyCounter + 1 < 10) { historyCounter++; }
            if (History.Count - 1 == 10) { History.RemoveAt(0); }
            drawing = false;
            try
            {
                currentPath.Dispose();
            }
            catch { };
        }

        private void picDrawingSurface_MouseMove(object sender, MouseEventArgs e)
        {
            labe_XY.Text = e.X.ToString() + " ; " + e.Y.ToString();
            if (drawing)
            {
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);
                currentPath.AddLine(oldLocation, e.Location);
                g.DrawPath(currentPen, currentPath);
                oldLocation = e.Location;
                g.Dispose();
                picDrawingSurface.Invalidate();
            }
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            currentPen.Width = trackBar.Value;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (History.Count != 0 && historyCounter != 0)
            {
                picDrawingSurface.Image = new Bitmap(History[--historyCounter]);
            }
            else { MessageBox.Show("History is empty"); }
        }

        private void renoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (historyCounter < History.Count - 1)
            {
                picDrawingSurface.Image = new Bitmap(History[++historyCounter]);
            }
            else { MessageBox.Show("History is empty"); }
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Solid;
            solidToolStripMenuItem.Checked = true;
            dotToolStripMenuItem.Checked = false;
            dashdotdotToolStripMenuItem.Checked = false;
        }

        private void dotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Custom;
            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = true;
            dashdotdotToolStripMenuItem.Checked = false;
        }
        private void dashdotdotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.DashDotDot;
            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = false;
            dashdotdotToolStripMenuItem.Checked = true;
        }
        private void ChangeColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
            }
        }
            private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picDrawingSurface.Image == null)
            {
                History.Clear();
                historyCounter = 0;
                Bitmap pic = new Bitmap(737, 430);
                picDrawingSurface.Image = pic;
                History.Add(new Bitmap(picDrawingSurface.Image));
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);
                g.Clear(Backcolor);
                g.DrawImage(picDrawingSurface.Image, 0, 0, 737, 430);
            }
            if (picDrawingSurface.Image != null)
            {
                var result = MessageBox.Show("Do you want to save an image after create a new file?", "Warning", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: saveToolStripMenuItem_Click(sender, e); break;
                    case DialogResult.Cancel: return;
                }
                History.Clear();
                historyCounter = 0;
                Bitmap pic = new Bitmap(737, 430);
                picDrawingSurface.Image = pic;
                History.Add(new Bitmap(picDrawingSurface.Image));
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);
                g.Clear(Backcolor);
                g.DrawImage(picDrawingSurface.Image, 0, 0, 737, 430);
            }
        }
        private void picDrawingSurface_MouseDown(object sender, MouseEventArgs e)
        {
            if (picDrawingSurface.Image == null)
            {
                MessageBox.Show("Create a new file first!");
                return;
            }
            if (e.Button == MouseButtons.Left)
            {
                drawing = true;
                oldLocation = e.Location;
                currentPath = new GraphicsPath();
                currentPen.Color = color;
            }
            else if (e.Button == MouseButtons.Right)
            {
                drawing = true;
                oldLocation = e.Location;
                currentPath = new GraphicsPath();
                currentPen.Color = Backcolor;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            OP.Title = "Open an image file";
            OP.FilterIndex = 4;
            if (OP.ShowDialog() != DialogResult.Cancel)
            {
                picDrawingSurface.Load(OP.FileName);
                picDrawingSurface.AutoSize = true;
                History.Clear();
                historyCounter = 0;
                History.Add(new Bitmap(picDrawingSurface.Image));
            }

        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            SaveDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            SaveDlg.Title = "Save an image file";
            SaveDlg.FilterIndex = 4;
            SaveDlg.ShowDialog();
            if (SaveDlg.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)SaveDlg.OpenFile();
                switch (SaveDlg.FilterIndex)
                {
                    case 1:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Bmp);
                        break;
                    case 3:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Gif);
                        break;
                    case 4:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Png);
                        break;
                }
                fs.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picDrawingSurface.Image == null)
            {
                this.Close();
                Start str = new Start();
                str.Show();
                //Program.f1.Show();
            }
            if (picDrawingSurface.Image != null)
            {
                var result = MessageBox.Show("Do you want to save an image after create a new file?", "Warning", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: saveToolStripMenuItem_Click(sender, e); break;
                    case DialogResult.Cancel: return;
                }
                this.Close();
                //Program.f1.Show();
                Start str = new Start();
                str.Show();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (picDrawingSurface.Image == null)
            {
                EditCanvas ec = new EditCanvas(Backcolor);
                ec.Show();
                this.Close();
            }
            if (picDrawingSurface.Image != null)
            {
                var result = MessageBox.Show("Do you want to save an image after create a new file?", "Warning", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: saveToolStripMenuItem_Click(sender, e); break;
                    case DialogResult.Cancel: return;
                }
                this.Close();
                //Program.f1.Show();
                EditCanvas ec = new EditCanvas(Backcolor);
                ec.Show();
            }
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }
    }
}

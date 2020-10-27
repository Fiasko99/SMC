using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMasterClass
{
    public partial class PaintForm : Form
    {
        private readonly Bitmap bitmapMain;
        private readonly Graphics graphics;
        private readonly Pen pen;

        private Point startPoint;
        public PaintForm()
        {
            InitializeComponent();
            bitmapMain = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            graphics = Graphics.FromImage(bitmapMain);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            pen = new Pen(pictureBoxRed.BackColor, trackBarSize.Value);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            pictureBoxMain.MouseDown += (sender, e) => startPoint = e.Location;
            pictureBoxMain.Paint += (sender, e) => e.Graphics.DrawImage(bitmapMain, 0, 0);
            pictureBoxMain.MouseMove += PictureBoxMain_MouseMove;
            pictureBoxMain.MouseUp += PictureBoxMain_MouseUp;

            pictureBoxRed.Click += (sender, e) => pen.Color = pictureBoxRed.BackColor;
            pictureBoxGreen.Click += (sender, e) => pen.Color = pictureBoxGreen.BackColor;
            pictureBoxYellow.Click += (sender, e) => pen.Color = pictureBoxYellow.BackColor;
            pictureBoxBlue.Click += (sender, e) => pen.Color = pictureBoxBlue.BackColor;

            trackBarSize.ValueChanged += (sender, e) => pen.Width = trackBarSize.Value;

            buttonClear.Click += (sender, e) => { graphics.Clear(DefaultBackColor); pictureBoxMain.Invalidate(); };
            buttonSave.Click += ButtonSave_Click;
            buttonLoad.Click += ButtonLoad_Click;
        }

        private void PictureBoxMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                graphics.DrawLine(pen, startPoint, e.Location);
                startPoint = e.Location;
                pictureBoxMain.Invalidate();
            }
        }

        private void PictureBoxMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // graphics.DrawEllipse(pen, );
            }
        }

        private void ButtonSave_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "JPG Files(*.JPG)|*.jpg|PNG files(*.PNG)|*.png"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                bitmapMain.Save(saveFileDialog.FileName);
        }

        private void ButtonLoad_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                graphics.DrawImage(Bitmap.FromFile(openFileDialog.FileName), 0, 0);
                pictureBoxMain.Invalidate();
            }
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            MenuBarForm menuForm = new MenuBarForm();
            menuForm.Show();
            this.Hide();
        }
    }
}

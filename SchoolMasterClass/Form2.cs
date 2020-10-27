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
    public partial class Snake : Form
    {
        Point[] p;
        Point apple;
        int len;
        int direction;
        int count = 0;
        public Snake()
        {
            InitializeComponent();
            p = new Point[200];
            len = 5;
            direction = 3;
            for (int i = 0; i < 5; i++)
            {
                p[i].X = 100;
                p[i].Y = 100 + i * 10;
            }
            apple.X = 10;
            apple.Y = 10;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 198; i >= 0; i--)
            {
                p[i + 1].X = p[i].X;
                p[i + 1].Y = p[i].Y;
            }

            if (direction == 1)
            {
                p[0].X = p[1].X - 10;
                if (p[0].X < 0)
                {
                    p[0].X = 490;
                }
                p[0].Y = p[1].Y;
            }
            if (direction == 2)
            {
                p[0].X = p[1].X + 10;
                if (p[0].X > 490)
                {
                    p[0].X = 0;
                }
                p[0].Y = p[1].Y;
            }
            if (direction == 3)
            {
                p[0].X = p[1].X;
                p[0].Y = p[1].Y - 10;
                if (p[0].Y < 0)
                {
                    p[0].Y = 490;
                }
            }
            if (direction == 4)
            {
                p[0].X = p[1].X;
                p[0].Y = p[1].Y + 10;
                if (p[0].Y > 490)
                {
                    p[0].Y = 0;
                }
            }
            for (int i = 1; i < len; i++)
            {
                if (p[0].Y == p[i].Y && p[0].X == p[i].X)
                {
                    len = i - 1;
                }
            }

            if (len == 1)
            {
                direction = 0;
                // Игра окончена
                GameOverLabel.Visible = true;
                BackToMenu.Visible = true;
            }


            SolidBrush b = new SolidBrush(Color.Brown);
            for (int i = 0; i < len; i++)
            {
                e.Graphics.FillEllipse(b, p[i].X, p[i].Y, 10, 10);
            }

            SolidBrush b1 = new SolidBrush(Color.Green);
            e.Graphics.FillEllipse(b1, apple.X, apple.Y, 10, 10);

            if (p[0].X == apple.X && p[0].Y == apple.Y)
            {
                len++;
                Random R = new Random();
                apple.X = R.Next(0, 50) * 10;
                apple.Y = R.Next(0, 50) * 10;
                timer1.Interval -= len * 2;
                count++;
                countLabel.Text = count.ToString();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                direction = 1;
            }
            if (e.KeyCode == Keys.D)
            {
                direction = 2;
            }
            if (e.KeyCode == Keys.W)
            {
                direction = 3;
            }
            if (e.KeyCode == Keys.S)
            {
                direction = 4;
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

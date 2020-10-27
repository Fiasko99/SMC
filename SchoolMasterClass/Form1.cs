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
    public partial class MenuBarForm : Form
    {
        public MenuBarForm()
        {
            InitializeComponent();
        }

        private void SelectGame_SelectedValueChanged(object sender, EventArgs e)
        {
            Start.Enabled = true;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            string game = SelectGame.Text;
            if (game == "Змейка")
            {
                Snake gameForm = new Snake();
                gameForm.Show();
                this.Hide();
            }
            else if(game == "Рисовашка")
            {
                PaintForm paintForm = new PaintForm();
                paintForm.Show();
                this.Hide();
            }
        }
    }
}

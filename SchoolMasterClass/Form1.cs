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
                this.Hide();
                Snake gameForm = new Snake();
                gameForm.Show();
            }
            else if(game == "Рисовашка")
            {
                this.Hide();
                PaintForm paintForm = new PaintForm();
                paintForm.Show();
            }
        }

        private void MenuBarForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Закрыть?", "Message", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }
    }
}

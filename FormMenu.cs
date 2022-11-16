using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopDownGame
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            this.Hide();
            gameForm.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to quit ?", "Quit", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A product by NEXUS Team-2211COMP101902\n-----------------------------\nOur Team Members\n\nPhạm Cương Danh Phát - 47.01.104.155\nLê Văn Quý -47.01.104.176\nNguyễn Hoàng Thương-47.01.104.206\nHuỳnh Quốc Thái - 47.01.104.188 - Leader\n-----------------------------\nLecturer: M.Sc Trần Thanh Nhã", "TinySpiker V1.0.0 - Info",MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Move up: W\n\nMove down: S \n\nMove left: A  \n\n" +
                "Move right: D \n\nAbility: F \n\nRefill Spike: R \n\nShoot: Spacebar \n\n","Guide",MessageBoxButtons.OK);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesProject
{
    public partial class Games : Form
    {
        public Games()
        {
            InitializeComponent();
        }
        public int y;

        private void btnNumbers_Click(object sender, EventArgs e)
        {
            Play play = new Play() { MdiParent = MdiParent };
            y = 5;
            play.x = this.y;
            play.Dock = DockStyle.Fill;
            play.Show();
        }
    }
}

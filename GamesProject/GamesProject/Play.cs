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
    public partial class Play : Form
    {
        public Play()
        {
            InitializeComponent();
        }
        public int x;

        private void btnPlay_Click(object sender, EventArgs e)
        {     
                Numbers numbers = new Numbers() { MdiParent = MdiParent };
                numbers.Dock = DockStyle.Fill;
                numbers.Show();
                this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

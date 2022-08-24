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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            Games games = new Games();
            games.MdiParent = this;
            games.Dock = DockStyle.Fill;
            games.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatthewWierenga_20112548_POE
{
    public partial class Form1 : Form
    {
        protected GameEngine GM;
        public Form1()
        {
            InitializeComponent();

            GM = new GameEngine();
            RedrawMap();
            Info.Text = GM.GAMEMAP.CHARACTER.ToString();

            foreach(Enemy G in GM.GAMEMAP.ENEMIES)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Categorisation_Game
{
    public partial class MenuPage : Form
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGameMode1_Click(object sender, EventArgs e)
        {
            Page___GameMode1 op1 = new Page___GameMode1();
            op1.Show();
        }
        private void btnGameMode2_Click(object sender, EventArgs e)
        {
            Page___GameMode2 op2 = new Page___GameMode2();
            op2.Show();
        }
    }
}

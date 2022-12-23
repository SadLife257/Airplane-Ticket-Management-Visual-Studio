using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_Bán_vé_Máy_bay
{
    public partial class SplashScreen : Form
    {
        private int move = 0;
        
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timerSplash.Start();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            panelSlide.Left += 2;

            if(panelSlide.Left > 600)
            {
                panelSlide.Left = 0;
            }

            if (panelSlide.Left < 0)
            {
                move = 2;
            }
        }
    }
}

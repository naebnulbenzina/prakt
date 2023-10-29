using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr6
{
    public partial class lab6 : Form
    {
        public lab6()
        {
            InitializeComponent();
        }

      
        private void tmr_Tick(object sender, EventArgs e)
        {
            if (pct.Location.X > 420)
            {
                mov_down();
                mov_left();
                mov_up();
            }


            else pct.Left += 20;


        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (tmr.Enabled)
            {
                tmr.Stop();
                btnStart.Text = "Start";
            }

            else
            {
                tmr.Start();
                btnStart.Text = "Stop";
            }


        }

        private void mov_left()
        {
            while (pct.Location.X > 50)
            {
                pct.Left -= 20;
                Thread.Sleep(50);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void mov_down()
        {
            while (pct.Location.Y < 210)
            {
                pct.Top += 20;
                Thread.Sleep(50);
            }
        }

        private void mov_up()
        {
            while (pct.Location.Y > 15)
            {
                pct.Top -= 20;
                Thread.Sleep(50);
            }
        }

     
    }
}

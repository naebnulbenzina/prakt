using System;
using System.Windows.Forms;

namespace prakt

{
    public partial class Form2 : Form
    {
        DateTime dateTime = new DateTime();



        public Form2()
        {
            InitializeComponent();
        }

        private void tmrSecundomer_Tick(object sender, EventArgs e)
        {
            int tmp = Int32.Parse(txtSeconds.Text);
            int minut = Int32.Parse(txtMinutes.Text);
            tmp++;

            if (tmp > 59)
            {
                txtSeconds.Text = "0";
                txtMinutes.Text = (minut + 1).ToString();
            }

            else
                txtSeconds.Text = tmp.ToString();

            label3.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToLongTimeString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Stop") btnStart.Text = "Start";
            else btnStart.Text = "Stop";

            if (tmrSecundomer.Enabled)
                tmrSecundomer.Enabled = false;
            else
                tmrSecundomer.Enabled = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMinutes.Text = "0"; 
            txtSeconds.Text = "0";
            btnStart.Text = "Start";
            tmrSecundomer.Enabled = false;
        }


    }
}

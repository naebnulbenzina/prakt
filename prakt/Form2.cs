using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prakt
{
    public partial class lab7 : Form
    {
        public lab7()
        {
            InitializeComponent();
        }

        private void lab7_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int counter = 0;
            double sum = 0;
            double summand = 0.0;
            double x;
            double precision;
            bool f = false;

            if (double.TryParse(txtPrecision.Text, out precision))
            {
                f = true;
            }
            do
            {
                counter++;
                if (double.TryParse(txtX.Text, out x))
                {
                    summand = double.Parse(txtX.Text) / counter;
                }

                sum += summand;
            }
            
            while (f && Math.Abs(summand) > precision);
            if (f)
            {
                lblResult.Text = "summa = " + sum + ",kolichestvo = " + counter;
            }
            else
            {
                MessageBox.Show("Введите числовое значение");
            }
        }
    }
}

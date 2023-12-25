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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            // Считываем с формы требуемые значения
            double x0 = double.Parse(textBox1.Text);
            double xk = double.Parse(textBox2.Text);
            double dx = double.Parse(textBox3.Text);



            
            chart1.ChartAreas[0].AxisX.Minimum = x0;
            chart1.ChartAreas[0].AxisX.Maximum = xk;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = dx;

          
         

            double x = x0;

            while (x <= (xk + dx / 2))
            {
                double y = 1.35 * Math.Pow(x, 3) + Math.Pow(Math.Cos(Math.Pow(x, 3) - (-6.25)), 2);
                
                chart1.Series[0].Points.AddXY(x, y);
               

                x += dx;
            }

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


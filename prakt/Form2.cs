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

        private int[] Arrr = new int[20];
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMas_Click2(object sender, EventArgs e)
        {
            ClearFields2();

            int n = int.Parse(textBox12.Text);
            int a = int.Parse(textBox22.Text);
            int b = int.Parse(textBox32.Text);


            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                Arrr[i] = r.Next(a, b);
                label42.Text += Arrr[i];
                if (i != n) label42.Text += ", ";

            }
            btnSort22.Enabled = true;





        }

        private int MinNumber2(int[] x, int m)
        {
            int min = x[m];
            int MinN = m;

            for (int i = m; i < x.Length; i++)
            {
                if (x[i] < min)
                {
                    min = x[i];
                    MinN = i;
                }
            }

            return MinN;
        }

        private void btnSort_Click2(object sender, EventArgs e)
        {
            int k, t;

            for (int i = 0; i < Arrr.Length; i++)
            {
                k = MinNumber2(Arrr, i);
                t = Arrr[i];
                Arrr[i] = Arrr[k];
                Arrr[k] = t;
                label52.Text += Arrr[i];
                if (i != Arrr.Length - 1)
                {
                    label52.Text += ", ";
                }

                btnSort22.Enabled = false;
            }
        }

        private void ClearFields2()
        {
            label42.Text = "";
            label52.Text = "";
            btnSort22.Enabled = false;
        }

        private void btnExit_Click2(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }

}

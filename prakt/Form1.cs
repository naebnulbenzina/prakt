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
    public partial class Form1 : Form
    {
        private int[] Arr = new int[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            int n = 10;
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);

            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                Arr[i] = r.Next(a, b);
                label4.Text += Arr[i];
                if (i != n) label4.Text += ", ";

            }
            btnSort.Enabled = true;
          

            
            
            
        }

        private int MinNumber(int[] x, int m)
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

        private void btnSort_Click(object sender, EventArgs e)
        {
            int k, t;

            for (int i = 0; i < Arr.Length; i++)
            {
                k = MinNumber(Arr, i);
            }
        }
    }
}

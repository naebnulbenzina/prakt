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
        
        private int[] Arr = new int[20];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            ClearFields();
             
            int n = int.Parse(textBox1.Text);
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
                t = Arr[i];
                Arr[i] = Arr[k];
                Arr[k] = t;
                label5.Text += Arr[i];
                if (i != Arr.Length - 1)
                {
                    label5.Text += ", ";
                }

                btnSort.Enabled = false;
            }
        }

        private void ClearFields()
        {
            label4.Text = "";
            label5.Text = "";
            btnSort.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }

}

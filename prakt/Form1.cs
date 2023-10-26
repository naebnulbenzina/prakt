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
    public partial class Lab5 : Form
    {
        public Lab5()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int fromX = int.Parse(txtX1.Text);
            int toX = int.Parse(txtX2.Text);
            int fromY = int.Parse(txtY1.Text);
            int toY = int.Parse(txtY2.Text);

            if (fromX > toX)
            {
                MessageBox.Show("Интервал должен быть от меньшего к большему");
                txtX1.Text = "";
                txtX2.Text = "";
            }


            if (fromY > toY)
            {
                MessageBox.Show("Интервал должен быть от меньшего к большему");
                txtY1.Text = "";
                txtY2.Text = "";
            }

            for (int x = fromX; x <= toX; x++) 
            {
                for (int y = fromY; y <= toY; y++)
                {
                    lstResult.Items.Add($"z(x,y) = {x} - {y} = {x - y}");
                }
            }

               
        }
    }
}

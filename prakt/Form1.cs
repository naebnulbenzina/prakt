using System;
using System.Windows.Forms;

namespace prakt
{
    public partial class Lab5 : Form
    {
        int fromX;
        int toX;
        int fromY;
        int toY;

        public Lab5()
        {
            InitializeComponent();
        }


        private void btnCalc_Click(object sender, EventArgs e)
        {
            lstResult.Items.Clear();
            
            if (fromX > toX || fromY > toY || !int.TryParse(txtX1.Text, out fromX) || !int.TryParse(txtX2.Text, out toX) || !int.TryParse(txtY1.Text, out fromY) || !int.TryParse(txtY2.Text, out toY))
            {
                MessageBox.Show("OSHIBKA");
                return;
               

            }


            

            for (int x = fromX; x <= toX; x++) 
            {
                for (int y = fromY; y <= toY; y++)
                {
                    lstResult.Items.Add($"z(x,y) = {x} - {y} = {x - y}");
                }
            }

               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            
        }
    }
}

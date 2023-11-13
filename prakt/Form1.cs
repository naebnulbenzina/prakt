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
        string fname;

        public Form1()
        {
            InitializeComponent();
        }

        private void pct_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            file1.Filter = "(*.jpg)|*.jpg";

        }

        private void btn_Click(object sender, EventArgs e)
        {
           
     
            file1.ShowDialog();

            fname = file1.FileName;
            label1.Text = fname;

            pct.Image = Image.FromFile(fname);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = fname;
            saveFileDialog1.ShowDialog();

            pct.Image.Save(saveFileDialog1.FileName);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prakt
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fileName = textBox1.Text;


            if (File.Exists(fileName)) File.Delete(fileName);

            using (FileStream fs = File.Create(fileName, 1024)) 

            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    bw.Write(listBox1.Items[i].ToString());
                }

                bw.Close();
                fs.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

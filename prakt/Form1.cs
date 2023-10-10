using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЗЗЗ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ColorDialog MyDialog = new ColorDialog();




        private void showButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            MyDialog.ShowDialog();

            if (MyDialog.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = MyDialog.Color;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox2.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Load(openFileDialog1.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyDialog.ShowDialog();

            if (MyDialog.ShowDialog() == DialogResult.OK)
                pictureBox2.BackColor = MyDialog.Color;
        }
    }
}

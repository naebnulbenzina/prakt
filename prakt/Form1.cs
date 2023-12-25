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
        public Form1()
        {
            InitializeComponent();
        }

        private int numbersymbols(String stroka, char symbol)
        {
            int k = 0;
            for (int i = 0; i < stroka.Length; i++)
            {
                if (stroka[i] == symbol)
                {
                    k += 1;
                }
            }
            return k;
        }

        private int numbersymbols(string stroka, int len, string strrr)
        {
            int k = 0;
            int size = stroka.Length - len + 1;

            for (int i = 0; i < size; i++)
            {
                if (stroka.Substring(i, len) == strrr) { k++; i += len - 1; }
            }


            return k;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void knopka_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 1)
            {
                textBox2.Text = numbersymbols(textBox1.Text, textBox3.Text[0]).ToString();
            }
            else
                textBox2.Text = numbersymbols(textBox1.Text,textBox3.Text.Length,textBox3.Text).ToString();
        }
    }
}

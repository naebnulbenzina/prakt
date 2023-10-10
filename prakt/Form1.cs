using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

namespace prakt
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer();

        string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        int timer = 100;

        Label firstClicked = null;

        Label secondClicked = null;

        Random random = new Random();

        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", "F", "F", "w", "w",
            "k", "k", ",", ",", "l", "l", "t", "t",
            "a", "a", "q", "q", ".", ".", "s", "s",
            "v", "v", ";", ";", "p", "p", "]", "]",
            "i", "i", "z", "z"
        };

        private void AssigniconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            { 
                Label iconLabel = control as Label;
                if (iconLabel != null)
                { 
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);

                }


            
            }
            
            timer2.Start();
        
        }
        public Form1()
        {
            InitializeComponent();
            AssigniconsToSquares();
        }

        private void label29_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            Label clickedlabel = sender as Label;   
            if (clickedlabel != null) 
            {
                if (clickedlabel.ForeColor == Color.Black)
                    return;
                if (firstClicked == null)
                { 
                    firstClicked = clickedlabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }
            }
            secondClicked = clickedlabel;
            secondClicked.ForeColor = Color.Black;

            CheckForWinner();

            if (firstClicked.Text == secondClicked.Text)
            {
                player.SoundLocation = path + "\\levelup.wav";
                player.Play();
                firstClicked = null;
                secondClicked = null;
                return;
            }

            else 
            {
                player.SoundLocation = path + "\\leveldown.wav";
                player.Play();
            }

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;
            firstClicked = null;
            secondClicked = null;   
        }

        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            { 
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
               
            }

            MessageBox.Show("You molodec", "Congratulations");
            Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timer > 0)
            {
                if (timer < 10)
                    if (label37.BackColor == Color.Red)
                        label37.BackColor = Color.White;

                    else label37.BackColor = Color.Red;
                timer--;
                label37.Text = timer + " seconds";
            }

            else
            { 
                timer2.Stop();
                MessageBox.Show("You lox");
                Close();
            }
        }
    }   

}


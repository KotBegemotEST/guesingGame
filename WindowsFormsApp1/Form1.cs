using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Guessing_Game
{
    public partial class Form1 : Form
    {

        Random randomNumber = new Random();

        int number = 0;
        int guesses = 0;

        public Form1()
        {
            InitializeComponent();

            loadQuestions();
        }

        private void CheckNumber(object sender, EventArgs e)
        {
          

        }

        private void loadQuestions()
        {
            number = randomNumber.Next(0, 100);

            label3.Text = "I am thinking of a number between: 0 and 100 ";
        }

 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CheckNumber(object sender, MouseEventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);

            guesses += 1;
            label4.Text = "You guessed " + guesses + " times";

            if (i == number)
            {
                MessageBox.Show("Nice, you guessed it. Try another");
                loadQuestions();
                textBox1.Text = "";
                guesses = 0;
                label4.Text = "You guessed " + guesses + " times";
            }
            else if (i < number)
            {
                MessageBox.Show("Go Higher");
            }
            else
            {
                MessageBox.Show("Go Lower");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GuessingGameTemplate4U
{
    public partial class MainScreen : UserControl
    {
        //creates a random number between 1 and 100 and stores it in a global 
        //variable that can be used throughout the program 
        public static Random randNum = new Random();
        int rand = randNum.Next(1, 101);

        public MainScreen()
        {
            InitializeComponent();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            
            int guess = Convert.ToInt16(inputBox.Text);

            //TODO add guess to List of guesses on Form1

            Form1.unsortedGuess.Add(inputBox.Text);
            Form1.sortedGuess.Add(inputBox.Text);

            Form1.sortedGuess.Sort();


            if (guess < rand)
            {
                outputLabel.Text = "Too Low!";
            }
            else if (guess > rand)
            {
                outputLabel.Text = "Too High!";
            }
            else
            {
                outputLabel.Text = "You Got it!";
                Refresh();
                Thread.Sleep(1000);

                //TODO close this screen and open a Results Screen (you need to create this)
                Form login = this.FindForm();
                login.Controls.Remove(value: this);

                resultsScreen sc = new resultsScreen();
                login.Controls.Add(sc);

            }

            inputBox.Text = "";
            inputBox.Focus();
        }

    }
}

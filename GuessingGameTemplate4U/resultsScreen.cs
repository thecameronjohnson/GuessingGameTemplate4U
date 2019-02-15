using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameTemplate4U
{
    public partial class resultsScreen : UserControl
    {
        public resultsScreen()
        {
            InitializeComponent();

            guessesOutput.Text += "Guesses made: " + Form1.unsortedGuess.Count();
            sortedOutput.Text = "Sorted Order:\n";
            unsortedOutput.Text = "Unsorted Order:\n";
            int albumAmount = Form1.sortedGuess.Count();
            for (int i = 0; i < albumAmount; i++)
            {
                
                unsortedOutput.Text += Form1.unsortedGuess[i] + " ";
                sortedOutput.Text += Form1.sortedGuess[i] + " ";
            }


        }
    }
}

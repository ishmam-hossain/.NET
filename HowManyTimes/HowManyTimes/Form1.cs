using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HowManyTimes
{
    public partial class HowManyTimesUI : Form
    {
        public HowManyTimesUI()
        {
            InitializeComponent();
        }

        // variables
        string inputString, wordToBeSearched;

        private void searchButton_Click(object sender, EventArgs e)
        {
            inputString = paragraphTextBox.Text.ToString();
            wordToBeSearched = wordToBeSearchTextBox.Text.ToString();

            int total = wordCounter(inputString, wordToBeSearched);

            resultTextBox.Text = total.ToString();

        }

        private int wordCounter(string input, string word)
        {
            int totalAppeared = 0;

            string[] splitted = input.Split();

            //for (int s=0;s<splitted.Length;s++)
            //{
            //    paragraphTextBox.Text= splitted[s];
            //}

            int i = 0;

            while (i < splitted.Length)
            {
                if (splitted[i].Contains(word))
                    totalAppeared++;

                i++;
            }
            return totalAppeared;

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WhichWordOccuredHowManyTImes
{
    public partial class howManyTimesForm : Form
    {
        public howManyTimesForm()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void insertTextBox_TextChanged(object sender, EventArgs e)
        {
            totalCharacterLabel.Text = insertTextBox.Text.Length.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            string input = insertTextBox.Text.ToString().Trim();

            string[] inputSplitted = input.Split();

            lalbelAnswer.Text = inputSplitted.Length.ToString();
            Labeltotal.Visible = true;
            lalbelAnswer.Visible = true;

        }

    }
}

﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace ClassCalculater
{
    public partial class MainForm : Form
    {

        #region public fields

        public int numberOfAssignments;
        public TextBox[] textBoxes;

        #endregion

        #region private fields

        private bool hasGenerated;
        private const string DEFAULT_TEXT = "Waiting For Generation";
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void generateButtonClick(object sender, EventArgs e)
        {
            if (true == hasGenerated)
            {
                Console.WriteLine("Clear created content before asking for new content to be generated.");
                return;
            }

            try
            {
                numberOfAssignments = Int32.Parse(assignmentNumberInput.Text);
                hasGenerated = true;
            }
            catch (Exception)
            {
                Console.WriteLine("Either a type mismatch has occured, or the input textbox is empty");
            }

            int totalBoxes = numberOfAssignments * 3;
            textBoxes = new TextBox[totalBoxes];


            for (int i = 0; i < totalBoxes; i++)
            {
                textBoxes[i] = new TextBox();
                this.Controls.Add(textBoxes[i]);
            }

            int yOffset = 25; //This is how far down each control will be from eachother, in pixels
            int numberOfColums = 3;
            int lineNumber = 0;
            Point[] xStart;
            xStart = new Point[3];
            xStart[0] = assignmentNameLabel.Location;
            xStart[1] = gradeLabel.Location;
            xStart[2] = percentOfTotalGradeLabel.Location;

            for (int i = 0; i < numberOfAssignments; i++)
            {

                for (int j = 0; j < numberOfColums; j++)
                {
                    Point tempPoint1 = xStart[j];
                    tempPoint1.Y += yOffset;
                    textBoxes[j + lineNumber].Location = tempPoint1; 
                }
                lineNumber += 3;

                yOffset += 20;
            }
        }

        private void ClearFormClick(object sender, EventArgs e)
        {
            foreach (TextBox tB in textBoxes)
            {
                this.Controls.Remove(tB);
                textBoxes = null;
            }
            hasGenerated = false;
            letterGrade.Text = DEFAULT_TEXT;
            weightedNumberGrade.Text = DEFAULT_TEXT;
            unweightedAverage.Text = DEFAULT_TEXT;
            weightedAveragePartial.Text = DEFAULT_TEXT;
        }

        private void CalcGradeButtonClick(object sender, EventArgs e)
        { 
            string[] nameArray = new string[numberOfAssignments];
            float[] gradeArray = new float[numberOfAssignments];
            float[] percentArray = new float[numberOfAssignments];

            int nameArrIndex = 0;
            int gradeArrIndex = 0;
            int percentArrIndex = 0;

            float unweightedTotal = 0;
            float percentSum = 0.0f;
            float weightedGrade = 0.0f;

            // Seperate the data in the textboxes array into seperate arrays
            // for easier traversal
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (i % 3 == 0)
                {
                    nameArray[nameArrIndex] = textBoxes[i].Text;
                    nameArrIndex += 1;
                }
                else if ((i - 1) % 3 == 0)
                {
                    gradeArray[gradeArrIndex] = float.Parse(textBoxes[i].Text);
                    gradeArrIndex += 1;
                }
                else if ((i - 2) % 3 == 0)
                {
                    percentArray[percentArrIndex] = float.Parse(textBoxes[i].Text);
                    percentArrIndex += 1;
                }
            }

            
            // Suming the unweighted total
            for (int i = 0; i < gradeArray.Length; i++)
            {
                unweightedTotal += gradeArray[i];
            }

            unweightedTotal = unweightedTotal / numberOfAssignments;
            unweightedAverage.Text = unweightedTotal.ToString(CultureInfo.CurrentCulture);

            // Ensure that the sum of the weights is not greater than 1, warning if it is
            // If it is not, calculate the weighted grade and partial grade.
            for (int i = 0; i < percentArray.Length; i++)
            {
                percentSum += percentArray[i];
            }
            if (1.0f < percentSum)
            {
                MessageBox.Show("Sum of weights is more than 1.0. Ensure that weights are entered correctly");
            }
            else
            {

                for(int i = 0; i < gradeArray.Length; i++)
                {
                    weightedGrade += gradeArray[i] * percentArray[i];
                    weightedNumberGrade.Text = weightedGrade.ToString(CultureInfo.CurrentCulture);
                }

                if(1.0f > percentSum)
                {
                    MessageBox.Show("sum of weights is less than 1.0. If this is not intentional, check " +
                        "entered weights for accuracy.");
                    weightedAveragePartial.Text = (weightedGrade / (percentSum)).ToString(CultureInfo.CurrentCulture);
                }
                else
                {
                    weightedAveragePartial.Text = weightedGrade.ToString(CultureInfo.CurrentCulture);
                }

                letterGrade.Text = CalcLetterGrade(weightedGrade);
            }
        }

        /// <summary>
        /// Given the weighted grade, will return the letter grade based on current settings for grade ranges
        /// </summary>
        /// <param name="weightedGrade"></param>
        /// <returns></returns>
        private string CalcLetterGrade(float weightedGrade)
        {
            // Finds the letter grade
            if (69 >= (int)weightedGrade && 60 <= (int)weightedGrade)
            {
                return "D";
            }
            else if (80 >= (int)weightedGrade && 70 <= (int)weightedGrade)
            {
                return "C";
            }
            else if (89 >= (int)weightedGrade && 80 <= (int)weightedGrade)
            {
                return "B";
            }
            else if (100 >= (int)weightedGrade && 90 <= (int)weightedGrade)
            {
                return "A";
            }
            else if (100 < (int)weightedGrade)
            {
                return "A";
            }
            else
            {
                return "F";
            }
        }

        private void EditToolStripMenuGrade_Click(object sender, EventArgs e)
        {
            
        }
    }
}
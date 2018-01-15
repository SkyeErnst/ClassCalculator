using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace ClassCalculater
{
    public partial class MainForm : Form
    {

        #region public fields

        public int numberOfAssignments;

        #endregion

        #region private fields

        private TextBox[] textBoxes;
        private bool hasGenerated;
        private static bool debugMode = true;
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
                if(true == debugMode)
                {
                    Console.WriteLine("Clear created content before asking for new content to be generated.");
                }
                else
                {
                    MessageBox.Show("Clear created content before asking for new content to be generated.");
                }
                
                return;
            }
            else
            {
                hasGenerated = true;
            }

            try
            {
                numberOfAssignments = Int32.Parse(assignmentNumberInput.Text);
            }
            catch (Exception)
            {
                Console.WriteLine("There is likely a type mismatch. Please ensure only ints are fed into input box");
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
                hasGenerated = false;
            }
            letterGrade.Text = DEFAULT_TEXT;
            numberGrade.Text = DEFAULT_TEXT;
            unweightedAverage.Text = DEFAULT_TEXT;
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

            // Loads information from the text box array into seperate arrays
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

            // Sums grades to display the unweighted grade
            for (int i = 0; i < gradeArray.Length; i++)
            {
                unweightedTotal += gradeArray[i];
            }
            unweightedTotal = unweightedTotal / numberOfAssignments;
            unweightedAverage.Text = unweightedTotal.ToString(CultureInfo.CurrentCulture);

            for (int i = 0; i < percentArray.Length; i++)
            {
                percentSum += percentArray[i];
            }

            if (1.0f < percentSum)
            {
                MessageBox.Show("Sum of weights is greater than 1. Make sure you typed in the percents correctly.");
            }

            // see http://members.logical.net/~marshall/uab/howtocalculategrade.html
            // for next steps for algorithum
        }
    }
}
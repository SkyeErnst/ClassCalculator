using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.Collections.Generic;

namespace ClassCalculater
{
    public partial class MainForm : Form
    {
        #region Public Properties
        public static int AMax { get; set; }
        public static int AMin { get; set; }
        public static int BMax { get; set; }
        public static int BMin { get; set; }
        public static int CMax { get; set; }
        public static int CMin { get; set; }
        public static int DMax { get; set; }
        public static int DMin { get; set; }
        public static int FPoint { get; set; }
        #endregion

        #region public fields

        /// <summary>
        /// The base input for the number of assignments
        /// </summary>
        public int numberOfAssignments;

        public List<TextBox> textBoxes;

        #endregion

        #region private fields
        /// <summary>
        /// If the form has been generated or not
        /// </summary>
        private bool hasGenerated;

        /// <summary>
        /// The total number of assignments, 
        /// accounting for assignemnts that may have been added after the first generation of the form.
        /// </summary>
        private int assignmentsTotal;
        private int linesGenerated = 0;

        private const int DEFAULT_Y_OFFSET = 25;
        private const string DEFAULT_TEXT = "Waiting For Generation";

        /// <summary>
        /// How far down each control will be from each other, in pixels.
        /// </summary>
        private int yOffset = 25;

        #endregion

        public MainForm()
        {
            InitializeComponent();

            AMax = 100;
            AMin = 90;
            BMax = 89;
            BMin = 80;
            CMax = 79;
            CMin = 70;
            DMax = 69;
            DMin = 60;
            FPoint = DMin - 1;

            UpdateRanges();
        }

        /// <summary>
        /// Updates the text representation of the grades
        /// </summary>
        public void UpdateRanges()
        {
            aMaxLabel.Text = AMax.ToString(CultureInfo.CurrentCulture);
            aMinLabel.Text = AMin.ToString(CultureInfo.CurrentCulture);

            bMaxLabel.Text = BMax.ToString(CultureInfo.CurrentCulture);
            bMinLabel.Text = BMin.ToString(CultureInfo.CurrentCulture);

            cMaxLabel.Text = CMax.ToString(CultureInfo.CurrentCulture);
            cMinLabel.Text = CMin.ToString(CultureInfo.CurrentCulture);

            dMaxLabel.Text = DMax.ToString(CultureInfo.CurrentCulture);
            dMinLabel.Text = DMin.ToString(CultureInfo.CurrentCulture);

            fPointLabel.Text = FPoint.ToString(CultureInfo.CurrentCulture);
        }

        private void GenerateButtonClick(object sender, EventArgs e)
        {
            // Inform the user that content must be cleared first.
            if (true == hasGenerated)
            {
                MessageBox.Show("You must clear created content before asking for new content to be generated.");
                return;
            }

            // Attempts to get the number of assignments
            // This should never have to be caught, but its there just in case.
            try
            {
                numberOfAssignments = Int32.Parse(assignmentNumberInput.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Either a type mismatch has occured, or the input textbox is empty");
            }

            textBoxes = new List<TextBox>();
            AddTextBoxes(numberOfAssignments);
        }

        /// <summary>
        /// Will add the three boxes needed for each assignemnt to the form.
        /// </summary>
        /// <param name="assignmentAmounts"></param>
        private void AddTextBoxes(int assignmentAmounts)
        {
            int totalBoxesToGenerate;
            assignmentsTotal += assignmentAmounts;
            // Three colums of information, so we need assignemnts * 3 to hold all information
            
            if(false == hasGenerated)
            {
                totalBoxesToGenerate = assignmentAmounts * 3;
            }
            else
            {
                totalBoxesToGenerate = (Int32.Parse(boxesToAdd.Text));
            }

            for (int i = 0; i < totalBoxesToGenerate; i++)
            {
                textBoxes.Add(new TextBox());
            }

            // Adds the new textboxes to the form
            foreach (TextBox tb in textBoxes)
            {
                this.Controls.Add(tb);
            }

            int numberOfColums = 3;
            int lineNumber = 0; // The line number we start with
            Point[] xStart;
            xStart = new Point[3];

            // If we havent generated lines before, then 
            if(false == hasGenerated)
            {
                xStart[0] = assignmentNameLabel.Location;
                xStart[1] = gradeLabel.Location;
                xStart[2] = percentOfTotalGradeLabel.Location;
            }
            else
            {
                Point assignL = assignmentNameLabel.Location;
                assignL.Y += yOffset;
                xStart[0] = assignL;

                Point gradeL = gradeLabel.Location;
                gradeL.Y += yOffset;
                xStart[1] = gradeL;

                Point percentTGL = percentOfTotalGradeLabel.Location;
                percentTGL.Y += yOffset;
                xStart[2] = percentTGL;
            }
            
            // starting ammount should be number of lines generated so far
            // Every three generations, next set of boxes down 20 pixels
            for (int i = linesGenerated; i < assignmentsTotal; i++)
            {
                // Generate n number of colums, using the values of xStart as base points
                for (int j = 0; j < numberOfColums; j++)
                {
                    Point tempPoint1 = xStart[j];
                    tempPoint1.Y += yOffset;

                    if(false == hasGenerated)
                    {
                        textBoxes[j + lineNumber].Location = tempPoint1;
                    }
                    else
                    {
                        textBoxes[j + lineNumber + numberOfAssignments].Location = tempPoint1;
                    }
                }
                lineNumber += 3;
                linesGenerated += 1;
                yOffset += 20;
            }

            hasGenerated = true;
        }

        /// <summary>
        /// Clears all generated text and text boxes, and removes text boxes from the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearFormClick(object sender, EventArgs e)
        {
            if(null != textBoxes)
            {
                foreach (TextBox tB in textBoxes)
                {
                    this.Controls.Remove(tB);
                    textBoxes = null;
                }
            }
            yOffset = DEFAULT_Y_OFFSET;
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
            for (int i = 0; i < textBoxes.Count; i++)
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
                weightSum.Text = percentSum.ToString(CultureInfo.CurrentCulture);
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
            if (DMax >= (int)weightedGrade && DMin <= (int)weightedGrade)
            {
                return "D";
            }
            else if (CMax >= (int)weightedGrade && CMin <= (int)weightedGrade)
            {
                return "C";
            }
            else if (BMax >= (int)weightedGrade && BMin <= (int)weightedGrade)
            {
                return "B";
            }
            else if ((AMax >= (int)weightedGrade && AMin <= (int)weightedGrade) || (100 < (int)weightedGrade))
            {
                return "A";
            }
            else if (FPoint >= (int)weightedGrade)
            {
                return "F";
            }
            else
            {
                MessageBox.Show("Error, weighted grade did not match any defined bounds.");
                return null;
            }
        }

        /// <summary>
        /// Generates a new letter grade range editing form and displays it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditToolStripMenuGrade_Click(object sender, EventArgs e)
        {
            LetterGradeRangeEditForm editForm = new LetterGradeRangeEditForm();
            editForm.ShowDialog();
        }

        /// <summary>
        /// Method for adding more text boxes after the generation of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBoxesButton_Click(object sender, EventArgs e)
        {
            AddTextBoxes(Int32.Parse(boxesToAdd.Text));
        }
    }
}
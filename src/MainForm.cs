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

        /// <summary>
        /// The list that contains the user control
        /// objects for input.
        /// </summary>
        public List<ClassCalculater.src.AssignmentInput> textBoxes;

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
        private int assignmentsTotal = 0;
        /// <summary>
        /// The tottal number of lines of assignments that have been generated so far.
        /// </summary>
        private int linesGenerated = 0;

        
        private int yOffset = 40;

        private const int DEFAULT_Y_OFFSET = 40;
        private const int DEFAULT_LINES_GENERATED = 0;
        private const int DEFAULT_ASSIGNMENT_TOTAL = 0;
        private const string DEFAULT_TEXT = "Waiting For Generation";
        private const string PARTIAL_NOT_USED_TEXT = "Partial score not needed\nas all weights are provided";
        private const string PARTIAL_USED_TEXT = "Using partial score, weight sum < 1.0";

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

        /// <summary>
        /// Event that is called when the user clicks the generate form button.
        /// Will generate the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            textBoxes = new List<src.AssignmentInput>();
            AddTextBoxes(numberOfAssignments);
        }

        /// <summary>
        /// Will add the three boxes needed for each assignemnt to the form.
        /// </summary>
        /// <param name="assignmentsToAdd"></param>
        private void AddTextBoxes(int assignmentsToAdd)
        {

            assignmentsTotal += assignmentsToAdd;
            Point ongoing;

            if(false == hasGenerated)
            {
                ongoing = assignmentNameLabel.Location;
            }
            else
            {
                ongoing = textBoxes[textBoxes.Count - 1].Location;
            }

            for (int i = linesGenerated; i < assignmentsTotal; i++)
            {
                textBoxes.Add(new src.AssignmentInput());
                this.Controls.Add(textBoxes[i]);

                ongoing.Y += yOffset;
                textBoxes[i].Location = ongoing;
                linesGenerated += 1;
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
                foreach (src.AssignmentInput tB in textBoxes)
                {
                    this.Controls.Remove(tB);
                    textBoxes = null;
                }
            }
            hasGenerated = false;
            yOffset = DEFAULT_Y_OFFSET;
            linesGenerated = DEFAULT_LINES_GENERATED;
            assignmentsTotal = DEFAULT_ASSIGNMENT_TOTAL;
            letterGrade.Text = DEFAULT_TEXT;
            weightedGrade.Text = DEFAULT_TEXT;
            unweightedAverage.Text = DEFAULT_TEXT;
            weightedAveragePartial.Text = DEFAULT_TEXT;
        }

        private void CalcGradeButtonClick(object sender, EventArgs e)
        {
            // Sum the weights, and clac unweighted grade
            float summedWeights = 0.0f;
            float unweightGrade = 0.0f;
            for (int i = 0; i < assignmentsTotal; i++)
            {
                summedWeights += textBoxes[i].AssignmentWeight;
                unweightGrade += textBoxes[i].AssignemntGrade;
            }
            // Update form text
            unweightedAverage.Text = unweightGrade.ToString(CultureInfo.CurrentCulture);
            weightSum.Text = summedWeights.ToString(CultureInfo.CurrentCulture);

            // If sum of weights is less than 1, warn user, update partial weight form
            if(1.0f > summedWeights)
            {
                MessageBox.Show("Sum of weights is not equal to 1.0.\n" +
                    "If this is intentional, no action need be taken.\n" +
                    "If it is not intentional, ensure that weights are entered corectly.\n" +
                    "Weight sum should never be more than 1.0!");
                CalcNumberGrade(true, summedWeights);
            }
            else
            {
                CalcNumberGrade(false, summedWeights);
            }

            //string[] nameArray = new string[numberOfAssignments];
            //float[] gradeArray = new float[numberOfAssignments];
            //float[] percentArray = new float[numberOfAssignments];

            //int nameArrIndex = 0;
            //int gradeArrIndex = 0;
            //int percentArrIndex = 0;

            //float unweightedTotal = 0;
            //float percentSum = 0.0f;
            //float weightedGrade = 0.0f;

            //// Seperate the data in the textboxes array into seperate arrays
            //// for easier traversal
            //for (int i = 0; i < textBoxes.Count; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        nameArray[nameArrIndex] = textBoxes[i].Text;
            //        nameArrIndex += 1;
            //    }
            //    else if ((i - 1) % 3 == 0)
            //    {
            //        gradeArray[gradeArrIndex] = float.Parse(textBoxes[i].Text);
            //        gradeArrIndex += 1;
            //    }
            //    else if ((i - 2) % 3 == 0)
            //    {
            //        percentArray[percentArrIndex] = float.Parse(textBoxes[i].Text);
            //        percentArrIndex += 1;
            //    }
            //}

            //// Suming the unweighted total
            //for (int i = 0; i < gradeArray.Length; i++)
            //{
            //    unweightedTotal += gradeArray[i];
            //}

            //unweightedTotal = unweightedTotal / numberOfAssignments;
            //unweightedAverage.Text = unweightedTotal.ToString(CultureInfo.CurrentCulture);

            //// Ensure that the sum of the weights is not greater than 1, warning if it is
            //// If it is not, calculate the weighted grade and partial grade.
            //for (int i = 0; i < percentArray.Length; i++)
            //{
            //    percentSum += percentArray[i];
            //    weightSum.Text = percentSum.ToString(CultureInfo.CurrentCulture);
            //}
            //if (1.0f < percentSum)
            //{
            //    MessageBox.Show("Sum of weights is more than 1.0. Ensure that weights are entered correctly");
            //}
            //else
            //{

            //    for (int i = 0; i < gradeArray.Length; i++)
            //    {
            //        weightedGrade += gradeArray[i] * percentArray[i];
            //        this.weightedGrade.Text = weightedGrade.ToString(CultureInfo.CurrentCulture);
            //    }

            //    if (1.0f > percentSum)
            //    {
            //        MessageBox.Show("sum of weights is less than 1.0. If this is not intentional, check " +
            //            "entered weights for accuracy.");
            //        weightedAveragePartial.Text = (weightedGrade / (percentSum)).ToString(CultureInfo.CurrentCulture);
            //    }
            //    else
            //    {
            //        weightedAveragePartial.Text = weightedGrade.ToString(CultureInfo.CurrentCulture);
            //    }

            //    letterGrade.Text = CalcLetterGrade(weightedGrade);
            //}
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

        private void CalcNumberGrade(bool partial, float totalWeight)
        {
            int rawSum = 0;
            int unweighted = 0;
            float weighted = 0;

            // calc total ra
            for (int i = 0; i < textBoxes.Count; i++)
            {
                rawSum += textBoxes[i].AssignemntGrade; 
            }
            unweightedAverage.Text = (rawSum / textBoxes.Count).ToString(CultureInfo.CurrentCulture);

            if (true == partial)
            {
                for (int i = 0; i < textBoxes.Count; i++)
                {
                    weighted += textBoxes[i].AssignemntGrade * textBoxes[i].AssignmentWeight;
                }

                weightedAveragePartial.Text = ((rawSum / textBoxes.Count) / totalWeight).ToString(CultureInfo.CurrentCulture);
                weightedGrade.Text = PARTIAL_USED_TEXT;
                CalcLetterGrade((rawSum / textBoxes.Count) / totalWeight);
            }
            else
            {
                for (int i = 0; i < textBoxes.Count; i++)
                {
                    weighted += textBoxes[i].AssignemntGrade * textBoxes[i].AssignmentWeight;
                }
                weightedGrade.Text = weighted.ToString(CultureInfo.CurrentCulture);
                weightedAveragePartial.Text = PARTIAL_NOT_USED_TEXT;
            }
            CalcLetterGrade(weighted);
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
            try
            {
                AddTextBoxes(Int32.Parse(boxesToAdd.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Either a type missmatch has occured, or the input box is empty.");
            }
        }
    }
}
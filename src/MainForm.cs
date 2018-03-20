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
        public List<AssignmentInput> assignments;

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
        /// <summary>
        /// The tottal number of lines of assignments that have been generated so far.
        /// </summary>
        private int linesGenerated;

        /// <summary>
        /// Name of the last file saved to.
        /// </summary>
        private string fileName;

        
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

            assignments = new List<AssignmentInput>();
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
                ongoing = assignments[assignments.Count - 1].Location;
            }

            for (int i = linesGenerated; i < assignmentsTotal; i++)
            {
                assignments.Add(new AssignmentInput());
                this.Controls.Add(assignments[i]);

                ongoing.Y += yOffset;
                assignments[i].Location = ongoing;
                linesGenerated += 1;
            }

            hasGenerated = true;
        }

        /// <summary>
        /// Helper method for the OrganizeForm method. Will ONLY organize already generated and added
        /// text boxes
        /// </summary>
        /// <param name="lst"></param>
        private void AddTextBoxes()
        {
            Point ongoing = assignmentNameLabel.Location;

            for (int i = linesGenerated; i < assignmentsTotal; i++)
            {
                ongoing.Y += yOffset;
                assignments[i].Location = ongoing;
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
            if(null != assignments)
            {
                foreach (AssignmentInput tB in assignments)
                {
                    this.Controls.Remove(tB);
                    assignments = null;
                }
            }
            ClearForm();
        }

        /// <summary>
        /// Method for clearing just the information from the right hand side of the application
        /// </summary>
        private void ClearForm()
        {
            hasGenerated = false;
            weightSum.Text = "0";
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
                summedWeights += assignments[i].AssignmentWeight;
                unweightGrade += assignments[i].AssignemntGrade;
            }
            // Update form text
            unweightedAverage.Text = unweightGrade.ToString(CultureInfo.CurrentCulture);
            weightSum.Text = summedWeights.ToString(CultureInfo.CurrentCulture);

            CalcNumberGrade();
        }

        /// <summary>
        /// Given the weighted grade, will return the letter grade based on current settings for grade ranges
        /// </summary>
        /// <param name="weightedGrade"></param>
        /// <returns></returns>
        private string CalcLetterGrade(float weightedGrade)
        {
            string car;

            // Finds the letter grade
            if (DMax >= (int)weightedGrade && DMin <= (int)weightedGrade)
            {
                car = "D";

            }
            else if (CMax >= (int)weightedGrade && CMin <= (int)weightedGrade)
            {
                car = "C";
            }
            else if (BMax >= (int)weightedGrade && BMin <= (int)weightedGrade)
            {
                car = "B";
            }
            else if ((AMax >= (int)weightedGrade && AMin <= (int)weightedGrade) || (100 < (int)weightedGrade))
            {
                car = "A";
            }
            else if (FPoint >= (int)weightedGrade)
            {
                car = "F";
            }
            else
            {
                MessageBox.Show("Error, weighted grade did not match any defined bounds.");
                return null;
            }

            return car;
        }

        /// <summary>
        /// Calculates both the partial and fully weighted grade
        /// </summary>
        /// <param name="full">Weather or not the weights being handed in are less than 1.0 </param>
        /// <param name="totalWeight">The sum of the weights for all assignments </param>
        private void CalcNumberGrade()
        {
            bool full;
            int rawSum = 0;
            float weighted = 0;
            float totalWeight = 0;

            for (int i = 0; i < assignments.Count; i++)
            {
                rawSum += assignments[i].AssignemntGrade;
                totalWeight += assignments[i].AssignmentWeight;
            }

            if(1.0f > totalWeight)
            {
                full = false;
                MessageBox.Show("Sum of weights is not equal to 1.0.\n" +
                "If this is intentional, no action need be taken.\n" +
                "If it is not intentional, ensure that weights are entered corectly.\n" +
                "Weight sum should never be more than 1.0!");
            }
            else
            {
                full = true;
            }

            for (int i = 0; i < assignments.Count; i++)
            {
                weighted += assignments[i].AssignemntGrade * assignments[i].AssignmentWeight;
            }

            if (false == full)
            {
                weighted = weighted / totalWeight;
                weightedAveragePartial.Text = (weighted).ToString(CultureInfo.CurrentCulture);
                weightedGrade.Text = PARTIAL_USED_TEXT;
            }
            else
            {
                weightedGrade.Text = weighted.ToString(CultureInfo.CurrentCulture);
                weightedAveragePartial.Text = PARTIAL_NOT_USED_TEXT;
            }

            unweightedAverage.Text = (rawSum / assignments.Count).ToString(CultureInfo.CurrentCulture);

            UpdateLetterGrade(CalcLetterGrade(weighted));
        }

        /// <summary>
        /// Generates a new letter grade range editing form and displays it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditLetterGradeRange(object sender, EventArgs e)
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

        /// <summary>
        /// Method for handling changes to the letter grade
        /// </summary>
        /// <param name="gradeLetter"></param>
        private void UpdateLetterGrade(string gradeLetter)
        {
            letterGrade.Text = gradeLetter;
        }

        /// <summary>
        /// Method for handling the clicking of the open file dropdown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFileClick(object sender, EventArgs e)
        {
            ClearFormClick(null, null);
            MainProgram.ioManRef.ReadFromFile(ref assignments);

            assignmentsTotal = assignments.Count;

            CalcGradeButtonClick(null, null);
            OrganizeFormControls();
        }

        /// <summary>
        /// Method for handling the clicking of the save file dropdown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveFileClick(object sender, EventArgs e)
        {
            if (false == hasGenerated)
            {
                MessageBox.Show("Please generate the form and fill with data before attempting to save.");
            }
            else
            {
                SaveFileDialog save = new SaveFileDialog();
                save.ShowDialog();
                MainProgram.ioManRef.WriteToFile(assignments, save.FileName);
            }
        }

        /// <summary>
        /// Given a reference to a list of AssignmentInput classes, 
        /// formats their contents onto this form.
        /// </summary>
        private void OrganizeFormControls()
        {
            foreach (AssignmentInput inp in assignments)
            {
                this.Controls.Add(inp);
            }

            AddTextBoxes();
        }

        public void SetFileName(string input)
        {
            fileName = input;
        }
    }
}
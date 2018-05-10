using System;
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

        public string EditingFileName
        {
            set
            {
                fileNameLabel.Text = value;
            }
        }
        #endregion

        #region private fields

        /// <summary>
        /// The list that contains the user control
        /// objects for input.
        /// </summary>
        private List<AssignmentInput> assignments;

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
        /// The base input for the number of assignments
        /// </summary>
        private int numberOfAssignments;

        private int yOffset = 40;

        private const int DEFAULT_Y_OFFSET = 40;
        private const int DEFAULT_LINES_GENERATED = 0;
        private const int DEFAULT_ASSIGNMENT_TOTAL = 0;
        private const string DEFAULT_FILE_NAME = "No file";
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

            AddBoxesStart(null, null);
        }

        /// <summary>
        /// Helper method that allows for both UI generated calls and internal calls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBoxesStart(object sender, EventArgs e)
        {
            int numAssignmentsToAdd;

            if(null == sender && null == e)
            {
                numAssignmentsToAdd = numberOfAssignments;
            }
            else
            {
                numAssignmentsToAdd = Int32.Parse(boxesToAdd.Text);
            }

            MainProgram.assistant.AddTextBoxes(assignments,
                                   numAssignmentsToAdd,
                                   ref assignmentsTotal,
                                   yOffset,
                                   DEFAULT_Y_OFFSET,
                                   ref linesGenerated,
                                   ref hasGenerated,
                                   assignmentNameLabel,
                                   this);
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
            fileNameLabel.Text = DEFAULT_FILE_NAME;
        }

        /// <summary>
        /// Only called by the UI, makes a call into the assistant class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalcGradeButtonClick(object sender, EventArgs e)
        {
            MainProgram.assistant.CalculateGrade(assignmentsTotal,
                                                 assignments,
                                                 unweightedAverage,
                                                 weightSum,
                                                 weightedAveragePartial,
                                                 weightedGrade,
                                                 PARTIAL_USED_TEXT,
                                                 PARTIAL_NOT_USED_TEXT);
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
        /// Method for handling changes to the letter grade
        /// </summary>
        /// <param name="gradeLetter"></param>
        public void UpdateLetterGrade(string gradeLetter)
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

            MainProgram.assistant.OrganizeTextBoxes(assignments,
                                                    assignmentNameLabel,
                                                    linesGenerated,
                                                    assignmentsTotal,
                                                    yOffset,
                                                    hasGenerated);
        }

        private void RemoveLines(object sender, EventArgs e)
        {
            MainProgram.assistant.RemoveLines(this, ref assignments, lineRemovalInputBox, ref assignmentsTotal, ref linesGenerated);
        }
    }
}
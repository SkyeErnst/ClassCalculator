using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassCalculater
{
    public partial class MainForm : Form
    {

        #region public fields
        public int numberOfAssignments;
        public TextBox[,] textBoxes;
        #endregion

        #region private fields

        #endregion


        public MainForm()
        {
            InitializeComponent();
        }

        private void generateButtonClick(object sender, EventArgs e)
        {
            try
            {
                numberOfAssignments = Int32.Parse(assignmentNumberInput.Text);
            }
            catch (Exception)
            {
                Console.WriteLine("There is likely a type mismatch. Please ensure only ints are fed into input box");
            }

            //InputControl[] controls = new InputControl[numberOfAssignments];

            TextBox[] textBoxes = new TextBox[numberOfAssignments];


            for (int i = 0; i < numberOfAssignments; i++)
            {
                textBoxes[i] = new TextBox();
                this.Controls.Add(textBoxes[i]);
            }

            int yOffset = 20; //This is how far down each control will be from eachother
            int loopCount = 0;
            Point[] xStart;
            xStart = new Point[3];
            xStart[0] = assignmentNameLabel.Location;
            xStart[1] = gradeLabel.Location;
            xStart[2] = percentOfTotalGradeLabel.Location;

            for (int i = 0; i < numberOfAssignments; i++)
            {
                if (2 == loopCount)
                {
                    yOffset += 20;
                    loopCount = 0;
                }

                textBoxes[i].Location = xStart[loopCount];

                loopCount++;
            }

        }
    }
}

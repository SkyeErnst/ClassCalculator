using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ClassCalculater
{
    /// <summary>
    /// Class to encapsulate the methods needed to perform data manipulation 
    /// on the main form.
    /// </summary>
    public class MainFormAssistant
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="originalObject"></param>
        /// <param name="assignments"></param>
        /// <param name="lineRemovalInputBox"></param>
        /// <param name="assignmentsTotal"></param>
        /// <param name="linesGenerated"></param>
        public void RemoveLines(Form originalObject,
                                ref List<AssignmentInput> assignments, 
                                MaskedTextBox lineRemovalInputBox, 
                                ref int assignmentsTotal,
                                ref int linesGenerated
                                )
        {
            int toRem = 0;
            int index = assignments.Count - 1;

            try
            {
                toRem = Int32.Parse(lineRemovalInputBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (assignments.Count < toRem)
            {
                toRem = assignments.Count;
            }

            assignmentsTotal -= toRem;
            linesGenerated -= toRem;

            Control.ControlCollection allControls;
            allControls = originalObject.Controls;

            // While there are still assignments left to remove
            // Look for the last insatnce of an Assignment Input
            // Loop until we have removed enough of the controls
            while (0 < toRem)
            {
                assignments.RemoveAt(index);

                for (int i = (allControls.Count - 1); i != 0; i--)
                {
                    if (typeof(AssignmentInput) == allControls[i].GetType())
                    {
                        originalObject.Controls[i].Dispose();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Control: " + originalObject.Controls[i] + " is not of type: " + typeof(AssignmentInput));
                    }

                }

                toRem--;
                index--;
            }

        }

        public void CalculateGrade(int assignmentsTotal,
                                  List<AssignmentInput> assignments,
                                  Label unweightedAverage,
                                  Label weightSum,
                                  Label weightedAveragePartial,
                                  Label weightedGrade,
                                  string PARTIAL_USED_TEXT,
                                  string PARTIAL_NOT_USED_TEXT
                                  )
        {
            // Sum the weights, and calc unweighted grade
            float summedWeights = 0.0f;
            float unweightGrade = 0.0f;
            for (int i = 0; i < assignmentsTotal; i++)
            {
                summedWeights += (assignments[i].AssignmentWeight);
                unweightGrade += assignments[i].AssignemntGrade;
            }

            summedWeights *= .01f;

            // Update form text
            unweightedAverage.Text = unweightGrade.ToString(CultureInfo.CurrentCulture);
            weightSum.Text = summedWeights.ToString(CultureInfo.CurrentCulture);

            CalcNumberGrade(assignments, 
                            weightedAveragePartial, 
                            weightedGrade, 
                            unweightedAverage, 
                            PARTIAL_USED_TEXT, 
                            PARTIAL_NOT_USED_TEXT);
        }

        /// <summary>
        /// Calculates both the partial and fully weighted grade
        /// </summary>
        /// <param name="full">Weather or not the weights being handed in are less than 1.0 </param>
        /// <param name="totalWeight">The sum of the weights for all assignments </param>
        private void CalcNumberGrade(List<AssignmentInput> assignments,
                                    Label weightedAveragePartial,
                                    Label weightedGrade,
                                    Label unweightedAverage,
                                    string PARTIAL_USED_TEXT,
                                    string PARTIAL_NOT_USED_TEXT
                                    )
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

            // Weights are entered as mixed numbers,
            // converts to a multipliable weight.
            totalWeight = totalWeight * .01f;

            if (1.0f > totalWeight)
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
                weighted += assignments[i].AssignemntGrade * (assignments[i].AssignmentWeight * .01f);
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

            MainProgram.mainFormRef.UpdateLetterGrade(CalcLetterGrade(weighted));
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
            if (MainForm.DMax >= (int)weightedGrade && MainForm.DMin <= (int)weightedGrade)
            {
                car = "D";

            }
            else if (MainForm.CMax >= (int)weightedGrade && MainForm.CMin <= (int)weightedGrade)
            {
                car = "C";
            }
            else if (MainForm.BMax >= (int)weightedGrade && MainForm.BMin <= (int)weightedGrade)
            {
                car = "B";
            }
            else if ((MainForm.AMax >= (int)weightedGrade && MainForm.AMin <= (int)weightedGrade) || (100 < (int)weightedGrade))
            {
                car = "A";
            }
            else if (MainForm.FPoint >= (int)weightedGrade)
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
        /// Will add the three boxes needed for each assignemnt to the form.
        /// </summary>
        /// <param name="assignmentsToAdd"></param>
        public void AddTextBoxes(List<AssignmentInput> assignments,
                                  int assignmentsToAdd,
                                  ref int assignmentsTotal,
                                  int yOffset,
                                  int DEFAULT_Y_OFFSET,
                                  ref int linesGenerated,
                                  ref bool hasGenerated,
                                  Label assignmentNameLabel,
                                  Form originalObject
                                  )
        {

            assignmentsTotal += assignmentsToAdd;
            Point ongoing;

            if (false == hasGenerated)
            {
                ongoing = assignmentNameLabel.Location;
            }
            else
            {
                ongoing = assignments[assignments.Count - 1].Location;
            }

            yOffset = DEFAULT_Y_OFFSET;

            for (int i = linesGenerated; i < assignmentsTotal; i++)
            {

                AssignmentInput inp = new AssignmentInput();
                originalObject.Controls.Add(inp);

                ongoing.Y += Math.Abs(yOffset);

                assignments.Add(inp);


                inp.Location = ongoing;

                linesGenerated += 1;

            }

            hasGenerated = true;
        }

        /// <summary>
        /// Helper method for the OrganizeForm method. WILL ONLY organize already generated and added
        /// text boxes
        /// </summary>
        /// <param name="lst"></param>
        public void OrganizeTextBoxes(List<AssignmentInput> assignments,
                                       Label assignmentNameLabel,
                                       int linesGenerated,
                                       int assignmentsTotal,
                                       int yOffset,
                                       bool hasGenerated)
        {
            Point ongoing = assignmentNameLabel.Location;

            for (int i = linesGenerated; i < assignmentsTotal; i++)
            {
                ongoing.Y += Math.Abs(yOffset);
                assignments[i].Location = ongoing;
                linesGenerated += 1;
            }

            hasGenerated = true;
        }
    }
}

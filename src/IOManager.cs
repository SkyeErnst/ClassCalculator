using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ClassCalculater
{
    /// <summary>
    /// Class for managing xml input and output
    /// </summary>
    public class IOManager
    {

        #region Private fields

        private const string ASSIGNMENT_NAME_TAG = "Name";
        private const string GRADE_TAG = "Grade";
        private const string WEIGHT_TAG = "Weight";

        /// <summary>
        /// The path to the save directory for files
        /// </summary>
        private string path;

        #endregion
        /// <summary>
        /// Constructor
        /// </summary>
        public IOManager()
        {
            MessageBox.Show("Please select folder for saving and loading grade files.");
            FolderBrowserDialog folderBrowDiag = new FolderBrowserDialog();

            // Shows the folder browser and waits, will execute if statement
            // only if the user presses the okay button
            if (folderBrowDiag.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowDiag.SelectedPath;
            }
        }

        /// <summary>
        /// Will write all data from list of AssignmentInput objects to xml file
        /// </summary>
        /// <param name="boxes"></param>
        public void WriteToFile(List<AssignmentInput> boxes, string fileName)
        {
            if (false == File.Exists(fileName))
            {
                XmlWriter writer = XmlWriter.Create(fileName, null);
                writer.WriteStartDocument();

                foreach (AssignmentInput ai in boxes)
                {
                    writer.WriteStartElement(ASSIGNMENT_NAME_TAG);
                    writer.WriteStartAttribute(ai.AssignmentName);
                    writer.WriteEndAttribute();
                    writer.WriteEndElement();

                    writer.WriteStartElement(GRADE_TAG);
                    writer.WriteStartAttribute(ai.AssignemntGrade.ToString(CultureInfo.CurrentCulture));
                    writer.WriteEndAttribute();
                    writer.WriteEndElement();

                    writer.WriteStartElement(WEIGHT_TAG);
                    writer.WriteStartAttribute(ai.AssignmentWeight.ToString(CultureInfo.CurrentCulture));
                    writer.WriteEndAttribute();
                    writer.WriteEndElement();
                }

            }
            else
            {
                MessageBox.Show("ERROR: XML file with name " + fileName + " already exists.");
            }
            throw new NotImplementedException();
        }

        /// <summary>
        /// Reads data from spesified file name and returns that data formated as an
        /// AssignmentInput object
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public List<AssignmentInput> ReadFromFile(string fileName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Opens the file dialog, and if the user clicks okay after selecting a file
        /// returns the name of that file
        /// </summary>
        /// <returns></returns>
        public string OpenDialogue()
        {
            throw new NotImplementedException();
        }
    }
}
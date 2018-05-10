using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using System.Xml;

namespace ClassCalculater
{
    /// <summary>
    /// Class for managing xml input and output
    /// </summary>
    public class IOManager
    {
        #region Internal Fields
        /// <summary>
        /// This is the current version of how serializing to XML is handled
        /// within the program. This is NOT the xml version number refering to
        /// the language revisions.
        /// </summary>
        internal static string XMLWritingVersion = "1.0";
        // Changelog: 1.1: Switched to different method of entering weights
        #endregion

        #region Private fields

        private const string ASSIGNMENT_NAME_TAG = "Name";
        private const string GRADE_TAG = "Grade";
        private const string WEIGHT_TAG = "Weight";
        private const string ASSIGNMENT_NUMBERING = "assignment_number_";

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
            string extensionHandledFileName;
            // Takes care of xml extension
            if (".xml" != fileName.Substring(fileName.Length - 4))
            {
                extensionHandledFileName = fileName + ".xml";
            }
            else
            {
                extensionHandledFileName = fileName;
            }

            // Sets up settings for the xml writer
            XmlWriterSettings formatSettings = new XmlWriterSettings
            {
                NewLineOnAttributes = true,
                Indent = true
            };

            // Create new xml document at given path
            XmlWriter writer = XmlWriter.Create(extensionHandledFileName, formatSettings);
               
            // Starts writing to document
            writer.WriteStartDocument();
            writer.WriteStartElement("Assignments");

            // Records the information to the file
            for (int i = 0; i < boxes.Count; i++)
            {
                try
                {
                    writer.WriteStartElement(ASSIGNMENT_NUMBERING + i);
                    writer.WriteAttributeString(ASSIGNMENT_NAME_TAG, boxes[i].AssignmentName);
                    writer.WriteAttributeString(GRADE_TAG, boxes[i].AssignemntGrade.ToString(CultureInfo.CurrentCulture));
                    writer.WriteAttributeString(WEIGHT_TAG, boxes[i].AssignmentWeight.ToString(CultureInfo.CurrentCulture));
                    writer.WriteEndElement();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            // Places the closing tags and closes the document. 
            writer.WriteEndDocument();
            writer.Close();

            MainProgram.mainFormRef.EditingFileName = extensionHandledFileName;
        }

        /// <summary>
        /// Prompts the user to find and select a file, then opens that file 
        /// and reads the data into a list, which it then assigns to the refferenced list.
        /// </summary>
        /// <returns></returns>
        public void ReadFromFile(ref List<AssignmentInput> list)
        {
            OpenFileDialog fileDialogue = new OpenFileDialog();

            DialogResult result = fileDialogue.ShowDialog();

            if (DialogResult.OK == result)
            {
                list = new List<AssignmentInput>();

                string file = fileDialogue.FileName;
                XmlReader reader = XmlReader.Create(file);

                XmlDocument doc = new XmlDocument();
                doc.Load(file);

                XmlElement root = doc.DocumentElement;
                XmlNodeList nodes = root.ChildNodes;

                List<XmlNode> nodeAttrib = new List<XmlNode>();

                XmlAttributeCollection xmlAttr;

                foreach (XmlNode node in nodes)
                {

                    xmlAttr = node.Attributes;
                    AssignmentInput input = new AssignmentInput();

                    input.AssignmentName = xmlAttr[0].Value;
                    input.AssignemntGrade = Int32.Parse(xmlAttr[1].Value);
                    input.AssignmentWeight = float.Parse(xmlAttr[2].Value);

                    list.Add(input);
                }

                MainProgram.mainFormRef.EditingFileName = file;
            }  
        }

        /// <summary>
        /// Opens the file dialog, and if the user clicks okay after selecting a file
        /// returns the name of that file and its path.
        /// </summary>
        /// <returns></returns>
        public void OpenDialogue(out string path, out string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassCalculater
{
    public partial class InputControl : UserControl
    {
        public InputControl()
        {
            InitializeComponent();
        }

        #region public properties
        /// <summary>
        /// This is the name for the SET of three boxes, use the Contents
        /// property to get individual names of text boxes
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string[] Contents
        {
            get
            {
                string[] tmpArr = SplitOnComma(assignmentNameBox.Text + "," +
                    gradeBox.Text + "," + percentBox.Text);

                return tmpArr;
            }
            set
            {

            }
        }

        #endregion

        #region private fields

        private String name;

        #endregion

        #region private methods

        private string[] SplitOnComma(string str)
        {
            throw new NotImplementedException();
        }
        
        #endregion
    }
}

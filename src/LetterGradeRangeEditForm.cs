using System;
using System.Windows.Forms;

namespace ClassCalculater
{
    public partial class LetterGradeRangeEditForm : Form
    {
        #region Private Fields
        private bool confirmedExit;
        #endregion

        public LetterGradeRangeEditForm()
        {
            InitializeComponent();
        }

        private void LetterGradeRangeEdit_Load(object sender, EventArgs e)
        {
            confirmedExit = false;
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm.AMin = Int32.Parse(aMinBox.Text);
                MainForm.AMax = Int32.Parse(aMaxBox.Text);
                MainForm.BMin = Int32.Parse(bMaxBox.Text);
                MainForm.BMax = Int32.Parse(bMaxBox.Text);
                MainForm.CMin = Int32.Parse(cMaxBox.Text);
                MainForm.CMax = Int32.Parse(cMaxBox.Text);
                MainForm.DMin = Int32.Parse(dMaxBox.Text);
                MainForm.FPoint = MainForm.DMin - 1;
                MainProgram.mainFormRef.UpdateRanges();
                MessageBox.Show("Successfully saved the new grade ranges.");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Type conversion mismatch in letter grade range editing form, or other unexpected error");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (false == confirmedExit)
            {
                MessageBox.Show("Are you sure you want to close? Click okay and then cancel again if you are sure");
                confirmedExit = true;
            }
            else
            {
                this.Close();
            }
        }
    }
}

using System;
using System.Globalization;
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
                MainForm.AMax = Int32.Parse(aMaxLabel.Text);
                MainForm.BMin = Int32.Parse(bMinBox.Text);
                MainForm.BMax = Int32.Parse(bMaxLabel.Text);
                MainForm.CMin = Int32.Parse(cMinBox.Text);
                MainForm.CMax = Int32.Parse(cMaxLabel.Text);
                MainForm.DMin = Int32.Parse(dMinBox.Text);
                MainForm.DMax = Int32.Parse(dMaxLabel.Text);
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

        private void BMinBox_Leave(object sender, EventArgs e)
        {
            bMaxLabel.Text = (Int32.Parse(aMinBox.Text) - 1).ToString(CultureInfo.CurrentCulture);
        }

        private void CMinBox_Leave(object sender, EventArgs e)
        {
            cMaxLabel.Text = (Int32.Parse(bMinBox.Text) - 1).ToString(CultureInfo.CurrentCulture);
        }

        private void DMinBox_Leave(object sender, EventArgs e)
        {
            dMaxLabel.Text = (Int32.Parse(cMinBox.Text) - 1).ToString(CultureInfo.CurrentCulture);
        }
    }
}

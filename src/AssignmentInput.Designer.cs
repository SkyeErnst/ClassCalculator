namespace ClassCalculater
{
    partial class AssignmentInput
    {

        #region Public Properties
        /// <summary>
        /// The name of the assignemnt
        /// </summary>
        public string AssignmentName
        {
            get
            {
                return assignmentName.Text;
            }
            set
            {
                assignmentName.Text = value;
            }
        }
        /// <summary>
        /// The grade for the assignemnt
        /// </summary>
        public int AssignemntGrade
        {
            get
            {
                try
                {
                    return int.Parse(assignmentGrade.Text);
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
            set
            {
                assignmentGrade.Text = value.ToString();
            }
        }
        /// <summary>
        /// The weight of the assignemnt
        /// </summary>
        public float AssignmentWeight
        {
            get
            {
                try
                {
                    return float.Parse(assignmentWeight.Text);
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
            set
            {
                assignmentWeight.Text = value.ToString();
            }
        }
        #endregion

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.assignmentName = new System.Windows.Forms.TextBox();
            this.assignmentGrade = new System.Windows.Forms.TextBox();
            this.assignmentWeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // assignmentName
            // 
            this.assignmentName.Location = new System.Drawing.Point(0, 3);
            this.assignmentName.Name = "assignmentName";
            this.assignmentName.Size = new System.Drawing.Size(100, 20);
            this.assignmentName.TabIndex = 0;
            // 
            // assignmentGrade
            // 
            this.assignmentGrade.Location = new System.Drawing.Point(106, 3);
            this.assignmentGrade.Name = "assignmentGrade";
            this.assignmentGrade.Size = new System.Drawing.Size(100, 20);
            this.assignmentGrade.TabIndex = 1;
            // 
            // assignmentWeight
            // 
            this.assignmentWeight.Location = new System.Drawing.Point(212, 3);
            this.assignmentWeight.Name = "assignmentWeight";
            this.assignmentWeight.Size = new System.Drawing.Size(100, 20);
            this.assignmentWeight.TabIndex = 2;
            // 
            // AssignmentInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.assignmentWeight);
            this.Controls.Add(this.assignmentGrade);
            this.Controls.Add(this.assignmentName);
            this.Name = "AssignmentInput";
            this.Size = new System.Drawing.Size(316, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox assignmentName;
        private System.Windows.Forms.TextBox assignmentGrade;
        private System.Windows.Forms.TextBox assignmentWeight;
    }
}

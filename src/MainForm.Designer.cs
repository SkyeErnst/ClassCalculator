namespace ClassCalculater
{
    partial class MainForm
    {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numAssignmentsLabel = new System.Windows.Forms.Label();
            this.assignmentNameLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.percentOfTotalGradeLabel = new System.Windows.Forms.Label();
            this.assignmentNumberInput = new System.Windows.Forms.MaskedTextBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradeRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.generateFormButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // numAssignmentsLabel
            // 
            this.numAssignmentsLabel.AutoSize = true;
            this.numAssignmentsLabel.Location = new System.Drawing.Point(15, 25);
            this.numAssignmentsLabel.Name = "numAssignmentsLabel";
            this.numAssignmentsLabel.Size = new System.Drawing.Size(179, 20);
            this.numAssignmentsLabel.TabIndex = 1;
            this.numAssignmentsLabel.Text = "Number of Assignments";
            this.numAssignmentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // assignmentNameLabel
            // 
            this.assignmentNameLabel.AutoSize = true;
            this.assignmentNameLabel.Location = new System.Drawing.Point(15, 129);
            this.assignmentNameLabel.Name = "assignmentNameLabel";
            this.assignmentNameLabel.Size = new System.Drawing.Size(139, 20);
            this.assignmentNameLabel.TabIndex = 3;
            this.assignmentNameLabel.Text = "Assignment Name";
            this.assignmentNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(215, 129);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(54, 20);
            this.gradeLabel.TabIndex = 4;
            this.gradeLabel.Text = "Grade";
            this.gradeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // percentOfTotalGradeLabel
            // 
            this.percentOfTotalGradeLabel.AutoSize = true;
            this.percentOfTotalGradeLabel.Location = new System.Drawing.Point(315, 129);
            this.percentOfTotalGradeLabel.Name = "percentOfTotalGradeLabel";
            this.percentOfTotalGradeLabel.Size = new System.Drawing.Size(170, 20);
            this.percentOfTotalGradeLabel.TabIndex = 5;
            this.percentOfTotalGradeLabel.Text = "Percent of Total Grade";
            this.percentOfTotalGradeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // assignmentNumberInput
            // 
            this.assignmentNumberInput.AsciiOnly = true;
            this.assignmentNumberInput.BeepOnError = true;
            this.assignmentNumberInput.Location = new System.Drawing.Point(210, 25);
            this.assignmentNumberInput.Mask = "000";
            this.assignmentNumberInput.Name = "assignmentNumberInput";
            this.assignmentNumberInput.Size = new System.Drawing.Size(34, 26);
            this.assignmentNumberInput.TabIndex = 6;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gradeRangeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // gradeRangeToolStripMenuItem
            // 
            this.gradeRangeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem1});
            this.gradeRangeToolStripMenuItem.Name = "gradeRangeToolStripMenuItem";
            this.gradeRangeToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.gradeRangeToolStripMenuItem.Text = "Grade Range";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(94, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // generateFormButton
            // 
            this.generateFormButton.Location = new System.Drawing.Point(260, 25);
            this.generateFormButton.Name = "generateFormButton";
            this.generateFormButton.Size = new System.Drawing.Size(128, 29);
            this.generateFormButton.TabIndex = 7;
            this.generateFormButton.Text = "Generate Form";
            this.generateFormButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generateFormButton.UseVisualStyleBackColor = true;
            this.generateFormButton.Click += new System.EventHandler(this.generateButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.generateFormButton);
            this.Controls.Add(this.assignmentNumberInput);
            this.Controls.Add(this.percentOfTotalGradeLabel);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.assignmentNameLabel);
            this.Controls.Add(this.numAssignmentsLabel);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Class Calculator";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label numAssignmentsLabel;
        private System.Windows.Forms.Label assignmentNameLabel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label percentOfTotalGradeLabel;
        private System.Windows.Forms.MaskedTextBox assignmentNumberInput;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradeRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Button generateFormButton;
    }
}


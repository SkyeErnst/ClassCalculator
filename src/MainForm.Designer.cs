﻿namespace ClassCalculater
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.button1 = new System.Windows.Forms.Button();
            this.calcGradeButton = new System.Windows.Forms.Button();
            this.letterGradeLabel = new System.Windows.Forms.Label();
            this.weightedGradeLabel = new System.Windows.Forms.Label();
            this.letterGrade = new System.Windows.Forms.Label();
            this.weightedGrade = new System.Windows.Forms.Label();
            this.unweightedAverageLabel = new System.Windows.Forms.Label();
            this.unweightedAverage = new System.Windows.Forms.Label();
            this.weightedAveragePartial = new System.Windows.Forms.Label();
            this.weightedAveragePartialLabel = new System.Windows.Forms.Label();
            this.gradeRangeLabel = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.cLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.Label();
            this.aMinLabel = new System.Windows.Forms.Label();
            this.bMinLabel = new System.Windows.Forms.Label();
            this.cMinLabel = new System.Windows.Forms.Label();
            this.dMinLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.aMaxLabel = new System.Windows.Forms.Label();
            this.bMaxLabel = new System.Windows.Forms.Label();
            this.cMaxLabel = new System.Windows.Forms.Label();
            this.dMaxLabel = new System.Windows.Forms.Label();
            this.fPointLabel = new System.Windows.Forms.Label();
            this.weightSumLabel = new System.Windows.Forms.Label();
            this.weightSum = new System.Windows.Forms.Label();
            this.AddBoxesButton = new System.Windows.Forms.Button();
            this.boxesToAdd = new System.Windows.Forms.MaskedTextBox();
            this.removeBoxesButton = new System.Windows.Forms.Button();
            this.lineRemovalInputBox = new System.Windows.Forms.MaskedTextBox();
            this.fileNameLabelHeader = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.generalToolTip = new System.Windows.Forms.ToolTip(this.components);
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
            this.assignmentNameLabel.Location = new System.Drawing.Point(15, 130);
            this.assignmentNameLabel.Name = "assignmentNameLabel";
            this.assignmentNameLabel.Size = new System.Drawing.Size(139, 20);
            this.assignmentNameLabel.TabIndex = 3;
            this.assignmentNameLabel.Text = "Assignment Name";
            this.assignmentNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generalToolTip.SetToolTip(this.assignmentNameLabel, "Input the name of the assingments in this set of boxes");
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(206, 130);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(54, 20);
            this.gradeLabel.TabIndex = 4;
            this.gradeLabel.Text = "Grade";
            this.gradeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generalToolTip.SetToolTip(this.gradeLabel, "Input grades in this set of boxes");
            // 
            // percentOfTotalGradeLabel
            // 
            this.percentOfTotalGradeLabel.AutoSize = true;
            this.percentOfTotalGradeLabel.Location = new System.Drawing.Point(355, 130);
            this.percentOfTotalGradeLabel.Name = "percentOfTotalGradeLabel";
            this.percentOfTotalGradeLabel.Size = new System.Drawing.Size(59, 20);
            this.percentOfTotalGradeLabel.TabIndex = 5;
            this.percentOfTotalGradeLabel.Text = "Weight";
            this.percentOfTotalGradeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generalToolTip.SetToolTip(this.percentOfTotalGradeLabel, resources.GetString("percentOfTotalGradeLabel.ToolTip"));
            // 
            // assignmentNumberInput
            // 
            this.assignmentNumberInput.AsciiOnly = true;
            this.assignmentNumberInput.BeepOnError = true;
            this.assignmentNumberInput.Location = new System.Drawing.Point(210, 25);
            this.assignmentNumberInput.Mask = "00";
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
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFileClick);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveFileClick);
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
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.EditLetterGradeRange);
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
            this.generateFormButton.Size = new System.Drawing.Size(128, 30);
            this.generateFormButton.TabIndex = 7;
            this.generateFormButton.Text = "Generate Form";
            this.generateFormButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generalToolTip.SetToolTip(this.generateFormButton, "Click to generate the indicated number of input boxes");
            this.generateFormButton.UseVisualStyleBackColor = true;
            this.generateFormButton.Click += new System.EventHandler(this.GenerateButtonClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clear Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ClearFormClick);
            // 
            // calcGradeButton
            // 
            this.calcGradeButton.Location = new System.Drawing.Point(600, 120);
            this.calcGradeButton.Name = "calcGradeButton";
            this.calcGradeButton.Size = new System.Drawing.Size(140, 30);
            this.calcGradeButton.TabIndex = 9;
            this.calcGradeButton.Text = "Calculate Grade";
            this.generalToolTip.SetToolTip(this.calcGradeButton, "Once assignment names, grades, and weights have been entered, click this button t" +
        "o calculate the grade");
            this.calcGradeButton.UseVisualStyleBackColor = true;
            this.calcGradeButton.Click += new System.EventHandler(this.CalcGradeButtonClick);
            // 
            // letterGradeLabel
            // 
            this.letterGradeLabel.AutoSize = true;
            this.letterGradeLabel.Location = new System.Drawing.Point(620, 175);
            this.letterGradeLabel.Name = "letterGradeLabel";
            this.letterGradeLabel.Size = new System.Drawing.Size(100, 20);
            this.letterGradeLabel.TabIndex = 10;
            this.letterGradeLabel.Text = "Letter Grade";
            this.generalToolTip.SetToolTip(this.letterGradeLabel, "Your grade represented as a letter, using the table below");
            // 
            // weightedGradeLabel
            // 
            this.weightedGradeLabel.AutoSize = true;
            this.weightedGradeLabel.Location = new System.Drawing.Point(823, 175);
            this.weightedGradeLabel.Name = "weightedGradeLabel";
            this.weightedGradeLabel.Size = new System.Drawing.Size(126, 20);
            this.weightedGradeLabel.TabIndex = 11;
            this.weightedGradeLabel.Text = "Weighted Grade";
            this.generalToolTip.SetToolTip(this.weightedGradeLabel, "Your grade for this class using the weights given. Will only be accurate if the w" +
        "eight sum is equal to 1");
            // 
            // letterGrade
            // 
            this.letterGrade.AutoSize = true;
            this.letterGrade.Location = new System.Drawing.Point(590, 195);
            this.letterGrade.Name = "letterGrade";
            this.letterGrade.Size = new System.Drawing.Size(169, 20);
            this.letterGrade.TabIndex = 12;
            this.letterGrade.Text = "Waiting for Generation";
            // 
            // weightedGrade
            // 
            this.weightedGrade.AutoSize = true;
            this.weightedGrade.Location = new System.Drawing.Point(806, 195);
            this.weightedGrade.Name = "weightedGrade";
            this.weightedGrade.Size = new System.Drawing.Size(169, 20);
            this.weightedGrade.TabIndex = 14;
            this.weightedGrade.Text = "Waiting for Generation";
            // 
            // unweightedAverageLabel
            // 
            this.unweightedAverageLabel.AutoSize = true;
            this.unweightedAverageLabel.Location = new System.Drawing.Point(1083, 175);
            this.unweightedAverageLabel.Name = "unweightedAverageLabel";
            this.unweightedAverageLabel.Size = new System.Drawing.Size(157, 20);
            this.unweightedAverageLabel.TabIndex = 15;
            this.unweightedAverageLabel.Text = "Unweighted Average";
            this.generalToolTip.SetToolTip(this.unweightedAverageLabel, "The flat unweighted average.");
            // 
            // unweightedAverage
            // 
            this.unweightedAverage.AutoSize = true;
            this.unweightedAverage.Location = new System.Drawing.Point(1083, 195);
            this.unweightedAverage.Name = "unweightedAverage";
            this.unweightedAverage.Size = new System.Drawing.Size(169, 20);
            this.unweightedAverage.TabIndex = 16;
            this.unweightedAverage.Text = "Waiting for Generation";
            // 
            // weightedAveragePartial
            // 
            this.weightedAveragePartial.AutoSize = true;
            this.weightedAveragePartial.Location = new System.Drawing.Point(806, 254);
            this.weightedAveragePartial.Name = "weightedAveragePartial";
            this.weightedAveragePartial.Size = new System.Drawing.Size(169, 20);
            this.weightedAveragePartial.TabIndex = 17;
            this.weightedAveragePartial.Text = "Waiting for Generation";
            // 
            // weightedAveragePartialLabel
            // 
            this.weightedAveragePartialLabel.AutoSize = true;
            this.weightedAveragePartialLabel.Location = new System.Drawing.Point(796, 234);
            this.weightedAveragePartialLabel.Name = "weightedAveragePartialLabel";
            this.weightedAveragePartialLabel.Size = new System.Drawing.Size(188, 20);
            this.weightedAveragePartialLabel.TabIndex = 18;
            this.weightedAveragePartialLabel.Text = "Partial Weighted Average";
            this.generalToolTip.SetToolTip(this.weightedAveragePartialLabel, "Your grade for this class using the weights given. Will only be used if the sum o" +
        "f the weights is less than 1\r\n");
            // 
            // gradeRangeLabel
            // 
            this.gradeRangeLabel.AutoSize = true;
            this.gradeRangeLabel.Location = new System.Drawing.Point(596, 340);
            this.gradeRangeLabel.Name = "gradeRangeLabel";
            this.gradeRangeLabel.Size = new System.Drawing.Size(106, 20);
            this.gradeRangeLabel.TabIndex = 19;
            this.gradeRangeLabel.Text = "Grade Range";
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(596, 370);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(20, 20);
            this.aLabel.TabIndex = 20;
            this.aLabel.Text = "A";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(596, 400);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(20, 20);
            this.bLabel.TabIndex = 21;
            this.bLabel.Text = "B";
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Location = new System.Drawing.Point(596, 430);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(20, 20);
            this.cLabel.TabIndex = 22;
            this.cLabel.Text = "C";
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Location = new System.Drawing.Point(596, 460);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(21, 20);
            this.dLabel.TabIndex = 23;
            this.dLabel.Text = "D";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(596, 490);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(19, 20);
            this.Label.TabIndex = 24;
            this.Label.Text = "F";
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Location = new System.Drawing.Point(729, 340);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(34, 20);
            this.min.TabIndex = 25;
            this.min.Text = "Min";
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Location = new System.Drawing.Point(806, 340);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(38, 20);
            this.max.TabIndex = 26;
            this.max.Text = "Max";
            // 
            // aMinLabel
            // 
            this.aMinLabel.AutoSize = true;
            this.aMinLabel.Location = new System.Drawing.Point(729, 370);
            this.aMinLabel.Name = "aMinLabel";
            this.aMinLabel.Size = new System.Drawing.Size(34, 20);
            this.aMinLabel.TabIndex = 27;
            this.aMinLabel.Text = "Min";
            // 
            // bMinLabel
            // 
            this.bMinLabel.AutoSize = true;
            this.bMinLabel.Location = new System.Drawing.Point(729, 400);
            this.bMinLabel.Name = "bMinLabel";
            this.bMinLabel.Size = new System.Drawing.Size(34, 20);
            this.bMinLabel.TabIndex = 28;
            this.bMinLabel.Text = "Min";
            // 
            // cMinLabel
            // 
            this.cMinLabel.AutoSize = true;
            this.cMinLabel.Location = new System.Drawing.Point(729, 430);
            this.cMinLabel.Name = "cMinLabel";
            this.cMinLabel.Size = new System.Drawing.Size(34, 20);
            this.cMinLabel.TabIndex = 29;
            this.cMinLabel.Text = "Min";
            // 
            // dMinLabel
            // 
            this.dMinLabel.AutoSize = true;
            this.dMinLabel.Location = new System.Drawing.Point(729, 460);
            this.dMinLabel.Name = "dMinLabel";
            this.dMinLabel.Size = new System.Drawing.Size(34, 20);
            this.dMinLabel.TabIndex = 30;
            this.dMinLabel.Text = "Min";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(732, 490);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "<=";
            // 
            // aMaxLabel
            // 
            this.aMaxLabel.AutoSize = true;
            this.aMaxLabel.Location = new System.Drawing.Point(806, 370);
            this.aMaxLabel.Name = "aMaxLabel";
            this.aMaxLabel.Size = new System.Drawing.Size(38, 20);
            this.aMaxLabel.TabIndex = 32;
            this.aMaxLabel.Text = "Max";
            // 
            // bMaxLabel
            // 
            this.bMaxLabel.AutoSize = true;
            this.bMaxLabel.Location = new System.Drawing.Point(806, 400);
            this.bMaxLabel.Name = "bMaxLabel";
            this.bMaxLabel.Size = new System.Drawing.Size(38, 20);
            this.bMaxLabel.TabIndex = 33;
            this.bMaxLabel.Text = "Max";
            // 
            // cMaxLabel
            // 
            this.cMaxLabel.AutoSize = true;
            this.cMaxLabel.Location = new System.Drawing.Point(806, 430);
            this.cMaxLabel.Name = "cMaxLabel";
            this.cMaxLabel.Size = new System.Drawing.Size(38, 20);
            this.cMaxLabel.TabIndex = 34;
            this.cMaxLabel.Text = "Max";
            // 
            // dMaxLabel
            // 
            this.dMaxLabel.AutoSize = true;
            this.dMaxLabel.Location = new System.Drawing.Point(806, 460);
            this.dMaxLabel.Name = "dMaxLabel";
            this.dMaxLabel.Size = new System.Drawing.Size(38, 20);
            this.dMaxLabel.TabIndex = 35;
            this.dMaxLabel.Text = "Max";
            // 
            // fPointLabel
            // 
            this.fPointLabel.AutoSize = true;
            this.fPointLabel.Location = new System.Drawing.Point(806, 490);
            this.fPointLabel.Name = "fPointLabel";
            this.fPointLabel.Size = new System.Drawing.Size(38, 20);
            this.fPointLabel.TabIndex = 36;
            this.fPointLabel.Text = "Max";
            // 
            // weightSumLabel
            // 
            this.weightSumLabel.AutoSize = true;
            this.weightSumLabel.Location = new System.Drawing.Point(480, 130);
            this.weightSumLabel.Name = "weightSumLabel";
            this.weightSumLabel.Size = new System.Drawing.Size(93, 20);
            this.weightSumLabel.TabIndex = 37;
            this.weightSumLabel.Text = "Weight sum";
            this.generalToolTip.SetToolTip(this.weightSumLabel, "The sum of the grade weights. Should be either equal to or less than 1");
            // 
            // weightSum
            // 
            this.weightSum.AutoSize = true;
            this.weightSum.Location = new System.Drawing.Point(516, 150);
            this.weightSum.Name = "weightSum";
            this.weightSum.Size = new System.Drawing.Size(18, 20);
            this.weightSum.TabIndex = 38;
            this.weightSum.Text = "0";
            // 
            // AddBoxesButton
            // 
            this.AddBoxesButton.Location = new System.Drawing.Point(260, 71);
            this.AddBoxesButton.Name = "AddBoxesButton";
            this.AddBoxesButton.Size = new System.Drawing.Size(128, 24);
            this.AddBoxesButton.TabIndex = 39;
            this.AddBoxesButton.Text = "Add";
            this.generalToolTip.SetToolTip(this.AddBoxesButton, "Adds the given number of input boxes to the form. Use this after generating the f" +
        "orm");
            this.AddBoxesButton.UseVisualStyleBackColor = true;
            this.AddBoxesButton.Click += new System.EventHandler(this.AddBoxesButton_Click);
            // 
            // boxesToAdd
            // 
            this.boxesToAdd.AsciiOnly = true;
            this.boxesToAdd.BeepOnError = true;
            this.boxesToAdd.Location = new System.Drawing.Point(210, 69);
            this.boxesToAdd.Mask = "00";
            this.boxesToAdd.Name = "boxesToAdd";
            this.boxesToAdd.Size = new System.Drawing.Size(34, 26);
            this.boxesToAdd.TabIndex = 40;
            // 
            // removeBoxesButton
            // 
            this.removeBoxesButton.Location = new System.Drawing.Point(260, 101);
            this.removeBoxesButton.Name = "removeBoxesButton";
            this.removeBoxesButton.Size = new System.Drawing.Size(128, 26);
            this.removeBoxesButton.TabIndex = 41;
            this.removeBoxesButton.Text = "Remove";
            this.generalToolTip.SetToolTip(this.removeBoxesButton, "Removes the given number of input boxes from the form");
            this.removeBoxesButton.UseVisualStyleBackColor = true;
            this.removeBoxesButton.Click += new System.EventHandler(this.RemoveLines);
            // 
            // lineRemovalInputBox
            // 
            this.lineRemovalInputBox.AsciiOnly = true;
            this.lineRemovalInputBox.BeepOnError = true;
            this.lineRemovalInputBox.Location = new System.Drawing.Point(210, 101);
            this.lineRemovalInputBox.Mask = "00";
            this.lineRemovalInputBox.Name = "lineRemovalInputBox";
            this.lineRemovalInputBox.Size = new System.Drawing.Size(34, 26);
            this.lineRemovalInputBox.TabIndex = 43;
            // 
            // fileNameLabelHeader
            // 
            this.fileNameLabelHeader.AutoSize = true;
            this.fileNameLabelHeader.Location = new System.Drawing.Point(569, 31);
            this.fileNameLabelHeader.Name = "fileNameLabelHeader";
            this.fileNameLabelHeader.Size = new System.Drawing.Size(86, 20);
            this.fileNameLabelHeader.TabIndex = 44;
            this.fileNameLabelHeader.Text = "Editing file:";
            this.generalToolTip.SetToolTip(this.fileNameLabelHeader, "The current file open for editing");
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(669, 31);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(53, 20);
            this.fileNameLabel.TabIndex = 45;
            this.fileNameLabel.Text = "No file";
            // 
            // generalToolTip
            // 
            this.generalToolTip.AutomaticDelay = 250;
            this.generalToolTip.AutoPopDelay = 5000000;
            this.generalToolTip.InitialDelay = 250;
            this.generalToolTip.ReshowDelay = 50;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.fileNameLabelHeader);
            this.Controls.Add(this.lineRemovalInputBox);
            this.Controls.Add(this.removeBoxesButton);
            this.Controls.Add(this.boxesToAdd);
            this.Controls.Add(this.AddBoxesButton);
            this.Controls.Add(this.weightSum);
            this.Controls.Add(this.weightSumLabel);
            this.Controls.Add(this.fPointLabel);
            this.Controls.Add(this.dMaxLabel);
            this.Controls.Add(this.cMaxLabel);
            this.Controls.Add(this.bMaxLabel);
            this.Controls.Add(this.aMaxLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dMinLabel);
            this.Controls.Add(this.cMinLabel);
            this.Controls.Add(this.bMinLabel);
            this.Controls.Add(this.aMinLabel);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.cLabel);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.gradeRangeLabel);
            this.Controls.Add(this.weightedAveragePartialLabel);
            this.Controls.Add(this.weightedAveragePartial);
            this.Controls.Add(this.unweightedAverage);
            this.Controls.Add(this.unweightedAverageLabel);
            this.Controls.Add(this.weightedGrade);
            this.Controls.Add(this.letterGrade);
            this.Controls.Add(this.weightedGradeLabel);
            this.Controls.Add(this.letterGradeLabel);
            this.Controls.Add(this.calcGradeButton);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button calcGradeButton;
        private System.Windows.Forms.Label letterGradeLabel;
        private System.Windows.Forms.Label weightedGradeLabel;
        private System.Windows.Forms.Label letterGrade;
        private System.Windows.Forms.Label weightedGrade;
        private System.Windows.Forms.Label unweightedAverageLabel;
        private System.Windows.Forms.Label unweightedAverage;
        private System.Windows.Forms.Label weightedAveragePartial;
        private System.Windows.Forms.Label weightedAveragePartialLabel;
        private System.Windows.Forms.Label gradeRangeLabel;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.Label aMinLabel;
        private System.Windows.Forms.Label bMinLabel;
        private System.Windows.Forms.Label cMinLabel;
        private System.Windows.Forms.Label dMinLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label aMaxLabel;
        private System.Windows.Forms.Label bMaxLabel;
        private System.Windows.Forms.Label cMaxLabel;
        private System.Windows.Forms.Label dMaxLabel;
        private System.Windows.Forms.Label fPointLabel;
        private System.Windows.Forms.Label weightSumLabel;
        private System.Windows.Forms.Label weightSum;
        private System.Windows.Forms.Button AddBoxesButton;
        private System.Windows.Forms.MaskedTextBox boxesToAdd;
        private System.Windows.Forms.Button removeBoxesButton;
        private System.Windows.Forms.MaskedTextBox lineRemovalInputBox;
        private System.Windows.Forms.Label fileNameLabelHeader;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.ToolTip generalToolTip;
    }
}


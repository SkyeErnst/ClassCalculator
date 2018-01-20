namespace ClassCalculater
{
    partial class LetterGradeRangeEditForm
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
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.aLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.cLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.aMinBox = new System.Windows.Forms.MaskedTextBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.bMinBox = new System.Windows.Forms.MaskedTextBox();
            this.cMinBox = new System.Windows.Forms.MaskedTextBox();
            this.dMinBox = new System.Windows.Forms.MaskedTextBox();
            this.fInfoLabel = new System.Windows.Forms.Label();
            this.aMaxLabel = new System.Windows.Forms.Label();
            this.bMaxLabel = new System.Windows.Forms.Label();
            this.cMaxLabel = new System.Windows.Forms.Label();
            this.dMaxLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(612, 526);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(75, 23);
            this.saveChangesButton.TabIndex = 0;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(697, 526);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(40, 70);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(14, 13);
            this.aLabel.TabIndex = 2;
            this.aLabel.Text = "A";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(40, 100);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(14, 13);
            this.bLabel.TabIndex = 3;
            this.bLabel.Text = "B";
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Location = new System.Drawing.Point(40, 130);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(14, 13);
            this.cLabel.TabIndex = 4;
            this.cLabel.Text = "C";
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Location = new System.Drawing.Point(40, 160);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(15, 13);
            this.dLabel.TabIndex = 5;
            this.dLabel.Text = "D";
            // 
            // aMinBox
            // 
            this.aMinBox.Location = new System.Drawing.Point(110, 62);
            this.aMinBox.Mask = "00";
            this.aMinBox.Name = "aMinBox";
            this.aMinBox.Size = new System.Drawing.Size(27, 20);
            this.aMinBox.TabIndex = 7;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(178, 36);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(27, 13);
            this.maxLabel.TabIndex = 8;
            this.maxLabel.Text = "Max";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(107, 36);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(24, 13);
            this.minLabel.TabIndex = 9;
            this.minLabel.Text = "Min";
            // 
            // bMinBox
            // 
            this.bMinBox.Location = new System.Drawing.Point(110, 93);
            this.bMinBox.Mask = "00";
            this.bMinBox.Name = "bMinBox";
            this.bMinBox.Size = new System.Drawing.Size(27, 20);
            this.bMinBox.TabIndex = 11;
            this.bMinBox.Leave += new System.EventHandler(this.BMinBox_Leave);
            // 
            // cMinBox
            // 
            this.cMinBox.Location = new System.Drawing.Point(110, 123);
            this.cMinBox.Mask = "00";
            this.cMinBox.Name = "cMinBox";
            this.cMinBox.Size = new System.Drawing.Size(27, 20);
            this.cMinBox.TabIndex = 13;
            this.cMinBox.Leave += new System.EventHandler(this.CMinBox_Leave);
            // 
            // dMinBox
            // 
            this.dMinBox.Location = new System.Drawing.Point(110, 157);
            this.dMinBox.Mask = "00";
            this.dMinBox.Name = "dMinBox";
            this.dMinBox.Size = new System.Drawing.Size(27, 20);
            this.dMinBox.TabIndex = 15;
            this.dMinBox.Leave += new System.EventHandler(this.DMinBox_Leave);
            // 
            // fInfoLabel
            // 
            this.fInfoLabel.AutoSize = true;
            this.fInfoLabel.Location = new System.Drawing.Point(40, 201);
            this.fInfoLabel.Name = "fInfoLabel";
            this.fInfoLabel.Size = new System.Drawing.Size(323, 13);
            this.fInfoLabel.TabIndex = 17;
            this.fInfoLabel.Text = "The threshold for the grade F is equal to the minimum value of D - 1";
            // 
            // aMaxLabel
            // 
            this.aMaxLabel.AutoSize = true;
            this.aMaxLabel.Location = new System.Drawing.Point(174, 69);
            this.aMaxLabel.Name = "aMaxLabel";
            this.aMaxLabel.Size = new System.Drawing.Size(25, 13);
            this.aMaxLabel.TabIndex = 18;
            this.aMaxLabel.Text = "100";
            // 
            // bMaxLabel
            // 
            this.bMaxLabel.AutoSize = true;
            this.bMaxLabel.Location = new System.Drawing.Point(174, 100);
            this.bMaxLabel.Name = "bMaxLabel";
            this.bMaxLabel.Size = new System.Drawing.Size(43, 13);
            this.bMaxLabel.TabIndex = 19;
            this.bMaxLabel.Text = "Waiting";
            // 
            // cMaxLabel
            // 
            this.cMaxLabel.AutoSize = true;
            this.cMaxLabel.Location = new System.Drawing.Point(174, 130);
            this.cMaxLabel.Name = "cMaxLabel";
            this.cMaxLabel.Size = new System.Drawing.Size(43, 13);
            this.cMaxLabel.TabIndex = 20;
            this.cMaxLabel.Text = "Waiting";
            // 
            // dMaxLabel
            // 
            this.dMaxLabel.AutoSize = true;
            this.dMaxLabel.Location = new System.Drawing.Point(174, 164);
            this.dMaxLabel.Name = "dMaxLabel";
            this.dMaxLabel.Size = new System.Drawing.Size(43, 13);
            this.dMaxLabel.TabIndex = 21;
            this.dMaxLabel.Text = "Waiting";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(489, 96);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(253, 26);
            this.infoLabel.TabIndex = 22;
            this.infoLabel.Text = "Enter the grade ranges that you would like, starting\r\nwith the minimum for A, and" +
    " working your way down.\r\n";
            // 
            // LetterGradeRangeEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.dMaxLabel);
            this.Controls.Add(this.cMaxLabel);
            this.Controls.Add(this.bMaxLabel);
            this.Controls.Add(this.aMaxLabel);
            this.Controls.Add(this.fInfoLabel);
            this.Controls.Add(this.dMinBox);
            this.Controls.Add(this.cMinBox);
            this.Controls.Add(this.bMinBox);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.aMinBox);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.cLabel);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveChangesButton);
            this.Name = "LetterGradeRangeEditForm";
            this.Text = "Edit Letter Grade Range";
            this.Load += new System.EventHandler(this.LetterGradeRangeEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.MaskedTextBox aMinBox;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.MaskedTextBox bMinBox;
        private System.Windows.Forms.MaskedTextBox cMinBox;
        private System.Windows.Forms.MaskedTextBox dMinBox;
        private System.Windows.Forms.Label fInfoLabel;
        private System.Windows.Forms.Label aMaxLabel;
        private System.Windows.Forms.Label bMaxLabel;
        private System.Windows.Forms.Label cMaxLabel;
        private System.Windows.Forms.Label dMaxLabel;
        private System.Windows.Forms.Label infoLabel;
    }
}
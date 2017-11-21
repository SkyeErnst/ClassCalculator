namespace ClassCalculater
{
    partial class InputControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.assignmentNameBox = new System.Windows.Forms.TextBox();
            this.gradeBox = new System.Windows.Forms.TextBox();
            this.percentBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // assignmentNameBox
            // 
            this.assignmentNameBox.Location = new System.Drawing.Point(0, 2);
            this.assignmentNameBox.Name = "assignmentNameBox";
            this.assignmentNameBox.Size = new System.Drawing.Size(100, 20);
            this.assignmentNameBox.TabIndex = 0;
            // 
            // gradeBox
            // 
            this.gradeBox.Location = new System.Drawing.Point(164, 2);
            this.gradeBox.Name = "gradeBox";
            this.gradeBox.Size = new System.Drawing.Size(100, 20);
            this.gradeBox.TabIndex = 1;
            // 
            // percentBox
            // 
            this.percentBox.Location = new System.Drawing.Point(300, 2);
            this.percentBox.Name = "percentBox";
            this.percentBox.Size = new System.Drawing.Size(100, 20);
            this.percentBox.TabIndex = 2;
            // 
            // InputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.percentBox);
            this.Controls.Add(this.gradeBox);
            this.Controls.Add(this.assignmentNameBox);
            this.Name = "InputControl";
            this.Size = new System.Drawing.Size(420, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox assignmentNameBox;
        private System.Windows.Forms.TextBox gradeBox;
        private System.Windows.Forms.TextBox percentBox;
    }
}

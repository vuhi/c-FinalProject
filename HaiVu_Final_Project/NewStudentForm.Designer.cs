namespace HaiVu_Final_Project
{
    partial class NewStudentForm
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
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.studentScoreLabel = new System.Windows.Forms.Label();
            this.studentScoresLabel = new System.Windows.Forms.Label();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.studentScoreTextBox = new System.Windows.Forms.TextBox();
            this.studentScoresTextBox = new System.Windows.Forms.TextBox();
            this.addScoreButton = new System.Windows.Forms.Button();
            this.clearScoreButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveStudentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameLabel.Location = new System.Drawing.Point(35, 22);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(48, 16);
            this.studentNameLabel.TabIndex = 0;
            this.studentNameLabel.Text = "Name:";
            // 
            // studentScoreLabel
            // 
            this.studentScoreLabel.AutoSize = true;
            this.studentScoreLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentScoreLabel.Location = new System.Drawing.Point(35, 57);
            this.studentScoreLabel.Name = "studentScoreLabel";
            this.studentScoreLabel.Size = new System.Drawing.Size(56, 16);
            this.studentScoreLabel.TabIndex = 0;
            this.studentScoreLabel.Text = "Score:";
            // 
            // studentScoresLabel
            // 
            this.studentScoresLabel.AutoSize = true;
            this.studentScoresLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentScoresLabel.Location = new System.Drawing.Point(35, 98);
            this.studentScoresLabel.Name = "studentScoresLabel";
            this.studentScoresLabel.Size = new System.Drawing.Size(64, 16);
            this.studentScoresLabel.TabIndex = 0;
            this.studentScoresLabel.Text = "Scores:";
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameTextBox.Location = new System.Drawing.Point(121, 15);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(279, 23);
            this.studentNameTextBox.TabIndex = 1;
            this.studentNameTextBox.Tag = "Student Name";
            // 
            // studentScoreTextBox
            // 
            this.studentScoreTextBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentScoreTextBox.Location = new System.Drawing.Point(121, 50);
            this.studentScoreTextBox.Name = "studentScoreTextBox";
            this.studentScoreTextBox.Size = new System.Drawing.Size(134, 23);
            this.studentScoreTextBox.TabIndex = 1;
            this.studentScoreTextBox.Tag = "Student Score";
            // 
            // studentScoresTextBox
            // 
            this.studentScoresTextBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentScoresTextBox.Location = new System.Drawing.Point(121, 91);
            this.studentScoresTextBox.Name = "studentScoresTextBox";
            this.studentScoresTextBox.ReadOnly = true;
            this.studentScoresTextBox.Size = new System.Drawing.Size(279, 23);
            this.studentScoresTextBox.TabIndex = 1;
            // 
            // addScoreButton
            // 
            this.addScoreButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addScoreButton.Location = new System.Drawing.Point(283, 47);
            this.addScoreButton.Name = "addScoreButton";
            this.addScoreButton.Size = new System.Drawing.Size(117, 30);
            this.addScoreButton.TabIndex = 2;
            this.addScoreButton.Text = "Add Score";
            this.addScoreButton.UseVisualStyleBackColor = true;
            this.addScoreButton.Click += new System.EventHandler(this.addScoreButton_Click);
            // 
            // clearScoreButton
            // 
            this.clearScoreButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearScoreButton.Location = new System.Drawing.Point(283, 133);
            this.clearScoreButton.Name = "clearScoreButton";
            this.clearScoreButton.Size = new System.Drawing.Size(117, 30);
            this.clearScoreButton.TabIndex = 2;
            this.clearScoreButton.Text = "Clear Score";
            this.clearScoreButton.UseVisualStyleBackColor = true;
            this.clearScoreButton.Click += new System.EventHandler(this.clearScoreButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(283, 181);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(117, 30);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveStudentButton
            // 
            this.saveStudentButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveStudentButton.Location = new System.Drawing.Point(138, 181);
            this.saveStudentButton.Name = "saveStudentButton";
            this.saveStudentButton.Size = new System.Drawing.Size(117, 30);
            this.saveStudentButton.TabIndex = 2;
            this.saveStudentButton.Text = "OK";
            this.saveStudentButton.UseVisualStyleBackColor = true;
            this.saveStudentButton.Click += new System.EventHandler(this.saveStudentButton_Click);
            // 
            // NewStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 231);
            this.Controls.Add(this.saveStudentButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.clearScoreButton);
            this.Controls.Add(this.addScoreButton);
            this.Controls.Add(this.studentScoresTextBox);
            this.Controls.Add(this.studentScoreTextBox);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.studentScoresLabel);
            this.Controls.Add(this.studentScoreLabel);
            this.Controls.Add(this.studentNameLabel);
            this.Name = "NewStudentForm";
            this.Text = "Add New Student";
            this.Load += new System.EventHandler(this.NewStudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Label studentScoreLabel;
        private System.Windows.Forms.Label studentScoresLabel;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.TextBox studentScoreTextBox;
        private System.Windows.Forms.TextBox studentScoresTextBox;
        private System.Windows.Forms.Button addScoreButton;
        private System.Windows.Forms.Button clearScoreButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveStudentButton;
    }
}
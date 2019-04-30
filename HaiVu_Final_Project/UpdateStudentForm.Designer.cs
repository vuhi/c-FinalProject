namespace HaiVu_Final_Project
{
    partial class UpdateStudentForm
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
            this.updatedStudentNameLabel = new System.Windows.Forms.Label();
            this.updatedStudentScoresLabel = new System.Windows.Forms.Label();
            this.updatedStudentNameTextBox = new System.Windows.Forms.TextBox();
            this.updatedStudentScoresListBox = new System.Windows.Forms.ListBox();
            this.addNewScoreButton = new System.Windows.Forms.Button();
            this.updateScoreButton = new System.Windows.Forms.Button();
            this.removeScoreButton = new System.Windows.Forms.Button();
            this.clearScoresButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateStudentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updatedStudentNameLabel
            // 
            this.updatedStudentNameLabel.AutoSize = true;
            this.updatedStudentNameLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedStudentNameLabel.Location = new System.Drawing.Point(31, 28);
            this.updatedStudentNameLabel.Name = "updatedStudentNameLabel";
            this.updatedStudentNameLabel.Size = new System.Drawing.Size(56, 16);
            this.updatedStudentNameLabel.TabIndex = 0;
            this.updatedStudentNameLabel.Text = "Name: ";
            // 
            // updatedStudentScoresLabel
            // 
            this.updatedStudentScoresLabel.AutoSize = true;
            this.updatedStudentScoresLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedStudentScoresLabel.Location = new System.Drawing.Point(31, 65);
            this.updatedStudentScoresLabel.Name = "updatedStudentScoresLabel";
            this.updatedStudentScoresLabel.Size = new System.Drawing.Size(64, 16);
            this.updatedStudentScoresLabel.TabIndex = 0;
            this.updatedStudentScoresLabel.Text = "Scores:";
            // 
            // updatedStudentNameTextBox
            // 
            this.updatedStudentNameTextBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedStudentNameTextBox.Location = new System.Drawing.Point(120, 25);
            this.updatedStudentNameTextBox.Name = "updatedStudentNameTextBox";
            this.updatedStudentNameTextBox.ReadOnly = true;
            this.updatedStudentNameTextBox.Size = new System.Drawing.Size(288, 23);
            this.updatedStudentNameTextBox.TabIndex = 1;
            // 
            // updatedStudentScoresLisBox
            // 
            this.updatedStudentScoresListBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedStudentScoresListBox.FormattingEnabled = true;
            this.updatedStudentScoresListBox.ItemHeight = 15;
            this.updatedStudentScoresListBox.Location = new System.Drawing.Point(120, 65);
            this.updatedStudentScoresListBox.Name = "updatedStudentScoresLisBox";
            this.updatedStudentScoresListBox.Size = new System.Drawing.Size(136, 139);
            this.updatedStudentScoresListBox.TabIndex = 2;
            // 
            // addNewScoreButton
            // 
            this.addNewScoreButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewScoreButton.Location = new System.Drawing.Point(291, 65);
            this.addNewScoreButton.Name = "addNewScoreButton";
            this.addNewScoreButton.Size = new System.Drawing.Size(117, 30);
            this.addNewScoreButton.TabIndex = 3;
            this.addNewScoreButton.Text = "Add";
            this.addNewScoreButton.UseVisualStyleBackColor = true;
            this.addNewScoreButton.Click += new System.EventHandler(this.addNewScoreButton_Click);
            // 
            // updateScoreButton
            // 
            this.updateScoreButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateScoreButton.Location = new System.Drawing.Point(291, 101);
            this.updateScoreButton.Name = "updateScoreButton";
            this.updateScoreButton.Size = new System.Drawing.Size(117, 30);
            this.updateScoreButton.TabIndex = 3;
            this.updateScoreButton.Text = "Update";
            this.updateScoreButton.UseVisualStyleBackColor = true;
            this.updateScoreButton.Click += new System.EventHandler(this.updateScoreButton_Click);
            // 
            // removeScoreButton
            // 
            this.removeScoreButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeScoreButton.Location = new System.Drawing.Point(291, 137);
            this.removeScoreButton.Name = "removeScoreButton";
            this.removeScoreButton.Size = new System.Drawing.Size(117, 30);
            this.removeScoreButton.TabIndex = 3;
            this.removeScoreButton.Text = "Remove";
            this.removeScoreButton.UseVisualStyleBackColor = true;
            this.removeScoreButton.Click += new System.EventHandler(this.removeScoreButton_Click);
            // 
            // clearScoresButton
            // 
            this.clearScoresButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearScoresButton.Location = new System.Drawing.Point(291, 174);
            this.clearScoresButton.Name = "clearScoresButton";
            this.clearScoresButton.Size = new System.Drawing.Size(117, 30);
            this.clearScoresButton.TabIndex = 3;
            this.clearScoresButton.Text = "Clear Scores";
            this.clearScoresButton.UseVisualStyleBackColor = true;
            this.clearScoresButton.Click += new System.EventHandler(this.clearScoresButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(291, 232);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(117, 30);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // updateStudentButton
            // 
            this.updateStudentButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStudentButton.Location = new System.Drawing.Point(139, 232);
            this.updateStudentButton.Name = "updateStudentButton";
            this.updateStudentButton.Size = new System.Drawing.Size(117, 30);
            this.updateStudentButton.TabIndex = 3;
            this.updateStudentButton.Text = "OK";
            this.updateStudentButton.UseVisualStyleBackColor = true;
            this.updateStudentButton.Click += new System.EventHandler(this.updateStudentButton_Click);
            // 
            // UpdateStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 274);
            this.Controls.Add(this.updateStudentButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.clearScoresButton);
            this.Controls.Add(this.removeScoreButton);
            this.Controls.Add(this.updateScoreButton);
            this.Controls.Add(this.addNewScoreButton);
            this.Controls.Add(this.updatedStudentScoresListBox);
            this.Controls.Add(this.updatedStudentNameTextBox);
            this.Controls.Add(this.updatedStudentScoresLabel);
            this.Controls.Add(this.updatedStudentNameLabel);
            this.Name = "UpdateStudentForm";
            this.Text = "Update Student Scores";
            this.Load += new System.EventHandler(this.UpdateStudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label updatedStudentNameLabel;
        private System.Windows.Forms.Label updatedStudentScoresLabel;
        private System.Windows.Forms.TextBox updatedStudentNameTextBox;
        private System.Windows.Forms.ListBox updatedStudentScoresListBox;
        private System.Windows.Forms.Button addNewScoreButton;
        private System.Windows.Forms.Button updateScoreButton;
        private System.Windows.Forms.Button removeScoreButton;
        private System.Windows.Forms.Button clearScoresButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updateStudentButton;
    }
}
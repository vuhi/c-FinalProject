namespace HaiVu_Final_Project
{
    partial class StudentScoreForm
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
            this.studentLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.totalScoreLabel = new System.Windows.Forms.Label();
            this.countScoreLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.totalScoreTextBox = new System.Windows.Forms.TextBox();
            this.countScoreTextBox = new System.Windows.Forms.TextBox();
            this.averageTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.studentListView = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentLabel.Location = new System.Drawing.Point(37, 24);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(72, 16);
            this.studentLabel.TabIndex = 0;
            this.studentLabel.Text = "Students";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(566, 53);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(185, 36);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add New ...";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(566, 104);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(185, 36);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update ...";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(566, 156);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(185, 36);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // totalScoreLabel
            // 
            this.totalScoreLabel.AutoSize = true;
            this.totalScoreLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalScoreLabel.Location = new System.Drawing.Point(276, 223);
            this.totalScoreLabel.Name = "totalScoreLabel";
            this.totalScoreLabel.Size = new System.Drawing.Size(104, 16);
            this.totalScoreLabel.TabIndex = 4;
            this.totalScoreLabel.Text = "Score Total:";
            // 
            // countScoreLabel
            // 
            this.countScoreLabel.AutoSize = true;
            this.countScoreLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countScoreLabel.Location = new System.Drawing.Point(276, 256);
            this.countScoreLabel.Name = "countScoreLabel";
            this.countScoreLabel.Size = new System.Drawing.Size(104, 16);
            this.countScoreLabel.TabIndex = 4;
            this.countScoreLabel.Text = "Score Count:";
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageLabel.Location = new System.Drawing.Point(276, 288);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(72, 16);
            this.averageLabel.TabIndex = 4;
            this.averageLabel.Text = "Average:";
            // 
            // totalScoreTextBox
            // 
            this.totalScoreTextBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalScoreTextBox.Location = new System.Drawing.Point(417, 216);
            this.totalScoreTextBox.Name = "totalScoreTextBox";
            this.totalScoreTextBox.ReadOnly = true;
            this.totalScoreTextBox.Size = new System.Drawing.Size(125, 23);
            this.totalScoreTextBox.TabIndex = 5;
            // 
            // countScoreTextBox
            // 
            this.countScoreTextBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countScoreTextBox.Location = new System.Drawing.Point(417, 249);
            this.countScoreTextBox.Name = "countScoreTextBox";
            this.countScoreTextBox.ReadOnly = true;
            this.countScoreTextBox.Size = new System.Drawing.Size(125, 23);
            this.countScoreTextBox.TabIndex = 5;
            // 
            // averageTextBox
            // 
            this.averageTextBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageTextBox.Location = new System.Drawing.Point(417, 281);
            this.averageTextBox.Name = "averageTextBox";
            this.averageTextBox.ReadOnly = true;
            this.averageTextBox.Size = new System.Drawing.Size(125, 23);
            this.averageTextBox.TabIndex = 5;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(566, 268);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(185, 36);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // studentListView
            // 
            this.studentListView.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentListView.FormattingEnabled = true;
            this.studentListView.ItemHeight = 15;
            this.studentListView.Location = new System.Drawing.Point(40, 53);
            this.studentListView.Name = "studentListView";
            this.studentListView.Size = new System.Drawing.Size(502, 124);
            this.studentListView.TabIndex = 6;
            // 
            // StudentScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 327);
            this.Controls.Add(this.studentListView);
            this.Controls.Add(this.averageTextBox);
            this.Controls.Add(this.countScoreTextBox);
            this.Controls.Add(this.totalScoreTextBox);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.countScoreLabel);
            this.Controls.Add(this.totalScoreLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.studentLabel);
            this.Name = "StudentScoreForm";
            this.Text = "Student Scores";
            this.Load += new System.EventHandler(this.StudentScoreForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label totalScoreLabel;
        private System.Windows.Forms.Label countScoreLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.TextBox totalScoreTextBox;
        private System.Windows.Forms.TextBox countScoreTextBox;
        private System.Windows.Forms.TextBox averageTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox studentListView;
    }
}


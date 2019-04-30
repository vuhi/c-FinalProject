using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaiVu_Final_Project
{
    public partial class NewStudentForm : Form
    {
        public Student newStudent { get; set; }
        public NewStudentForm()
        {
            InitializeComponent();
        }

        private void NewStudentForm_Load(object sender, EventArgs e)
        {
            newStudent = new Student();
            this.studentNameTextBox.Focus();
        }

        private void addScoreButton_Click(object sender, EventArgs e)
        {
            if (this.studentScoreTextBox.IsInt32() && this.studentScoreTextBox.IsPresent() && this.studentScoreTextBox.IsWithinRange(0, 100))
            {
                this.newStudent.Scores.Add(Convert.ToInt32(this.studentScoreTextBox.Text));
                this.studentScoreTextBox.ResetText();
                this.studentScoreTextBox.Focus();
                this.studentScoresTextBox.Text = string.Join(" ", this.newStudent.Scores);
            }
        }

        private void clearScoreButton_Click(object sender, EventArgs e)
        {
            this.newStudent.Scores.Clear();
            this.studentScoresTextBox.ResetText();
        }

        private void saveStudentButton_Click(object sender, EventArgs e)
        {
            if (this.studentNameTextBox.IsPresent())
            {
                this.newStudent.Name = this.studentNameTextBox.Text;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}

using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HaiVu_Final_Project
{
    public partial class UpdateStudentForm : Form
    {
        public Student updatedStudent;
        public UpdateStudentForm()
        {
            InitializeComponent();
        }

        private void UpdateStudentForm_Load(object sender, EventArgs e)
        {
            this.updatedStudentNameTextBox.Text = this.updatedStudent.Name;
            this.updatedStudent.Scores.ForEach(score => {
                this.updatedStudentScoresListBox.Items.Add(score);
            });
        }

        private void addNewScoreButton_Click(object sender, EventArgs e)
        {
            ScoreForm addScoreForm = new ScoreForm("Add Score");
            DialogResult result = addScoreForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                //this.updatedStudent.Scores.Add(addScoreForm.score);
                this.updatedStudentScoresListBox.Items.Add(addScoreForm.score);
            }
        }

        private void updateScoreButton_Click(object sender, EventArgs e)
        {
            if (this.updatedStudentScoresListBox.SelectedIndex >= 0)
            {
                ScoreForm updateScoreForm = new ScoreForm("Update Score");
                updateScoreForm.score = Convert.ToInt32(this.updatedStudentScoresListBox.SelectedItem.ToString());
                DialogResult result = updateScoreForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //this.updatedStudent.Scores[this.updatedStudentScoresListBox.SelectedIndex] = updateScoreForm.score;
                    this.updatedStudentScoresListBox.Items[this.updatedStudentScoresListBox.SelectedIndex] = updateScoreForm.score;
                }
            }
            else
            {
                MessageBox.Show("Please select a student's score");
            }
           
        }

        private void removeScoreButton_Click(object sender, EventArgs e)
        {
            if (this.updatedStudentScoresListBox.SelectedIndex >= 0)
            {
                //this.updatedStudent.Scores.RemoveAt(this.updatedStudentScoresListBox.SelectedIndex);
                this.updatedStudentScoresListBox.Items.RemoveAt(this.updatedStudentScoresListBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a student's score");
            }
        }

        private void clearScoresButton_Click(object sender, EventArgs e)
        {
            //this.updatedStudent.Scores.Clear();
            this.updatedStudentScoresListBox.Items.Clear();
        }    

        private void updateStudentButton_Click(object sender, EventArgs e)
        {
            // For some reason deep copy was not work. I had to use the ListBox as a temporary storage rather than cloning new Student object. 
            this.updatedStudent.Scores = this.updatedStudentScoresListBox.Items.Cast<int>().ToList();
            this.DialogResult = DialogResult.OK;        
        }
    }
}

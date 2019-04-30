using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HaiVu_Final_Project
{
    public partial class StudentScoreForm : Form
    {
        private List<Student> students = new List<Student>();

        public StudentScoreForm()
        {
            InitializeComponent();
        }

        private void StudentScoreForm_Load(object sender, EventArgs e)
        {
            this.ReadData();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            NewStudentForm newStudentForm = new NewStudentForm();
            DialogResult result = newStudentForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                students.Add(newStudentForm.newStudent);
                this.studentListBox.Items.Add(newStudentForm.newStudent.ToString());
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (this.studentListBox.SelectedIndex >= 0)
            {
                UpdateStudentForm updateStudentForm = new UpdateStudentForm();
                updateStudentForm.updatedStudent = this.students[this.studentListBox.SelectedIndex].Clone() as Student;
                DialogResult result = updateStudentForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.students[this.studentListBox.SelectedIndex] = updateStudentForm.updatedStudent;
                    this.studentListBox.Items[this.studentListBox.SelectedIndex] = updateStudentForm.updatedStudent.ToString();
                }
            } 
            else
            {
                MessageBox.Show("Please select a student");
            }         
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (this.studentListBox.SelectedIndex >= 0)
            {
                this.students.RemoveAt(this.studentListBox.SelectedIndex);
                this.studentListBox.Items.RemoveAt(this.studentListBox.SelectedIndex);                                    
            }
            else
            {
                MessageBox.Show("Please select a student");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void studentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.totalScoreTextBox.Text = this.GetTotalScore();
            this.countScoreTextBox.Text = this.GetTotalCount();
            this.averageTextBox.Text = this.GetAverage();
        }

        private string GetTotalScore()
        {
            if (this.studentListBox.SelectedIndex >= 0)
            {
                return this.students[this.studentListBox.SelectedIndex].Scores.Sum().ToString();
            }
            return "";
        }

        private string GetTotalCount()
        {
            if (this.studentListBox.SelectedIndex >= 0)
            {
                return this.students[this.studentListBox.SelectedIndex].Scores.Count.ToString();
            }
            return "";
        }

        private string GetAverage()
        {
            if (this.studentListBox.SelectedIndex >= 0)
            {
                if (this.students[this.studentListBox.SelectedIndex].Scores.Count > 0)
                    return Math.Round(this.students[this.studentListBox.SelectedIndex].Scores.Average()).ToString();
                return "0";
            }
            return "";
        }

        private void ReadData()
        {
            this.students.Add(new Student("Joel Murach", new List<int> { 97, 71, 83 }));
            this.students.Add(new Student("Doug Lowe", new List<int> { 99, 93, 97 }));
            this.students.Add(new Student("Anne Boehm", new List<int> { 100, 100, 100 }));
            this.students.Add(new Student("Test Test", new List<int> {  }));
            this.students.ForEach(student => {
                this.studentListBox.Items.Add(student.ToString());
            });                  
        }
    }
}

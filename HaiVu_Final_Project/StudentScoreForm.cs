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
    public partial class StudentScoreForm : Form
    {
        private List<Student> students = new List<Student>();
        public StudentScoreForm()
        {
            InitializeComponent();
        }

        private void StudentScoreForm_Load(object sender, EventArgs e)
        {
            this.readData();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void studentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.totalScoreTextBox.Text = this.getTotalScore();
            this.countScoreTextBox.Text = this.getTotalCount();
            this.averageTextBox.Text = this.getAverage();
        }

        private string getTotalScore()
        {
            if (this.studentListBox.SelectedIndex >= 0)
            {
                return this.students[this.studentListBox.SelectedIndex].Scores.Sum().ToString();
            }
            return "";
        }

        private string getTotalCount()
        {
            if (this.studentListBox.SelectedIndex >= 0)
            {
                return this.students[this.studentListBox.SelectedIndex].Scores.Length.ToString();
            }
            return "";
        }

        private string getAverage()
        {
            if (this.studentListBox.SelectedIndex >= 0)
            {
                if (this.students[this.studentListBox.SelectedIndex].Scores.Length > 0)
                    return Math.Round(this.students[this.studentListBox.SelectedIndex].Scores.Average()).ToString();
                return "0";
            }
            return "";
        }

        private void readData()
        {
            this.students.Add(new Student("Joel Murach", new int[] { 97, 71, 83 }));
            this.students.Add(new Student("Doug Lowe", new int[] { 99, 93, 97 }));
            this.students.Add(new Student("Anne Boehm", new int[] { 100, 100, 100 }));
            this.students.Add(new Student("Test Test", new int[] {  }));
            this.students.ForEach(student => {
                this.studentListBox.Items.Add(student.ToString());
            });                  
        }
    }
}

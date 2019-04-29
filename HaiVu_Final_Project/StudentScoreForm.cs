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
        public StudentScoreForm()
        {
            InitializeComponent();
        }

        private void StudentScoreForm_Load(object sender, EventArgs e)
        {
            this.studentListView.Items.Add(new Student("Joel Murach", new int[] { 97, 71, 83 }).ToString());
            this.studentListView.Items.Add(new Student("Doug Lowe", new int[] { 99, 93, 97 }).ToString());
            this.studentListView.Items.Add(new Student("Anne Boehm", new int[] { 100, 100, 100 }).ToString());
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

        }

        private int getTotalScore()
        {
            return 0;
        }

    
    }
}

using System;
using System.Windows.Forms;

namespace HaiVu_Final_Project
{
    public partial class ScoreForm : Form
    {
        public int score { get; set; }
        private bool isUpdate = false;

        public ScoreForm(string title)
        {
            InitializeComponent();
            this.Text = title;
            if (title.ToLower().IndexOf("update") >= 0) this.isUpdate = true;
        }

        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                this.scoreTextBox.Text = this.score.ToString();
                this.actionButton.Text = "Update";
            } else
            {
                this.actionButton.Text = "Add";
            }
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            if (this.scoreTextBox.IsPresent() && this.scoreTextBox.IsInt32() && this.scoreTextBox.IsWithinRange(0, 100))
            {
                this.score = Convert.ToInt32(this.scoreTextBox.Text);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}

using System;
using System.Windows.Forms;
using System.IO;
using WordSearch.PuzzleUtils;

namespace WordSearch
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            PredefinedPuzzles.LoadPredefinedPuzzles();

        }

        private void buttonGameConfiguration_Click(object sender, EventArgs e)
        {
            new FormConfiguration().Show();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            new FormGame().Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creat de Ana Maciuc!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void highscoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormHighscores().Show();
        }
    }
}

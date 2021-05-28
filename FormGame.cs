using System.Windows.Forms;
using System.Drawing;
using WordSearch.PuzzleUtils;
using System;
using System.Linq;

namespace WordSearch
{
    public partial class FormGame : Form
    {
        private Point firstSelected;
        private Point secondSelected;

        private int labelsSelectedCount = 0;
        private Rebus rebus;

        private DateTime rebusBeggining;
        private int SecondsPassed;
        public FormGame()
        {
            InitializeComponent();
            labelTimeLeft.Text = App.GameMaxTimeInSeconds.ToString();
            Player.LoadTop10FromHighscoreFile();
        }
        public void LoadRebus(Puzzle puzzle)
        {
            var start = new Point()
            {
                X = 20,
                Y = 20
            };
            this.rebus = new Rebus(groupBoxRebus, start, puzzle, rebusLabel_Click);
            foreach (var word in puzzle.Words.Select(x => x.OriginalWord))
            {
                listBoxWordsLeft.Items.Add(word);
            }

        }
        private void rebusLabel_Click(object sender, EventArgs e)
        {
            var obj = (Label)sender;
            var coords = (Point)obj.Tag;
            var lin = coords.Y;
            var col = coords.X;

            if (false == rebus.IsAvailable[lin, col])
            {
                return;
            }

            if (0 == labelsSelectedCount) // nicio casuta selectata
            {
                labelsSelectedCount++;
                firstSelected = coords;
                rebus.MarkCell(coords);
                return;
            }

            if (labelsSelectedCount == 1) // 1 casuta selectata
            {
                if (firstSelected == coords) // daca dau click pe aceiasi se anuleaza selectia
                {
                    rebus.UnselectCell(coords);
                    labelsSelectedCount = 0;
                    return;
                }
                labelsSelectedCount++;
                rebus.SelectCell(coords);
                rebus.SelectCell(firstSelected);
            }

            // sunt 2 labeluri selectate
            if (2 == labelsSelectedCount)
            {
                labelsSelectedCount = 0;
                secondSelected = coords;

                int wordIndex = rebus.Puzzle.IndexWordFromStartToEnd(firstSelected, secondSelected);
                // daca este selectat cuvant inexistent
                if (-1 == wordIndex)
                {
                    MessageBox.Show($"Cuvantul {rebus.Puzzle.GetStringWordFromStartToEnd(firstSelected, secondSelected)} este inexistent in lista!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rebus.UnselectCell(firstSelected);
                    rebus.UnselectCell(secondSelected);

                    return;
                }
                // userul a gasit cuvantul in puzzle
                UpdateNewWordFound(wordIndex, firstSelected, secondSelected);
                // daca a castigat jocul
                if (listBoxWordsLeft.Items.Count == 0)
                {
                    GameWon();
                }

            }


        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            LoadRebus(PredefinedPuzzles.LoadedPuzzles[0]);
            rebusBeggining = DateTime.Now;

            timerGameTime.Interval = 1000; // every second (1000ms <=> 1s)
            SecondsPassed = 0;

            StartGameWindow();
        }

        private void timerGameTime_Tick(object sender, EventArgs e)
        {
            SecondsPassed++;
            if (SecondsPassed == App.GameMaxTimeInSeconds)
            {
                MessageBox.Show("Nu te-ai incadrat in timp, din pacate!", "Mai incearca!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StopGameWindow();
                return;
            }
            labelTimePassed.Text = SecondsPassed.ToString();
            labelTimeLeft.Text = (App.GameMaxTimeInSeconds - SecondsPassed).ToString();

        }
        private void GameWon()
        {
            StopGameWindow();

            MessageBox.Show("Ai rezolvat cu succes tot puzzle-ul!");
            App.player = new Player()
            {
                TimeSpent = SecondsPassed,
                PuzzleSize = rebus.Size,
                FirstName = textBoxPrenume.Text,
                LastName = textBoxNume.Text,
                WordsGuessed = rebus.Puzzle.Size,
                WinDate = DateTime.Now
            };
            App.player.setScore();

            bool playerGotInTop10 = Player.CheckIfPlayerIsTop10(App.player);
            if (playerGotInTop10)
            {
                MessageBox.Show("Ai reusit sa intri in clasamentul primilor 10 cei mai buni jucatori!", "Felicitari !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nu ai reusit sa intri in clasament!", "Mai incearca!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            new FormHighscores().Show();
        }
        private void UpdateNewWordFound(int wordIndex, Point start, Point end)
        {
            listBoxWordsLeft.Items.Remove(rebus.Puzzle.Words[wordIndex].OriginalWord);
            listBoxWordsFound.Items.Add(rebus.Puzzle.Words[wordIndex].OriginalWord);
            this.rebus.SelectCellsFromStartToEnd(start, end);
        }
        private void StopGameWindow()
        {
            timerGameTime.Stop();
            foreach (Control c in this.Controls)
                c.Enabled = false;
        }
        private void StartGameWindow()
        {
            timerGameTime.Start();
            foreach (Control c in this.Controls)
                c.Enabled = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

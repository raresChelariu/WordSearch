using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WordSearch.PuzzleUtils;

namespace WordSearch
{
    public class Rebus
    {
        private Control container;
        private readonly Label[,] labels;
        public readonly int Size;
        public bool[,] IsAvailable;
        public Puzzle Puzzle;
        public IEnumerable<string> solvedWords = new List<string>();

        public Rebus(GroupBox container, Point start, Puzzle puzzle, EventHandler labelOnClickHandler)
        {
            this.container = container;
            this.Puzzle = puzzle;
            this.Size = puzzle.Size;

            this.labels = new Label[puzzle.Size, puzzle.Size];
            this.IsAvailable = new bool[puzzle.Size, puzzle.Size];
           
            for (var i = 0; i < Size; i++)
                for (var j = 0; j < Size; j++)
                {
                    container.Controls.Add(GetLabel(start, i, j, puzzle[i, j], labelOnClickHandler));
                    IsAvailable[i, j] = true;
                }
        }
        public Label this[int i, int j]
        {
            get => labels[i, j];
            set => labels[i, j] = value;
        }
        public Label GetLabel(Point start, int lin, int col, char value, EventHandler labelOnClickHandler)
        {
            var result = new Label()
            {
                Text = value + "",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 10, FontStyle.Bold),
                Size = new Size()
                {
                    Width = App.Label_Size,
                    Height = App.Label_Size
                },
                Left = start.X + col * App.Label_Size,
                Top = start.Y + lin * App.Label_Size,

                Tag = new Point()
                {
                    Y = lin,
                    X = col
                }
            };
            result.Click += labelOnClickHandler;

            labels[lin, col] = result;
            IsAvailable[lin, col] = false;

            return result;
        }
        public void MarkCell(Point p)
        {
            this[p.Y, p.X].BackColor = App.Label_BackColor_Marking;
        }
        public void SelectCell(Point p)
        {
            this[p.Y, p.X].BackColor = App.Label_BackColor_Selection;
            IsAvailable[p.Y, p.X] = false;
        }
        public void SelectCellsFromStartToEnd(Point start, Point end)
        {
            if (start.Y > end.Y || start.Y == end.Y && start.X > end.X)
            {
                var aux = start;
                start = end;
                end = aux;
            }
            var direction = Utils.GetDirection(start, end);
            switch (direction)
            {
                case WordDirection.Horizontal:
                    for (var i = start.X; i <= end.X; i++)
                    {
                        SelectCell(new Point() { Y = start.Y, X = i });
                    }
                    break;
                case WordDirection.Vertical:
                    for (var i = start.Y; i <= end.Y; i++)
                    {
                        SelectCell(new Point() { Y = i, X = start.X });
                    }
                    break;
                case WordDirection.Diagonal:
                    var col = start.X;
                    for (var i = start.Y; i <= end.Y; i++)
                    {
                        SelectCell(new Point() { Y = i, X = col});
                        col++;
                    }
                    break;
                case WordDirection.Impossible:
                    break;
                default:
                    break;
            }
        }
        public void UnselectCell(Point p)
        {
            this[p.Y, p.X].BackColor = SystemColors.Control;
            IsAvailable[p.Y, p.X] = true;
        }
        public bool AllWordsSolved(IEnumerable<string> solvedWords)
        {
            var puzzleWords = Puzzle.Words.Select(x => x.Word);
            return puzzleWords.EqualLists(solvedWords);
        }
    }
}

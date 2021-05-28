using System;
using System.Drawing;
namespace WordSearch.PuzzleUtils
{
    public class PuzzleWord
    {
        public readonly string OriginalWord;
        public readonly string Word;
        public readonly Point Start, End;
        public readonly WordDirection Direction;

        public PuzzleWord(string word, Point start, Point end, bool reverse = false)
        {
            this.OriginalWord = word;
            this.Start = start;
            this.End = end;

            if (reverse)
                this.Word = this.OriginalWord.Reverse();
            else
                this.Word = this.OriginalWord;

            this.Direction = GetDirectionByPointPair(this.Start, this.End);

            if (start.Y > end.Y || start.Y == end.Y && start.X > end.X)
            {
                this.Start = end;
                this.End = start;
            }
            else
            {
                this.Start = start;
                this.End = end;
            }
            
        }

        public static PuzzleWord FromString(string s)
        {
            // word startY start X endY endX [reverse]
            s = s.Trim("()".ToCharArray());
            var tokens = s.Split(',');

            var word = tokens[0];
            var startY = Convert.ToInt32(tokens[1]);
            var startX = Convert.ToInt32(tokens[2]);

            var endY = Convert.ToInt32(tokens[3]);
            var endX = Convert.ToInt32(tokens[4]);


            var reverse = false;
            if (tokens.Length > 5 && Convert.ToInt32(tokens[5]) == 1)
                reverse = true;

            return new PuzzleWord(word, new Point() { X = startX, Y = startY }, new Point() { X = endX, Y = endY }, reverse);
        }

        public int Length => OriginalWord.Length;
        public char this[int i] => this.Word[i];

        public static WordDirection GetDirectionByPointPair(Point a, Point b)
        {
            if (a.Y == b.Y)
                return WordDirection.Horizontal;
            if (a.X == b.X)
                return WordDirection.Vertical;
            if (Math.Abs(a.X - b.X) == Math.Abs(a.Y - b.Y))
                return WordDirection.Diagonal;
            return WordDirection.Impossible;
        }
    }
    public enum WordDirection
    {
        Horizontal,
        Vertical,
        Diagonal,
        Impossible
    }
}

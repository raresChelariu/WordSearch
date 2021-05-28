using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace WordSearch.PuzzleUtils
{
    public class Puzzle
    {
        public readonly int Size;
        private readonly char[,] Matrix;
        public readonly List<PuzzleWord> Words;
        public Puzzle(List<PuzzleWord> words, int size)
        {
            CheckWordsFit(words, size);

            this.Size = size;
            this.Matrix = MatrixWithZeros(size);
            this.Words = words;
            this.WriteWordsInPuzzle();
            this.FillWithRandomLetters();
        }
        public static Puzzle FromString(string s, char separator = ';')
        {
            var words = new List<PuzzleWord>();

            var tokens = s.Split(separator);
            var puzzleSize = Convert.ToInt32(tokens[0]);
           
            var wordCount = Convert.ToInt32(tokens[1]);

            for (var i = 0; i < wordCount; i++)
            {
                words.Add(PuzzleWord.FromString(tokens[2 + i]));
            }

            return new Puzzle(words, puzzleSize);
        }
        private static void CheckWordsFit(List<PuzzleWord> words, int size)
        {
            var invalidWords = words.Where(x => x.Length > size).Count();
            if (invalidWords > 0)
                throw new ArgumentException($"Not all words fit in matrix of size {size}");
        }

        public char this[int i, int j] {
            get => Matrix[i, j];
            set => Matrix[i, j] = value;
        }
        public void FillWithRandomLetters()
        {
            var r = new Random();

            for (var i = 0; i < Size; i++)
                for (var j = 0; j < Size; j++)
                {
                    if (this[i, j] == '0')
                        this[i, j] = (char) r.Next('A', 'Z');
                }
        }
        public static char[,] MatrixWithZeros(int size)
        {
            var result = new char[size,size];

            for (var i = 0; i < size; i++)
                for (var j = 0; j < size; j++)
                {
                    //result[i, j] = (char)0;
                    result[i, j] = '0';
                }
            return result;
        }
        public void WriteWordsInPuzzle()
        {
            foreach (PuzzleWord word in Words)
            {
                var currentLine = word.Start.Y;
                var currentCol = word.Start.X;
                switch (word.Direction)
                {
                    case WordDirection.Horizontal:
                        for (var i = 0; i < word.Length; i++)
                        {
                            this[currentLine, currentCol] = word[i];

                            currentCol++;
                        }
                        break;
                    case WordDirection.Vertical:
                        for (var i = 0; i < word.Length; i++)
                        {
                            this[currentLine, currentCol] = word[i];

                            currentLine++;
                        }
                        break;
                    case WordDirection.Diagonal:
                        for (var i = 0; i < word.Length; i++)
                        {
                            this[currentLine, currentCol] = word[i];

                            currentLine++; currentCol++;
                        }
                        break;
                    default:
                        break;
                }

            }
        }
        public override string ToString()
        {
            var result = string.Empty;
            for (var i = 0; i < this.Size; i++)
            {
                var currentLine = string.Empty;
                for (var j = 0; j < this.Size; j++)
                    currentLine += this[i, j];

                result += currentLine + Environment.NewLine;
            }
            return result;
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public string GetStringWordFromStartToEnd(Point start, Point end)
        {
            if (start.Y > end.Y || start.Y == end.Y && start.X > end.X)
            {
                var aux = start;
                start = end;
                end = aux;
            }
            var direction = PuzzleWord.GetDirectionByPointPair(start, end);

            var userSelection = string.Empty;
            switch (direction)
            {
                case WordDirection.Horizontal:
                    for (var i = start.X; i <= end.X; i++)
                        userSelection += this[start.Y, i];
                    break;
                case WordDirection.Vertical:
                    for (var i = start.Y; i <= end.Y; i++)
                        userSelection += this[i, start.X];
                    break;
                case WordDirection.Diagonal:
                    var currentCol = start.X;
                    for (var i = start.Y; i <= end.Y; i++)
                    {
                        userSelection += this[i, currentCol];
                        currentCol++;
                    }
                    break;
                default:
                    break;
            }
            return userSelection;
        }
        public int IndexWordFromStartToEnd(Point start, Point end)
        {
            var userWord = GetStringWordFromStartToEnd(start, end);
            for (var i = 0; i < Words.Count; i++)
            {
                if (Words[i].Word.Equals(userWord))
                    return i;
            }
            return -1;
        }
    }
}

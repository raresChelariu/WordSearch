using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordSearch
{
    public class Player
    {
        public string FirstName;
        public string LastName;
        public int PuzzleSize;
        public int WordsGuessed;
        public int TimeSpent;
        public DateTime WinDate;
        public int Score;
        public void setScore()
        {
            Score = WordsGuessed* PuzzleSize / TimeSpent;
        }

        public TimeSpan TimePassedSinceWin => DateTime.Now - WinDate;
        public static List<Player> top10;

        public static string PATH_SCORES = $@"{Utils.GetProjectRoot()}\scores.txt";
        public static void LoadTop10FromHighscoreFile()
        {
            var lines = File.ReadAllLines(PATH_SCORES);
            top10 = new List<Player>();
            for (var i = 0; i < lines.Length; i++)
            {
                top10.Add(FromString(lines[i]));
            }
        }
        public static void UpdateTop10(List<Player> players)
        {
            top10 = new List<Player>();
            top10.AddRange(players);
            var fileOutput = string.Empty;
            foreach (Player p in top10)
            {
                fileOutput += p.ToString() + Environment.NewLine;
            }
            File.WriteAllText(PATH_SCORES, fileOutput);
        }
        public Player()
        {

        }
        public override string ToString()
        {
            return $"{Score};{FirstName};{LastName};{PuzzleSize};{WordsGuessed};{TimeSpent};{WinDate}";
        }
        public string ToPrettyString()
        {
            return $"Score: {Score}; FirstName: {FirstName}; LastName: {LastName}; PuzzleSize: {PuzzleSize};WordsGuessed: {WordsGuessed}; TimeSpent: {TimeSpent}; WinDate: {WinDate}";
        }
        public static Player FromString(string s)
        {
            var tokens = s.Split(';');
            var result = new Player()
            {
                Score = Convert.ToInt32(tokens[0]),
                FirstName = tokens[1],
                LastName = tokens[2],
                PuzzleSize = Convert.ToInt32(tokens[3]),
                WordsGuessed = Convert.ToInt32(tokens[4]),
                TimeSpent = Convert.ToInt32(tokens[5]),
                WinDate = Convert.ToDateTime(tokens[6])
            };
            return result;
        }
        public static bool CheckIfPlayerIsTop10(Player p)
        {
            var playersBetter = top10.Where(x => x.Score > p.Score).Count();
            if (playersBetter > 10)
                return false;
            var topNew = new List<Player>();
            topNew.Add(p);
            topNew.AddRange(top10);
            UpdateTop10(topNew.OrderByDescending(x => x.Score).Take(10).ToList());
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;

namespace WordSearch.PuzzleUtils
{
    public class PredefinedPuzzles
    {
        public static string PUZZLE_DEFINITIONS_PATH = $@"{Utils.GetProjectRoot()}\puzzles.txt";
        public static List<Puzzle> LoadedPuzzles;
        private static void LoadPuzzles(string path)
        {
            LoadedPuzzles = new List<Puzzle>();

            var lines = File.ReadAllLines(path);
            for (var i = 0; i < lines.Length; i++)
            {
                var puzzle = Puzzle.FromString(lines[i]);
                LoadedPuzzles.Add(puzzle);
            }
        }
        public static void LoadPredefinedPuzzles()
        {
            LoadPuzzles(PUZZLE_DEFINITIONS_PATH);
        }
        
    }
}

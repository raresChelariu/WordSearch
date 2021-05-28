using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Drawing;
using WordSearch.PuzzleUtils;

namespace WordSearch
{
    public static class Utils
    {
        public static string Reverse(this string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static bool EqualLists(this IEnumerable<string> my, IEnumerable<string> other)
        {
            return my.All(other.Contains) && other.Count() == my.Count();
        }
        public static string GetProjectRoot()
        {
            return Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName;
        }
        public static WordDirection GetDirection(Point a, Point b)
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
}

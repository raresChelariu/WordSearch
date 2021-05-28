using System.Drawing;
using WordSearch.PuzzleUtils;

namespace WordSearch
{
    public class App
    {
        public static GameDifficulty Difficulty = GameDifficulty.Incepator;
        public static int GameMaxTimeInSeconds = 5 * 60;
        
        public static Puzzle puzzle;
        public static Player player;

        public const int Label_Size = 50;
        public static Color Label_BackColor_Selection = Color.IndianRed;
        public static Color Label_BackColor_Marking = Color.Olive;
       
    }
    
    public enum GameDifficulty
    {
        Incepator,
        Mediu,
        Avansat
    }
    
}

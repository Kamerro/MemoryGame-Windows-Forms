using System.IO;
using System.Runtime.InteropServices;

namespace MemoryGame.Configuration
{
    public class Config
    {
        public string ReverseLocalisation = $@"{Directory.GetCurrentDirectory()}\\images\\no\\ohno.png";
        internal string FrontLocalisation = $@"{Directory.GetCurrentDirectory()}\\images";
        internal string AllPNG = "*.png";
        public int ImageWidth = 150;
        public int ImageHeight = 150;
        public int Margin = 5;
        public int ColumnCount = 4;
        public int RowCount = 3;
        public int LeftMemoMarginWidth = 200;
        internal string StartingPoints = "Points:0/6";

        public string GAMEOVER = $"GAME OVER, YOU LOSE";
    }
}
using System;
using System.Drawing;
using System.Windows.Forms;
namespace MemoryGame.Cards
{
    public class Card : PictureBox
    {
        public Bitmap MainView;
        public Bitmap BackView;
        public Guid Pair;
        public Guid Identifier;
        public Card(Bitmap main, Bitmap back, Guid pair, Guid identifier)
        {
            MainView = main;
            BackView = back;
            Pair = pair;
            Identifier = identifier;
        }
        public Card GetCard()
        {
            if (this.Image != null && MainView != null && BackView != null && Pair != null && Identifier != null)
            {
                return this;
            }
            else
            {
                throw new Exception("There is null somewhere hidden, component have to be fully inicialized!");
            }
        }
    }
}

using MemoryGame.Cards;
using MemoryGame.Configuration;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MemoryGame.Generators
{
    public interface ICardGenerator
    {
        void GenerateCards(Panel mainPanel);
        List<Card> GenerateCards(string[] files);
        void PassParameters(GameShelf gameShelf, Config config,MemoControls controls);
    }
}
using MemoryGame.Configuration;
using System;
namespace MemoryGame.Generators
{
    public interface IImageClickEventHandler
    {
        void ClickImage(object sender, EventArgs e);
        void PassParameters(GameShelf gameShelf, MemoControls memoControls);
    }
}
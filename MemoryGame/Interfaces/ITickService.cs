using MemoryGame.Configuration;

namespace MemoryGame
{
    public interface ITickService
    {
        void AfterRevealSecondCard();
        void PassParameters(GameShelf gameParameters, MemoControls controls);
        void TickDownTime();
    }
}
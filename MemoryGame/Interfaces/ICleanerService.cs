using MemoryGame.Configuration;

namespace MemoryGame
{
    public interface ICleanerService
    {
        void ClearControls();
        void ClearGameParams();
        void PassParameters(MemoControls controls, GameShelf gameParameters);
    }
}
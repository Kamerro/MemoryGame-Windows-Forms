using MemoryGame.Configuration;
using MemoryGame.Generators;
using MemoryGame.Services;

namespace MemoryGame
{
    public interface IGameInitializer
    {
        void InitializeCards();
        void InitializeLabels();
        void ResetAllParameters();
        void PassParameters(MemoControls controls, GameShelf gameParameters, IImageService imageService, ICardGenerator cardGenerator, Config config);
    }
}
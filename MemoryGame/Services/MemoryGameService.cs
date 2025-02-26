using MemoryGame.Configuration;
using MemoryGame.Generators;
using MemoryGame.Services;
using System.Windows.Forms;

namespace MemoryGame
{
    public class MemoryGameService : IMemoryGameService
    {
        Config _config = new Config();
        GameShelf _gameParameters = new GameShelf();
        ICardGenerator _cardGenerator;
        IImageService _imageService;
        IGameInitializer _gameInitializer;
        MemoControls _controls;
        ITickService _tickService;
        public MemoryGameService(ITickService tickService, IImageService imgService,ICardGenerator cardGenerator, IGameInitializer gameInit)
        {
            _tickService = tickService;
            _imageService = imgService;
            _cardGenerator = cardGenerator;
            _gameInitializer = gameInit;
        }
        public void PassParameters(Button btn_new_game, Timer timer_all, Timer time_tick, Panel main_panel, Label lbl_points, Label lbl_time_left)
        {
            _controls = new MemoControls(btn_new_game, timer_all, time_tick, main_panel, lbl_points, lbl_time_left);
            _cardGenerator.PassParameters(gameShelf: _gameParameters, config: _config,controls:_controls);
            _gameInitializer.PassParameters(_controls, _gameParameters, _imageService, _cardGenerator, _config);
            _tickService.PassParameters(_gameParameters, _controls);
        }
        public void StartGame()
        {
            _gameInitializer.ResetAllParameters();
            _gameInitializer.InitializeCards();
            _gameInitializer.InitializeLabels();
        }
        public void AfterWaitingTick()
        {
            _tickService.AfterRevealSecondCard();
         
        }
        public void TickDownTime()
        {
            _tickService.TickDownTime();
        }
    }
}
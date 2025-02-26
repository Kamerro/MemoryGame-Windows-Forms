using MemoryGame.Configuration;
using System;
using System.Windows.Forms;

namespace MemoryGame
{
    internal class TickService : ITickService
    {
        GameShelf _gameParameters;
        MemoControls _memoControls;
        Config config = new Config();
        public void AfterRevealSecondCard()
        {
            _gameParameters.firstCard.Image = _gameParameters.firstCard.GetCard().BackView;
            _gameParameters.secondCard.Image = _gameParameters.secondCard.GetCard().BackView;
            _gameParameters.clickable = true;
            _memoControls.timeTick.Enabled = false;
        }
        public void PassParameters(GameShelf gameParameters, MemoControls controls)
        {
            _gameParameters = gameParameters;
            _memoControls = controls;
        }

        public void TickDownTime()
        {
            _gameParameters.time -= 1;
            if (_gameParameters.time == 0)
            {
                _gameParameters.GameOver = true;
                _memoControls.lblTimeLeft.Text = config.GAMEOVER;
                _memoControls.timeAll.Stop();
                _memoControls.btnNewGame.Enabled = true;
            }
            else _memoControls.lblTimeLeft.Text = $"Time left: {_gameParameters.time} s";
        }
    }
}
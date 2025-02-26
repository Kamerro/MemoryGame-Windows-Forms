using MemoryGame.Configuration;
using System;
using System.Windows.Forms;

namespace MemoryGame
{
    internal class CleanerService : ICleanerService
    {
        private MemoControls controls;
        private GameShelf gameParameters;

        public void PassParameters(MemoControls controls, GameShelf gameParameters)
        {
            this.controls = controls;
            this.gameParameters = gameParameters;
        }

        public void ClearControls()
        {
            controls.btnNewGame.Enabled = false;
            controls.timeAll.Start();
            controls.mainPanel.Controls.Clear();
        }

        public void ClearGameParams()
        {
            gameParameters.GameOver = false;
            gameParameters.time = 30;
            gameParameters.isFirstCardClicked = false;
            gameParameters.firstIdentifier = null;
            gameParameters.secondIdentifier = null;
            gameParameters.firstCard = null;
            gameParameters.secondCard = null;
            gameParameters.clickable = true;
            gameParameters.counter = 0;
        }
    }
}
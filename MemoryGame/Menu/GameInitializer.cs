using MemoryGame.Cards;
using MemoryGame.Configuration;
using MemoryGame.Generators;
using MemoryGame.Services;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MemoryGame
{
    public class GameInitializer : IGameInitializer
    {
        MemoControls controls;
        GameShelf gameParameters;
        IImageService _imageService;
        ICardGenerator _generator;
        Config config;
        ICleanerService _cleanerService;
        public void PassParameters(MemoControls controls, GameShelf gameParameters, IImageService imageService, ICardGenerator cardGenerator, Config config)
        {
            this.controls = controls;
            this.gameParameters = gameParameters;
            _imageService = imageService;
            _generator = cardGenerator;
            this.config = config;
            _cleanerService = new CleanerService();
            _cleanerService.PassParameters(this.controls, this.gameParameters);
        }
        public void InitializeCards()
        {
            gameParameters.MemoCards = ReadBitmapsFromDirectory();
            ShuffleBitmaps(gameParameters.MemoCards);
            _generator.GenerateCards(controls.mainPanel);
        }

        public void InitializeLabels()
        {
            controls.lblPoints.Text = config.StartingPoints;
            controls.lblTimeLeft.Text = $"Time left: {gameParameters.time} s";
        }

        public void ResetAllParameters()
        {
            _cleanerService.ClearControls();
            _cleanerService.ClearGameParams();
        }
        private List<Card> ReadBitmapsFromDirectory()
        {
            gameParameters.BackImage = _imageService.ReadReverse(config);
            var files = Directory.GetFiles(config.FrontLocalisation, config.AllPNG);
            return _generator.GenerateCards(files);
        }
        private void ShuffleBitmaps(List<Card> bitmaps)
        {
            bitmaps.Sort((x, y) => y.Identifier.CompareTo(x.Identifier));
        }
    }
}
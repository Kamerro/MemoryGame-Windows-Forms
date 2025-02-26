using MemoryGame.Cards;
using MemoryGame.Configuration;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MemoryGame.Generators
{
    public class CardGenerator : ICardGenerator
    {
        private GameShelf gameShelf;
        private Config config;
        private IImageClickEventHandler _imgClick;
        public CardGenerator(IImageClickEventHandler imgClick)
        {
            _imgClick = imgClick;
        }
        public List<Card> GenerateCards(string[] files)
        {
            List<Card> result = new List<Card>();
            files.ToList().ForEach(file =>
            {
                Bitmap bitmapFromFile = new Bitmap(file);
                Bitmap resizedBitmapFromFile = ResizeBitmap(bitmapFromFile, config.ImageWidth, config.ImageHeight);
                Bitmap resizedCopy = ResizeBitmap(bitmapFromFile, config.ImageWidth, config.ImageHeight);
                Guid pairIdentifier = Guid.NewGuid();
                result.Add(new Card(resizedBitmapFromFile, gameShelf.BackImage, pairIdentifier, identifier: Guid.NewGuid()));
                result.Add(new Card(resizedCopy, gameShelf.BackImage, pairIdentifier, identifier: Guid.NewGuid()));
            });
            return result;
        }
        public void PassParameters(GameShelf gameShelf, Config config, MemoControls c)
        {
            this.gameShelf = gameShelf;
            this.config = config;
            this._imgClick.PassParameters(gameShelf, c);
        }
        private Bitmap ResizeBitmap(Bitmap bitmapFromFile, int imageWidth, int imageHeight)
        {
            return new Bitmap(bitmapFromFile, new Size(imageWidth, imageHeight));
        }
        public void GenerateCards(Panel mainPanel)
        {
            int indexCard = 0;
            for (int column = 0; column < config.ColumnCount; column++)
            {
                for (int row = 0; row < config.RowCount; row++)
                {
                    CreateMemoCard(column, row, indexCard, mainPanel);
                    indexCard++;
                }
            }
        }
        private void CreateMemoCard(int column, int row, int indexCard, Panel mainPanel)
        {
            gameShelf.MemoCards[indexCard].Size = new Size(config.ImageWidth, config.ImageHeight);
            gameShelf.MemoCards[indexCard].Location = new Point(column * (config.ImageWidth + config.Margin) + config.LeftMemoMarginWidth, row * (config.ImageHeight + config.Margin));
            gameShelf.MemoCards[indexCard].Image = gameShelf.MemoCards[indexCard].BackView;
            gameShelf.MemoCards[indexCard].Click += _imgClick.ClickImage;
            mainPanel.Controls.Add(gameShelf.MemoCards[indexCard]);
        }
    }
}

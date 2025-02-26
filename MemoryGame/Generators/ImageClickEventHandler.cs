using MemoryGame.Cards;
using MemoryGame.Configuration;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MemoryGame.Generators
{
    public class ImageClickEventHandler : IImageClickEventHandler
    {
        GameShelf _gameShelf;
        MemoControls _memoControls;
        public void PassParameters(GameShelf gameShelf, MemoControls memoControls)
        {
            _gameShelf = gameShelf;
            _memoControls = memoControls;
        }
        public void ClickImage(object sender, EventArgs e)
        {
            if (OperationIsAllowed())
            {
                var clickedPictureBox = (sender as PictureBox);
                var clickedCard = (sender as Card).GetCard();

                if (IsFirstCardClicked(clickedCard))
                {
                    FirstCardClicked(clickedPictureBox, clickedCard);
                }
                else if (WasItLegalClick(clickedCard))
                {
                    SecondCardClicked(clickedPictureBox, clickedCard);
                }
            }
        }

        private void SecondCardClicked(PictureBox clickedPictureBox, Card clickedCard)
        {
            ChangeFrontOfTheClickedCard(clickedPictureBox, clickedCard);
            SetParametersInGameShelf(clickedCard);

            if (FirstCardPairIsTheSameAsSecond()) PairWereClicked();

            else _memoControls.timeTick.Enabled = true;

        }
        private void SetParametersInGameShelf(Card clickedCard)
        {
            _gameShelf.clickable = false;
            _gameShelf.secondCard = clickedCard;
            _gameShelf.isFirstCardClicked = false;
            _gameShelf.secondIdentifier = ReadIdentifier(clickedCard);
        }
        private string ReadIdentifier(Card clickedCard)
        {
            return _gameShelf.MemoCards.Where(x => x.Identifier == clickedCard.Identifier).FirstOrDefault().Pair.ToString();
        }

        private void ChangeFrontOfTheClickedCard(PictureBox clickedPictureBox, Card clickedCard)
        {
            clickedPictureBox.Image = clickedCard.MainView;
        }
        private void PairWereClicked()
        {
            _gameShelf.counter++;
            _memoControls.lblPoints.Text = $"Points:{_gameShelf.counter}/{_gameShelf.WinningPoints}";
            if (_gameShelf.counter == _gameShelf.WinningPoints)
            {
                GameWon();
            }
            _gameShelf.clickable = true;
        }

        private void GameWon()
        {
            _memoControls.btnNewGame.Enabled = true;
            _memoControls.timeAll.Enabled = false;
            _memoControls.lblPoints.Text = "You won, congrats!";
        }

        private bool FirstCardPairIsTheSameAsSecond()
        {
            return _gameShelf.firstIdentifier == _gameShelf.secondIdentifier;
        }

        private bool WasItLegalClick(Card clickedCard)
        {
            return clickedCard.Identifier != _gameShelf.firstCard.Identifier && clickedCard.Image != clickedCard.MainView;
        }

        private bool IsFirstCardClicked(Card clickedCard)
        {
            return !_gameShelf.isFirstCardClicked && clickedCard.Image != clickedCard.MainView;
        }
        private void FirstCardClicked(PictureBox clickedPictureBox, Card clickedCard)
        {
            clickedPictureBox.Image = clickedCard.MainView;
            _gameShelf.firstIdentifier = ReadIdentifier(clickedCard);
            _gameShelf.isFirstCardClicked = true;
            _gameShelf.firstCard = clickedCard;
        }
        private bool OperationIsAllowed()
        {
            return _memoControls.timeTick.Enabled == false && _gameShelf.clickable == true && _gameShelf.GameOver != true;
        }
    }
}
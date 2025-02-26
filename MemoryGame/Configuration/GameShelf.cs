using MemoryGame.Cards;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace MemoryGame.Configuration
{
    public class GameShelf
    {
       public List<Card> MemoCards;
       public Bitmap BackImage;
       public String firstIdentifier;
       public String secondIdentifier;
       public Card firstCard;
       public Card secondCard;
       public bool isFirstCardClicked = false;
       public int counter = 0;
       public bool clickable = true;
       public int time = 30;
       public bool GameOver = false;
       public int WinningPoints = 6;
    }
}

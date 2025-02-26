using MemoryGame.Generators;
using System;
using System.Windows.Forms;
namespace MemoryGame
{
    public partial class MemoGame : Form
    {
        private IMemoryGameService _memo;
        public MemoGame(IMemoryGameService memo)
        {
            InitializeComponent();
            _memo = memo;
            _memo.PassParameters(btnNewGame, timerAllTime, tickAfterReveal, mainPanel, lblPoints, lblTimeLeft);
            _memo.StartGame();
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            _memo.StartGame();
        }
        private void tickAfterReveal_Tick(object sender, EventArgs e)
        {
            _memo.AfterWaitingTick();
        }
        private void timerAllTime_Tick(object sender, EventArgs e)
        {
            _memo.TickDownTime();
        }
    }
}

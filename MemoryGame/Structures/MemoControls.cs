using System;
using System.Windows.Forms;

namespace MemoryGame
{
    public struct MemoControls
    {
        public Button btnNewGame;
        public Timer timeAll;
        public Timer timeTick;
        public Panel mainPanel;
        public Label lblPoints;
        public Label lblTimeLeft;

        public MemoControls(Button btn_new_game, Timer timer_all, Timer time_tick, Panel main_panel, Label lbl_points, Label lbl_time_left)
        {
            btnNewGame = btn_new_game;
            timeAll = timer_all;
            mainPanel = main_panel;
            lblPoints = lbl_points;
            lblTimeLeft = lbl_time_left;
            timeTick = time_tick;
        }
    }
}
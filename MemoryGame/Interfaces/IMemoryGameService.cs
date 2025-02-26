using System.Windows.Forms;

namespace MemoryGame
{
    public interface IMemoryGameService
    {
        void StartGame();
        void PassParameters(Button btn_new_game, Timer timer_all, Timer time_tick, Panel main_panel, Label lbl_points, Label lbl_time_left);
        void AfterWaitingTick();
        void TickDownTime();
    }
}
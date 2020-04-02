using System.Timers;

namespace SO
{
    public class DelayedEvent : GameEvent
    {
        public float delay;

        private readonly Timer timer = new Timer();

        public DelayedEvent()
        {
            timer.Elapsed += (s, e) =>
            {
                base.Raise();
                timer.Stop();
            };
        }

        public override void Raise()
        {
            timer.Interval = delay; // Allows delay changes
            timer.Start();
        }
    }
}
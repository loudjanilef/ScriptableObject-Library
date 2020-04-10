using UnityEngine.Events;

namespace SO
{
    public class UnityEventTrigger : IGameEventListener
    {
        public GameEvent GameEvent
        {
            get => gameEvent;
            set
            {
                gameEvent?.UnRegister(this);
                gameEvent = value;
                gameEvent.Register(this);
            }
        }

        private GameEvent gameEvent;
        public UnityEvent UnityEvent;

        public void Response()
        {
            UnityEvent.Invoke();
        }
    }
}
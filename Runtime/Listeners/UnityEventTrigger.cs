using SO.UI;
using UnityEngine.Events;

namespace SO
{
    public class UnityEventTrigger : MonoBehaviourEventListener
    {
        public GameEvent GameEvent
        {
            get => gameEvent;
            set
            {
                if (gameEvent)
                {
                    gameEvent.UnRegister(this);
                }

                gameEvent = value;

                if (gameEvent)
                {
                    gameEvent.Register(this);
                }
            }
        }

        private GameEvent gameEvent;
        public UnityEvent UnityEvent;

        public override void Response()
        {
            UnityEvent.Invoke();
        }
    }
}
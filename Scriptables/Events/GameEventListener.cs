using UnityEngine;
using UnityEngine.Events;

namespace SO
{
    public class GameEventListener : MonoBehaviour
    {
        public GameEvent gameEvent;
        public UnityEvent response;

        /// <summary>
        /// Override this to override the OnEnableLogic()
        /// </summary>
        protected virtual void OnEnableLogic()
        {
            if (gameEvent != null)
                gameEvent.Register(this);
        }

        private void OnEnable()
        {
            OnEnableLogic();
        }

        /// <summary>
        /// Override this to override the OnDisableLogic()
        /// </summary>
        protected virtual void OnDisableLogic()
        {
            if (gameEvent != null)
                gameEvent.UnRegister(this);
        }

        private void OnDisable()
        {
            OnDisableLogic();
        }

        public virtual void Response()
        {
            response.Invoke();
        }
    }
}
using UnityEngine;

namespace SO.UI
{
    public abstract class MonoBehaviourEventListener : MonoBehaviour, IGameEventListener
    {
        /// <summary>
        /// Determine if the Response should be called as soon as the game event is enabled
        /// </summary>
        public bool respondOnEnable;

        /// <summary>
        /// Determine if the Response should be called as soon as the game event is disabled (you never know)
        /// </summary>
        public bool respondOnDisable;

        protected virtual void OnEnable()
        {
            if (respondOnEnable)
            {
                Response();
            }
        }

        protected virtual void OnDisable()
        {
            if (respondOnDisable)
            {
                Response();
            }
        }

        public abstract void Response();
    }
}
using SO;
using UnityEngine;

namespace SA
{
    public class GameEventMonoBehaviorRaiser : MonoBehaviour
    {
        public GameEvent GameEvent;

        /// <summary>
        /// Raise the event as soon as this gameObject is enabled
        /// </summary>
        public bool raiseOnEnable;

        /// <summary>
        /// Raise the event as soon as this gameObject is disabled
        /// </summary>
        public bool raiseOnDisable;

        private void OnEnable()
        {
            if (raiseOnEnable)
            {
                GameEvent.Raise();
            }
        }

        private void OnDisable()
        {
            if (raiseOnDisable)
            {
                GameEvent.Raise();
            }
        }
    }
}
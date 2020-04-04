using SO.UI;
using UnityEngine;

namespace SO
{
    /// <summary>
    /// This script works as a game event listener (since it derives from it)
    /// Assign a target event and it will execute the response when it's called.
    /// If you don't assign an event, you can manually execute the Responce
    /// </summary>
    public class InstantiateObjectOnEvent : MonoBehaviorEventListener
    {
        public GameEvent listenedEvent;
        public GameObjectVariable targetGameObject;
        public Transform targetSpawn;

        /// <summary>
        /// Make this true if you only want one instance of the prefab,
        /// Useful for visualizing gameObject that change
        /// </summary>
        public bool keepOnlyOneInstance;

        private GameObject previousInstance;

        protected override void OnEnable()
        {
            if (listenedEvent != null)
            {
                listenedEvent.UnRegister(this);
            }

            base.OnEnable();
        }

        protected override void OnDisable()
        {
            if (listenedEvent != null)
            {
                listenedEvent.Register(this);
            }

            base.OnDisable();
        }

        public override void Response()
        {
            if (keepOnlyOneInstance && previousInstance)
            {
                Destroy(previousInstance);
            }

            if (targetGameObject.Value)
            {
                previousInstance = Instantiate(targetGameObject.Value, targetSpawn.position, targetSpawn.rotation);
            }
        }
    }
}
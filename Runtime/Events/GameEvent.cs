﻿using System.Collections.Generic;
using UnityEngine;

namespace SO
{
    [CreateAssetMenu(menuName = "Game Event")]
    public class GameEvent : ScriptableObject
    {
        private readonly List<IGameEventListener> listeners = new List<IGameEventListener>();

        public void Register(IGameEventListener l)
        {
            listeners.Add(l);
        }

        public void UnRegister(IGameEventListener l)
        {
            listeners.Remove(l);
        }

        public virtual void Raise()
        {
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].Response();
            }
        }
    }
}
using System.Collections.Generic;
using UnityEngine;

namespace SO
{
    public abstract class VariableEvent<T> : GameEvent
    {
        [SerializeField] private T value;

        public T Value
        {
            get => value;
            set
            {
                this.value = value;
                Raise();
            }
        }

        public void Set(VariableEvent<T> variableEvent)
        {
            Value = variableEvent.value;
        }

        protected bool Equals(VariableEvent<T> other)
        {
            return EqualityComparer<T>.Default.Equals(value, other.value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType() && obj.GetType() != typeof(T)) return false;
            if (obj.GetType() == typeof(T))
                return EqualityComparer<T>.Default.Equals(obj is T objAsT ? objAsT : default, Value);
            return Equals((VariableEvent<T>) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (base.GetHashCode() * 397) ^ EqualityComparer<T>.Default.GetHashCode(Value);
            }
        }
    }
}
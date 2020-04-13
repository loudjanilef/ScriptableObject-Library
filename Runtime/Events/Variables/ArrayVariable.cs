using System;

namespace SO
{
    public class ArrayVariable<T> : VariableEvent<T[]>
    {
        public int Length => Value.Length;

        public void Empty()
        {
            Value = null;
        }

        public void InitLength(int v)
        {
            Value = new T[v];
        }

        public void ReplaceAt(T newValue, int position)
        {
            if (position >= 0 && position < Value.Length)
            {
                Value[position] = newValue;
                Raise();
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(position));
            }
        }
    }
}
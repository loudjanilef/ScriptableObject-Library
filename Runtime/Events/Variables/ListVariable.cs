using System.Collections.Generic;

namespace SO
{
    public class ListVariable<T> : VariableEvent<List<T>>
    {
        public int Count => Value.Count;

        public void Add(T element)
        {
            Value.Add(element);
            Raise();
        }

        public void Insert(int index, T item)
        {
            Value.Insert(index, item);
            Raise();
        }

        public void RemoveAt(int index)
        {
            Value.RemoveAt(index);
            Raise();
        }

        public void Remove(T element)
        {
            Value.Remove(element);
            Raise();
        }

        public void Clear()
        {
            Value.Clear();
            Raise();
        }
    }
}
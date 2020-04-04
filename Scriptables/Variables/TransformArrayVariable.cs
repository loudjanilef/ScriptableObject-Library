using System;
using UnityEngine;

namespace SO
{
    [CreateAssetMenu(menuName = "Variables/Transform Array")]
    public class TransformArrayVariable : VariableEvent<Transform[]>
    {
        public int Length()
        {
            return Value.Length;
        }

        public void Clear()
        {
            Value = null;
        }

        public void Init(int v)
        {
            Value = new Transform[v];
        }

        public void ReplaceAt(Transform targetTransform, int position)
        {
            if (position < Value.Length)
            {
                Value[position] = targetTransform;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(position));
            }
        }
    }
}
using UnityEngine;

namespace SO
{
    [CreateAssetMenu(menuName = "Variables/Integer")]
    public class IntVariable : VariableEvent<int>
    {
        public void Add(int v)
        {
            Value += v;
        }

        public void Add(IntVariable intVariable)
        {
            Value += intVariable.Value;
        }

        public void Add(float v)
        {
            Value += Mathf.RoundToInt(v);
        }

        public void Add(FloatVariable floatVariable)
        {
            Value += Mathf.RoundToInt(floatVariable.Value);
        }

        public void Sub(int v)
        {
            Value -= v;
        }

        public void Sub(IntVariable intVariable)
        {
            Value -= intVariable.Value;
        }

        public void Sub(float v)
        {
            Value -= Mathf.RoundToInt(v);
        }

        public void Sub(FloatVariable floatVariable)
        {
            Value -= Mathf.RoundToInt(floatVariable.Value);
        }
    }
}
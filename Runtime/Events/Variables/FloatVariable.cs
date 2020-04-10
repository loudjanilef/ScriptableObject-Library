using UnityEngine;

namespace SO
{
    [CreateAssetMenu(menuName = "Variables/Float")]
    public class FloatVariable : VariableEvent<float>
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
            Value += v;
        }

        public void Add(FloatVariable floatVariable)
        {
            Value += floatVariable.Value;
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
            Value -= v;
        }

        public void Sub(FloatVariable floatVariable)
        {
            Value -= floatVariable.Value;
        }
    }
}
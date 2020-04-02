using UnityEngine;

namespace SO
{
    [CreateAssetMenu(menuName = "Variables/Integer")]
    public class IntVariable : NumberVariable
    {
        public int value;

        public void Set(int v)
        {
            value = v;
        }

        public void Set(NumberVariable v)
        {
            switch (v)
            {
                case FloatVariable floatVariable:
                {
                    value = Mathf.RoundToInt(floatVariable.value);
                    break;
                }
                case IntVariable intVariable:
                {
                    value = intVariable.value;
                    break;
                }
            }
        }

        public void Add(int v)
        {
            value += v;
        }

        public void Add(NumberVariable v)
        {
            switch (v)
            {
                case FloatVariable floatVariable:
                {
                    value += Mathf.RoundToInt(floatVariable.value);
                    break;
                }
                case IntVariable intVariable:
                {
                    value += intVariable.value;
                    break;
                }
            }
        }
    }
}
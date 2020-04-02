using UnityEngine;

namespace SO
{
    [CreateAssetMenu(menuName = "Variables/Float")]
    public class FloatVariable : NumberVariable
    {
        public float value;

        public void Set(float v)
        {
            value = v;
        }

        public void Set(NumberVariable v)
        {
            switch (v)
            {
                case FloatVariable floatVariable:
                {
                    value = floatVariable.value;
                    break;
                }
                case IntVariable intVariable:
                {
                    value = intVariable.value;
                    break;
                }
            }
        }

        public void Add(float v)
        {
            value += v;
        }

        public void Add(NumberVariable v)
        {
            switch (v)
            {
                case FloatVariable floatVariable:
                {
                    value += floatVariable.value;
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
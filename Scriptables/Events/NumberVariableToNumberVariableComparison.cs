using UnityEngine;
using UnityEngine.Events;

namespace SO
{
    public class NumberVariableToNumberVariableComparison : EventExecutionOnMB
    {
        public NumberVariable value1;
        public NumberVariable value2;

        public UnityEvent IfValue1IsLower;
        public UnityEvent IfValue1IsHigher;

        /// <summary>
        /// Raise true or false event stack based on the comparison of two number variables
        /// </summary>
        public override void Raise()
        {
            if (value1 == null || value2 == null)
            {
                Debug.Log("Number variable comparison doesn't have variables assigned! " + gameObject);
                return;
            }

            float v1 = 0;
            float v2 = 0;

            switch (value1)
            {
                case FloatVariable floatVariable:
                {
                    v1 = floatVariable.value;
                    break;
                }
                case IntVariable intVariable:
                {
                    v1 = intVariable.value;
                    break;
                }
            }

            switch (value2)
            {
                case FloatVariable floatVariable:
                {
                    v2 = floatVariable.value;
                    break;
                }
                case IntVariable intVariable:
                {
                    v2 = intVariable.value;
                    break;
                }
            }

            if (v1 < v2)
            {
                IfValue1IsLower.Invoke();
            }
            else
            {
                IfValue1IsHigher.Invoke();
            }
        }
    }
}
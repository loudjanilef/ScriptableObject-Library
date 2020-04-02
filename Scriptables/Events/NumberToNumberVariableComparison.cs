using UnityEngine;
using UnityEngine.Events;

namespace SO
{
    public class NumberToNumberVariableComparison : EventExecutionOnMB
    {
        public float fixedNumber;
        public NumberVariable targetVariable;

        public UnityEvent IfVariableIsLower;
        public UnityEvent IfVariableIsHigher;

        /// <summary>
        /// Invoke the true or false event stack based on a comparison of your targetVariable and a fixed number
        /// The comparison only runs when the Raise() is called, it's not monitored in Update or etc.
        /// </summary>
        public override void Raise()
        {
            if (targetVariable == null)
            {
                Debug.Log("No number variable assigned in a fixed number to numberVariable comparison! " +
                          this.gameObject.name);
                return;
            }

            switch (targetVariable)
            {
                case FloatVariable floatVariable:
                {
                    if (floatVariable.value < fixedNumber)
                        IfVariableIsLower.Invoke();
                    else
                        IfVariableIsHigher.Invoke();
                    break;
                }
                case IntVariable intVariable:
                {
                    int fixedNumberRoundedToInt = Mathf.RoundToInt(fixedNumber);
                    if (intVariable.value < fixedNumberRoundedToInt)
                        IfVariableIsLower.Invoke();
                    else
                        IfVariableIsHigher.Invoke();
                    break;
                }
            }
        }
    }
}
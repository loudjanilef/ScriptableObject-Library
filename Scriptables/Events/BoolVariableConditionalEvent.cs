﻿using UnityEngine;
using UnityEngine.Events;

namespace SO
{
    public class BoolVariableConditionalEvent : EventExecutionOnMB
    {
        public BoolVariable targetBool;

        public UnityEvent IfTrue;
        public UnityEvent IfFalse;

        /// <summary>
        /// Use this to raise either a true or false event stack based on a bool variable
        /// </summary>
        public override void Raise()
        {
            if (targetBool == null)
            {
                Debug.Log("Bool Variable not assigned on Conditional Event " + gameObject.name);
                return;
            }

            if (targetBool.value)
                IfTrue.Invoke();
            else
                IfFalse.Invoke();
        }
    }
}
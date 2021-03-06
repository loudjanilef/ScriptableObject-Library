﻿using UnityEngine.UI;

namespace SO.UI
{
    public class TextUpdater : MonoBehaviourEventListener
    {
        public StringVariable targetVariable;
        public Text targetText;

        protected override void OnEnable()
        {
            if (targetVariable != null)
            {
                targetVariable.Register(this);
            }

            base.OnEnable();
        }

        protected override void OnDisable()
        {
            if (targetVariable != null)
            {
                targetVariable.UnRegister(this);
            }

            base.OnDisable();
        }

        public override void Response()
        {
            targetText.text = targetVariable.Value;
        }
    }
}
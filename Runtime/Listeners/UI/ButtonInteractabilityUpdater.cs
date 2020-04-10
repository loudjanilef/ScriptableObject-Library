using UnityEngine.UI;

namespace SO.UI
{
    public class ButtonInteractabilityUpdater : MonoBehaviorEventListener
    {
        public BoolVariable targetVariable;
        public Button targetButton;

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
            targetButton.interactable = targetVariable.Value;
        }
    }
}
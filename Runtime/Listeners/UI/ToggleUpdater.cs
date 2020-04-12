using UnityEngine.UI;

namespace SO.UI
{
    public class ToggleUpdater : MonoBehaviourEventListener
    {
        public BoolVariable targetVariable;
        public Toggle targetToggle;

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
            targetToggle.isOn = targetVariable.Value;
        }
    }
}
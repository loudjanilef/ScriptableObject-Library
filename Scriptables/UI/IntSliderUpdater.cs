using UnityEngine.UI;

namespace SO.UI
{
    public class IntSliderUpdater : MonoBehaviorEventListener
    {
        public IntVariable targetVariable;
        public Slider targetSlider;

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
            targetSlider.value = targetVariable.Value;
        }
    }
}
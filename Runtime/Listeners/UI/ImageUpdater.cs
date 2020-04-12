using UnityEngine.UI;

namespace SO.UI
{
    public class ImageUpdater : MonoBehaviourEventListener
    {
        public SpriteVariable targetVariable;
        public Image targetImage;

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
            targetImage.sprite = targetVariable.Value;
        }
    }
}
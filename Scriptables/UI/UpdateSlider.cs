using UnityEngine.UI;

namespace SO.UI
{
    public class UpdateSlider : UIPropertyUpdater
    {
        public NumberVariable targetVariable;
        public Slider targetSlider;

        public override void Raise()
        {
            switch (targetVariable)
            {
                case FloatVariable floatVariable:
                {
                    targetSlider.value = floatVariable.value;
                    return;
                }
                case IntVariable intVariable:
                {
                    targetSlider.value = intVariable.value;
                    break;
                }
            }
        }
    }
}
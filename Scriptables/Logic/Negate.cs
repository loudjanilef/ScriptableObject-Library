using UnityEngine;

namespace SO
{
    [CreateAssetMenu(menuName = "Logic/Negate")]
    public class Negate : BoolVariable, IGameEventListener
    {
        public BoolVariable Variable
        {
            get => variable;
            set
            {
                if (variable != null)
                    variable.UnRegister(this);
                variable = value;
                variable.Register(this);
            }
        }

        [SerializeField] private BoolVariable variable;

        public void Response()
        {
            if (variable == null)
                return;

            Value = !variable.Value;
        }
    }
}
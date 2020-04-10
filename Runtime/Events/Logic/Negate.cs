using UnityEngine;

namespace SO
{
    [CreateAssetMenu(menuName = "Logic/Negate")]
    public class Negate : BoolVariable, IGameEventListener
    {
        private void OnEnable()
        {
            if (variable)
            {
                variable.Register(this);
            }
        }

        private void OnDisable()
        {
            if (variable)
            {
                variable.UnRegister(this);
            }
        }

        public BoolVariable Variable
        {
            get => variable;
            set
            {
                if (variable)
                    variable.UnRegister(this);
                variable = value;
                if (variable)
                {
                    variable.Register(this);
                }
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
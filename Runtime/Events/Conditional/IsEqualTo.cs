using UnityEngine;

namespace SO
{
    [CreateAssetMenu(menuName = "Conditional/IsEqualTo")]
    public class IsEqualTo : GameEvent, IGameEventListener
    {
        private void OnEnable()
        {
            if (variable1)
            {
                variable1.Register(this);
            }

            if (variable2)
            {
                variable2.Register(this);
            }
        }
        
        private void OnDisable()
        {
            if (variable1)
            {
                variable1.UnRegister(this);
            }

            if (variable2)
            {
                variable2.UnRegister(this);
            }
        }

        public VariableEvent<object> Variable1
        {
            get => variable1;
            set
            {
                if (variable1)
                {
                    variable1.UnRegister(this);
                }

                variable1 = value;
                if (variable1)
                {
                    variable1.Register(this);
                }
            }
        }

        public VariableEvent<object> Variable2
        {
            get => variable2;
            set
            {
                if (variable2)
                {
                    variable2.UnRegister(this);
                }

                variable2 = value;
                if (variable2)
                {
                    variable2.Register(this);
                }
            }
        }

        private VariableEvent<object> variable1;
        private VariableEvent<object> variable2;

        public void Response()
        {
            if (variable1 == null || variable2 == null)
                return;

            if (Variable1.Value.Equals(Variable2.Value))
            {
                Raise();
            }
        }
    }
}
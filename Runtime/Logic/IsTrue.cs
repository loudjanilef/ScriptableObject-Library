using UnityEngine;

namespace SO
{
    [CreateAssetMenu(menuName = "Logic/IsTrue")]
    public class IsTrue : GameEvent, IGameEventListener
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

        public VariableEvent<bool> Variable
        {
            get => variable;
            set
            {
                if (variable)
                {
                    variable.UnRegister(this);
                }

                variable = value;
                if (variable)
                {
                    variable.Register(this);
                }
            }
        }

        private VariableEvent<bool> variable;

        public void Response()
        {
            if (variable == null)
                return;

            if (Variable.Value)
            {
                Raise();
            }
        }
    }
}
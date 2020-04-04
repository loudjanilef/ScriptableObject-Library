using System;

namespace SO
{
    public class IsLowerThan : GameEvent, IGameEventListener
    {
        public VariableEvent<IComparable> Variable1
        {
            get => variable1;
            set
            {
                variable1?.UnRegister(this);
                variable1 = value;
                variable1.Register(this);
            }
        }

        public VariableEvent<IComparable> Variable2
        {
            get => variable2;
            set
            {
                variable2?.UnRegister(this);
                variable2 = value;
                variable2.Register(this);
            }
        }

        private VariableEvent<IComparable> variable1;
        private VariableEvent<IComparable> variable2;

        public void Response()
        {
            if (variable1 == null || variable2 == null)
                return;

            if (Variable1.Value.CompareTo(Variable2.Value) < 0)
            {
                Raise();
            }
        }
    }
}
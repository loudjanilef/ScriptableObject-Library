namespace SO
{
    public class IsEqualTo : GameEvent, IGameEventListener
    {
        public VariableEvent<object> Variable1
        {
            get => variable1;
            set
            {
                variable1?.UnRegister(this);
                variable1 = value;
                variable1.Register(this);
            }
        }

        public VariableEvent<object> Variable2
        {
            get => variable2;
            set
            {
                variable2?.UnRegister(this);
                variable2 = value;
                variable2.Register(this);
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
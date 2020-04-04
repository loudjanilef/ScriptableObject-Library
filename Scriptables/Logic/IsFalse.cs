namespace SO
{
    public class Isfalse : GameEvent, IGameEventListener
    {
        public VariableEvent<bool> Variable
        {
            get => variable;
            set
            {
                variable?.UnRegister(this);
                variable = value;
                variable.Register(this);
            }
        }

        private VariableEvent<bool> variable;

        public void Response()
        {
            if (variable == null)
                return;

            if (!Variable.Value)
            {
                Raise();
            }
        }
    }
}
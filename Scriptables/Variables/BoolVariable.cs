using UnityEngine;

namespace SO
{
    [CreateAssetMenu(menuName = "Variables/Bool")]
    public class BoolVariable : VariableEvent<bool>
    {
        public void Reverse()
        {
            Value = !Value;
        }
    }
}
using UnityEngine;

namespace SO
{
    [CreateAssetMenu(menuName = "Variables/String")]
    public class StringVariable : VariableEvent<string>
    {
        public bool IsEmptyOrNull()
        {
            return string.IsNullOrEmpty(Value);
        }

        public void Clear()
        {
            Value = string.Empty;
        }
    }
}
using UnityEngine;

namespace SO
{
    [CreateAssetMenu(menuName = "Variables/Transform")]
    public class TransformVariable : VariableEvent<Transform>
    {
        public void Clear()
        {
            Value = null;
        }
    }
}
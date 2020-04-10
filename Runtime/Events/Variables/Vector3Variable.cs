using UnityEngine;

namespace SO
{
    [CreateAssetMenu(menuName = "Variables/Vector3")]
    public class Vector3Variable : VariableEvent<Vector3>
    {
        public void Add(Vector3 vector3)
        {
            Value += vector3;
        }

        public void Add(Vector3Variable vector3Variable)
        {
            Value += vector3Variable.Value;
        }

        public void Sub(Vector3 vector3)
        {
            Value -= vector3;
        }

        public void Sub(Vector3Variable vector3Variable)
        {
            Value -= vector3Variable.Value;
        }
    }
}
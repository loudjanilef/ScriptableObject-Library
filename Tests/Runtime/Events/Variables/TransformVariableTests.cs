using NUnit.Framework;
using SO;
using UnityEngine;

namespace Tests
{
    public class TransformVariableTests
    {
        [Test]
        public void Clear()
        {
            TransformVariable stringVariable = ScriptableObject.CreateInstance<TransformVariable>();
            SimpleGameEventListener listener = new SimpleGameEventListener();
            stringVariable.Value = new GameObject().transform;
            stringVariable.Register(listener);
            Assert.AreEqual(0, listener.ResponseCallNumber);
            Assert.IsNotNull(stringVariable.Value);
            stringVariable.Clear();
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.IsNull(stringVariable.Value);
        }
    }
}
using NUnit.Framework;
using SO;
using UnityEngine;

namespace Tests
{
    public class BoolVariableTests
    {
        [Test]
        public void Reverse()
        {
            BoolVariable boolVariable = ScriptableObject.CreateInstance<BoolVariable>();
            SimpleGameEventListener listener = new SimpleGameEventListener();
            boolVariable.Register(listener);

            Assert.AreEqual(0, listener.ResponseCallNumber);
            Assert.IsFalse(boolVariable.Value);
            boolVariable.Reverse();
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.IsTrue(boolVariable.Value);
        }
    }
}
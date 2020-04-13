using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class VariableEventTests
    {
        [Test]
        public void RaiseOnSet()
        {
            SimpleGameEvent variableEvent = ScriptableObject.CreateInstance<SimpleGameEvent>();
            SimpleGameEventListener listener = new SimpleGameEventListener();

            Assert.AreEqual(0, listener.ResponseCallNumber);

            variableEvent.Register(listener);
            variableEvent.Value = 2;
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual(2, variableEvent.Value);
        }

        [Test]
        public void RaiseOnSetFromVariable()
        {
            SimpleGameEvent variableEvent = ScriptableObject.CreateInstance<SimpleGameEvent>();
            SimpleGameEventListener listener = new SimpleGameEventListener();
            SimpleGameEvent otherVariable = ScriptableObject.CreateInstance<SimpleGameEvent>();
            otherVariable.Value = 2;

            Assert.AreEqual(0, listener.ResponseCallNumber);

            variableEvent.Register(listener);
            variableEvent.Set(otherVariable);
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual(2, variableEvent.Value);
        }

        [Test]
        public void EqualsIsWorkingProperly()
        {
            SimpleGameEvent variableEvent = ScriptableObject.CreateInstance<SimpleGameEvent>();
            SimpleGameEvent otherVariable = ScriptableObject.CreateInstance<SimpleGameEvent>();

            // VariableEvent is not equal to null
            Assert.IsFalse(variableEvent.Equals(null));

            // VariableEvent is not equal to other type
            Assert.IsFalse(new Object());

            // VariableEvent is equal to itself
            Assert.IsTrue(variableEvent.Equals(variableEvent));

            // VariableEvent can be compared to its value type
            Assert.IsTrue(variableEvent.Equals(0));
            Assert.IsFalse(variableEvent.Equals(1));

            // VariableEvent can be compared with VariableEvent
            Assert.IsTrue(variableEvent.Equals(otherVariable));
            otherVariable.Value = 1;
            Assert.IsFalse(variableEvent.Equals(otherVariable));
        }
    }
}
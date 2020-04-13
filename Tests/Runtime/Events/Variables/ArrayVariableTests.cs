using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class ArrayVariableTests
    {
        [Test]
        public void InitLength()
        {
            SimpleArrayVariableEvent arrayVariableEvent = ScriptableObject.CreateInstance<SimpleArrayVariableEvent>();
            Assert.IsNull(arrayVariableEvent.Value);

            SimpleGameEventListener listener = new SimpleGameEventListener();
            arrayVariableEvent.Register(listener);
            Assert.AreEqual(0, listener.ResponseCallNumber);

            arrayVariableEvent.InitLength(5);
            Assert.IsNotNull(arrayVariableEvent.Value);
            Assert.AreEqual(5, arrayVariableEvent.Value.Length);
            Assert.AreEqual(1, listener.ResponseCallNumber);
        }

        [Test]
        public void Empty()
        {
            SimpleArrayVariableEvent arrayVariableEvent = ScriptableObject.CreateInstance<SimpleArrayVariableEvent>();
            SimpleGameEventListener listener = new SimpleGameEventListener();

            arrayVariableEvent.Value = new int[5];
            Assert.IsNotNull(arrayVariableEvent.Value);
            arrayVariableEvent.Register(listener);
            Assert.AreEqual(0, listener.ResponseCallNumber);

            arrayVariableEvent.Empty();
            Assert.IsNull(arrayVariableEvent.Value);
            Assert.AreEqual(1, listener.ResponseCallNumber);
        }

        [Test]
        public void Length()
        {
            SimpleArrayVariableEvent arrayVariableEvent = ScriptableObject.CreateInstance<SimpleArrayVariableEvent>();
            arrayVariableEvent.Value = new int[5];
            Assert.AreEqual(arrayVariableEvent.Value.Length, arrayVariableEvent.Length);
        }

        [Test]
        public void ReplaceAt()
        {
            SimpleArrayVariableEvent arrayVariableEvent = ScriptableObject.CreateInstance<SimpleArrayVariableEvent>();
            SimpleGameEventListener listener = new SimpleGameEventListener();

            arrayVariableEvent.Value = new int[3];
            Assert.AreEqual(new[] {0, 0, 0}, arrayVariableEvent.Value);
            arrayVariableEvent.Register(listener);
            Assert.AreEqual(0, listener.ResponseCallNumber);

            arrayVariableEvent.ReplaceAt(1, 1);
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual(new[] {0, 1, 0}, arrayVariableEvent.Value);
        }
    }
}
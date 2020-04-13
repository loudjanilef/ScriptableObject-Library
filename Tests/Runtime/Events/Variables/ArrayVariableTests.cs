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

            arrayVariableEvent.InitLength(5);
            Assert.IsNotNull(arrayVariableEvent.Value);
            Assert.AreEqual(5, arrayVariableEvent.Value.Length);
        }

        [Test]
        public void Empty()
        {
            SimpleArrayVariableEvent arrayVariableEvent = ScriptableObject.CreateInstance<SimpleArrayVariableEvent>();
            arrayVariableEvent.Value = new int[5];
            Assert.IsNotNull(arrayVariableEvent.Value);

            arrayVariableEvent.Empty();
            Assert.IsNull(arrayVariableEvent.Value);
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
            arrayVariableEvent.Value = new int[3];

            Assert.AreEqual(new[] {0, 0, 0}, arrayVariableEvent.Value);
            arrayVariableEvent.ReplaceAt(1, 1);
            Assert.AreEqual(new[] {0, 1, 0}, arrayVariableEvent.Value);
        }
    }
}
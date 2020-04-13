using NUnit.Framework;
using SO;
using UnityEngine;

namespace Tests
{
    public class StringVariableTests
    {
        [Test]
        public void IsEmptyOrNull()
        {
            StringVariable stringVariable = ScriptableObject.CreateInstance<StringVariable>();
            stringVariable.Value = null;
            Assert.IsTrue(stringVariable.IsEmptyOrNull());
            stringVariable.Value = string.Empty;
            Assert.IsTrue(stringVariable.IsEmptyOrNull());
            stringVariable.Value = "a";
            Assert.IsFalse(stringVariable.IsEmptyOrNull());
        }

        [Test]
        public void Clear()
        {
            StringVariable stringVariable = ScriptableObject.CreateInstance<StringVariable>();
            SimpleGameEventListener listener = new SimpleGameEventListener();
            stringVariable.Value = "a";
            stringVariable.Register(listener);
            Assert.AreEqual(0, listener.ResponseCallNumber);
            Assert.IsNotNull(stringVariable.Value);
            stringVariable.Clear();
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual("", stringVariable.Value);
        }
    }
}
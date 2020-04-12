using NUnit.Framework;
using SO;
using UnityEngine;

namespace Tests.Variables
{
    public class IntVariableTests
    {
        [Test]
        public void RaiseOnAddInt()
        {
            IntVariable variable = ScriptableObject.CreateInstance<IntVariable>();
            SimpleGameEventListener listener = new SimpleGameEventListener();

            Assert.AreEqual(0, listener.ResponseCallNumber);

            variable.Register(listener);
            variable.Add(2);
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual(2, variable.Value);
        }

        [Test]
        public void RaiseOnAddFloat()
        {
            IntVariable variable = ScriptableObject.CreateInstance<IntVariable>();
            SimpleGameEventListener listener = new SimpleGameEventListener();

            Assert.AreEqual(0, listener.ResponseCallNumber);

            variable.Register(listener);
            variable.Add(2.3f);
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual(2, variable.Value);

            variable.Add(2.6f);
            Assert.AreEqual(2, listener.ResponseCallNumber);
            Assert.AreEqual(5, variable.Value);
        }

        [Test]
        public void RaiseOnSubInt()
        {
            IntVariable variable = ScriptableObject.CreateInstance<IntVariable>();
            SimpleGameEventListener listener = new SimpleGameEventListener();

            Assert.AreEqual(0, listener.ResponseCallNumber);

            variable.Register(listener);
            variable.Sub(2);
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual(-2, variable.Value);
        }

        [Test]
        public void RaiseOnSubFloat()
        {
            IntVariable variable = ScriptableObject.CreateInstance<IntVariable>();
            SimpleGameEventListener listener = new SimpleGameEventListener();

            Assert.AreEqual(0, listener.ResponseCallNumber);

            variable.Register(listener);
            variable.Sub(2.3f);
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual(-2, variable.Value);

            variable.Sub(2.6f);
            Assert.AreEqual(2, listener.ResponseCallNumber);
            Assert.AreEqual(-5, variable.Value);
        }

        [Test]
        public void RaiseOnAddIntVariable()
        {
            IntVariable variable = ScriptableObject.CreateInstance<IntVariable>();
            SimpleGameEventListener listener = new SimpleGameEventListener();
            IntVariable otherVariable = ScriptableObject.CreateInstance<IntVariable>();
            otherVariable.Value = 2;

            Assert.AreEqual(0, listener.ResponseCallNumber);

            variable.Register(listener);
            variable.Add(otherVariable);
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual(2, variable.Value);
        }

        [Test]
        public void RaiseOnAddFloatVariable()
        {
            IntVariable variable = ScriptableObject.CreateInstance<IntVariable>();
            SimpleGameEventListener listener = new SimpleGameEventListener();
            FloatVariable otherVariable = ScriptableObject.CreateInstance<FloatVariable>();
            otherVariable.Value = 2.3f;

            Assert.AreEqual(0, listener.ResponseCallNumber);

            variable.Register(listener);
            variable.Add(otherVariable);
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual(2, variable.Value);

            otherVariable.Value = 2.6f;

            variable.Add(otherVariable);
            Assert.AreEqual(2, listener.ResponseCallNumber);
            Assert.AreEqual(5, variable.Value);
        }

        [Test]
        public void RaiseOnSubIntVariable()
        {
            IntVariable variable = ScriptableObject.CreateInstance<IntVariable>();
            SimpleGameEventListener listener = new SimpleGameEventListener();
            IntVariable otherVariable = ScriptableObject.CreateInstance<IntVariable>();
            otherVariable.Value = 2;

            Assert.AreEqual(0, listener.ResponseCallNumber);

            variable.Register(listener);
            variable.Sub(otherVariable);
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual(-2, variable.Value);
        }

        [Test]
        public void RaiseOnSubFloatVariable()
        {
            IntVariable variable = ScriptableObject.CreateInstance<IntVariable>();
            SimpleGameEventListener listener = new SimpleGameEventListener();
            FloatVariable otherVariable = ScriptableObject.CreateInstance<FloatVariable>();
            otherVariable.Value = 2.3f;

            Assert.AreEqual(0, listener.ResponseCallNumber);

            variable.Register(listener);
            variable.Sub(otherVariable);
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual(-2, variable.Value);

            otherVariable.Value = 2.6f;

            variable.Sub(otherVariable);
            Assert.AreEqual(2, listener.ResponseCallNumber);
            Assert.AreEqual(-5, variable.Value);
        }
    }
}
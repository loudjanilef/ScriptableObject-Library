using NUnit.Framework;
using SO;
using UnityEngine;

namespace Tests.Variables
{
    public class FloatVariableTests
    {
        [Test]
        public void RaiseOnAddInt()
        {
            FloatVariable variable = ScriptableObject.CreateInstance<FloatVariable>();
            SimpleGameEventListener listener = new SimpleGameEventListener();

            Assert.AreEqual(0, listener.ResponseCallNumber);

            variable.Register(listener);
            variable.Add(2);
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual(2f, variable.Value, 0.00001f);
        }

        [Test]
        public void RaiseOnAddFloat()
        {
            FloatVariable variable = ScriptableObject.CreateInstance<FloatVariable>();
            SimpleGameEventListener listener = new SimpleGameEventListener();

            Assert.AreEqual(0, listener.ResponseCallNumber);

            variable.Register(listener);
            variable.Add(2.3f);
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual(2.3f, variable.Value, 0.00001f);

            variable.Add(2.6f);
            Assert.AreEqual(2, listener.ResponseCallNumber);
            Assert.AreEqual(4.9f, variable.Value, 0.00001f);
        }

        [Test]
        public void RaiseOnSubInt()
        {
            FloatVariable variable = ScriptableObject.CreateInstance<FloatVariable>();
            SimpleGameEventListener listener = new SimpleGameEventListener();

            Assert.AreEqual(0, listener.ResponseCallNumber);

            variable.Register(listener);
            variable.Sub(2);
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual(-2f, variable.Value, 0.00001f);
        }

        [Test]
        public void RaiseOnSubFloat()
        {
            FloatVariable variable = ScriptableObject.CreateInstance<FloatVariable>();
            SimpleGameEventListener listener = new SimpleGameEventListener();

            Assert.AreEqual(0, listener.ResponseCallNumber);

            variable.Register(listener);
            variable.Sub(2.3f);
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual(-2.3f, variable.Value, 0.00001f);

            variable.Sub(2.6f);
            Assert.AreEqual(2, listener.ResponseCallNumber);
            Assert.AreEqual(-4.9f, variable.Value, 0.00001f);
        }

        [Test]
        public void RaiseOnAddIntVariable()
        {
            FloatVariable variable = ScriptableObject.CreateInstance<FloatVariable>();
            SimpleGameEventListener listener = new SimpleGameEventListener();
            IntVariable otherVariable = ScriptableObject.CreateInstance<IntVariable>();
            otherVariable.Value = 2;

            Assert.AreEqual(0, listener.ResponseCallNumber);

            variable.Register(listener);
            variable.Add(otherVariable);
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual(2f, variable.Value, 0.00001f);
        }

        [Test]
        public void RaiseOnAddFloatVariable()
        {
            FloatVariable variable = ScriptableObject.CreateInstance<FloatVariable>();
            SimpleGameEventListener listener = new SimpleGameEventListener();
            FloatVariable otherVariable = ScriptableObject.CreateInstance<FloatVariable>();
            otherVariable.Value = 2.3f;

            Assert.AreEqual(0, listener.ResponseCallNumber);

            variable.Register(listener);
            variable.Add(otherVariable);
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual(2.3f, variable.Value, 0.00001f);

            otherVariable.Value = 2.6f;

            variable.Add(otherVariable);
            Assert.AreEqual(2, listener.ResponseCallNumber);
            Assert.AreEqual(4.9f, variable.Value, 0.00001f);
        }

        [Test]
        public void RaiseOnSubIntVariable()
        {
            FloatVariable variable = ScriptableObject.CreateInstance<FloatVariable>();
            SimpleGameEventListener listener = new SimpleGameEventListener();
            IntVariable otherVariable = ScriptableObject.CreateInstance<IntVariable>();
            otherVariable.Value = 2;

            Assert.AreEqual(0, listener.ResponseCallNumber);

            variable.Register(listener);
            variable.Sub(otherVariable);
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual(-2f, variable.Value, 0.00001f);
        }

        [Test]
        public void RaiseOnSubFloatVariable()
        {
            FloatVariable variable = ScriptableObject.CreateInstance<FloatVariable>();
            SimpleGameEventListener listener = new SimpleGameEventListener();
            FloatVariable otherVariable = ScriptableObject.CreateInstance<FloatVariable>();
            otherVariable.Value = 2.3f;

            Assert.AreEqual(0, listener.ResponseCallNumber);

            variable.Register(listener);
            variable.Sub(otherVariable);
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual(-2.3f, variable.Value, 0.00001f);

            otherVariable.Value = 2.6f;

            variable.Sub(otherVariable);
            Assert.AreEqual(2, listener.ResponseCallNumber);
            Assert.AreEqual(-4.9f, variable.Value, 0.00001f);
        }
    }
}
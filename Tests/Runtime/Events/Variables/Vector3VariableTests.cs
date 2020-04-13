using NUnit.Framework;
using SO;
using UnityEngine;

namespace Tests
{
    public class Vector3VariableTests
    {
        [Test]
        public void RaiseOnAddVector3()
        {
            Vector3Variable vector3Variable = ScriptableObject.CreateInstance<Vector3Variable>();
            SimpleGameEventListener listener = new SimpleGameEventListener();

            Assert.AreEqual(0, listener.ResponseCallNumber);
            Assert.AreEqual(new Vector3(0, 0, 0), vector3Variable.Value);

            vector3Variable.Register(listener);
            vector3Variable.Add(new Vector3(1, 2, 3));
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual(new Vector3(1, 2, 3), vector3Variable.Value);
        }

        [Test]
        public void RaiseOnAddVector3Variable()
        {
            Vector3Variable vector3Variable = ScriptableObject.CreateInstance<Vector3Variable>();
            SimpleGameEventListener listener = new SimpleGameEventListener();
            Vector3Variable otherVariable = ScriptableObject.CreateInstance<Vector3Variable>();
            otherVariable.Value = new Vector3(1, 2, 3);

            Assert.AreEqual(0, listener.ResponseCallNumber);
            Assert.AreEqual(new Vector3(0, 0, 0), vector3Variable.Value);

            vector3Variable.Register(listener);
            vector3Variable.Add(otherVariable);
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual(new Vector3(1, 2, 3), vector3Variable.Value);
        }

        [Test]
        public void RaiseOnSubVector3()
        {
            Vector3Variable vector3Variable = ScriptableObject.CreateInstance<Vector3Variable>();
            SimpleGameEventListener listener = new SimpleGameEventListener();

            Assert.AreEqual(0, listener.ResponseCallNumber);
            Assert.AreEqual(new Vector3(0, 0, 0), vector3Variable.Value);

            vector3Variable.Register(listener);
            vector3Variable.Sub(new Vector3(1, 2, 3));
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual(new Vector3(-1, -2, -3), vector3Variable.Value);
        }

        [Test]
        public void RaiseOnSubVector3Variable()
        {
            Vector3Variable vector3Variable = ScriptableObject.CreateInstance<Vector3Variable>();
            SimpleGameEventListener listener = new SimpleGameEventListener();
            Vector3Variable otherVariable = ScriptableObject.CreateInstance<Vector3Variable>();
            otherVariable.Value = new Vector3(1, 2, 3);

            Assert.AreEqual(0, listener.ResponseCallNumber);
            Assert.AreEqual(new Vector3(0, 0, 0), vector3Variable.Value);

            vector3Variable.Register(listener);
            vector3Variable.Sub(otherVariable);
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual(new Vector3(-1, -2, -3), vector3Variable.Value);
        }
    }
}
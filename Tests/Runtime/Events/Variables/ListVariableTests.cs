using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class ListVariableTests
    {
        [Test]
        public void Count()
        {
            SimpleListVariableEvent listVariableEvent = ScriptableObject.CreateInstance<SimpleListVariableEvent>();
            listVariableEvent.Value = new List<int>(new[] {0, 0, 0, 0, 0});
            Assert.AreEqual(listVariableEvent.Value.Count, listVariableEvent.Count);
        }

        [Test]
        public void Init()
        {
            SimpleListVariableEvent listVariableEvent = ScriptableObject.CreateInstance<SimpleListVariableEvent>();
            SimpleGameEventListener listener = new SimpleGameEventListener();
            listVariableEvent.Register(listener);
            Assert.AreEqual(0, listener.ResponseCallNumber);
            Assert.IsNull(listVariableEvent.Value);
            listVariableEvent.Init();
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.IsNotNull(listVariableEvent.Value);
        }

        [Test]
        public void InitWithCapacity()
        {
            SimpleListVariableEvent listVariableEvent = ScriptableObject.CreateInstance<SimpleListVariableEvent>();
            SimpleGameEventListener listener = new SimpleGameEventListener();
            listVariableEvent.Register(listener);
            Assert.AreEqual(0, listener.ResponseCallNumber);
            Assert.IsNull(listVariableEvent.Value);
            listVariableEvent.Init(6);
            Assert.IsNotNull(listVariableEvent.Value);
            Assert.AreEqual(6, listVariableEvent.Value.Capacity);
            Assert.AreEqual(1, listener.ResponseCallNumber);
        }

        [Test]
        public void InitWithValues()
        {
            SimpleListVariableEvent listVariableEvent = ScriptableObject.CreateInstance<SimpleListVariableEvent>();
            SimpleGameEventListener listener = new SimpleGameEventListener();
            listVariableEvent.Register(listener);
            Assert.AreEqual(0, listener.ResponseCallNumber);
            Assert.IsNull(listVariableEvent.Value);
            listVariableEvent.Init(new[] {2, 4});
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.IsNotNull(listVariableEvent.Value);
            Assert.AreEqual(new[] {2, 4}, listVariableEvent.Value);
        }

        [Test]
        public void Add()
        {
            SimpleListVariableEvent listVariableEvent = ScriptableObject.CreateInstance<SimpleListVariableEvent>();
            SimpleGameEventListener listener = new SimpleGameEventListener();
            listVariableEvent.Value = new List<int>();
            listVariableEvent.Register(listener);
            Assert.AreEqual(0, listener.ResponseCallNumber);
            Assert.AreEqual(0, listVariableEvent.Value.Count);
            listVariableEvent.Add(3);
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual(1, listVariableEvent.Value.Count);
            Assert.AreEqual(3, listVariableEvent.Value[0]);
        }

        [Test]
        public void Insert()
        {
            SimpleListVariableEvent listVariableEvent = ScriptableObject.CreateInstance<SimpleListVariableEvent>();
            SimpleGameEventListener listener = new SimpleGameEventListener();
            listVariableEvent.Value = new List<int>(new[] {0, 0, 0, 0});
            listVariableEvent.Register(listener);
            Assert.AreEqual(0, listener.ResponseCallNumber);
            Assert.AreEqual(4, listVariableEvent.Value.Count);
            listVariableEvent.Insert(3, 1);
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual(5, listVariableEvent.Value.Count);
            Assert.AreEqual(new[] {0, 0, 0, 1, 0}, listVariableEvent.Value);
        }

        [Test]
        public void RemoveAt()
        {
            SimpleListVariableEvent listVariableEvent = ScriptableObject.CreateInstance<SimpleListVariableEvent>();
            SimpleGameEventListener listener = new SimpleGameEventListener();
            listVariableEvent.Value = new List<int>(new[] {1, 2, 3, 4});
            listVariableEvent.Register(listener);
            Assert.AreEqual(0, listener.ResponseCallNumber);
            Assert.AreEqual(4, listVariableEvent.Value.Count);
            listVariableEvent.RemoveAt(1);
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual(3, listVariableEvent.Value.Count);
            Assert.AreEqual(new[] {1, 3, 4}, listVariableEvent.Value);
        }

        [Test]
        public void Remove()
        {
            SimpleListVariableEvent listVariableEvent = ScriptableObject.CreateInstance<SimpleListVariableEvent>();
            SimpleGameEventListener listener = new SimpleGameEventListener();
            listVariableEvent.Value = new List<int>(new[] {1, 2, 3, 4});
            listVariableEvent.Register(listener);
            Assert.AreEqual(0, listener.ResponseCallNumber);
            Assert.AreEqual(4, listVariableEvent.Value.Count);
            listVariableEvent.Remove(3);
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual(3, listVariableEvent.Value.Count);
            Assert.AreEqual(new[] {1, 2, 4}, listVariableEvent.Value);
        }

        public void Clear()
        {
            SimpleListVariableEvent listVariableEvent = ScriptableObject.CreateInstance<SimpleListVariableEvent>();
            SimpleGameEventListener listener = new SimpleGameEventListener();
            listVariableEvent.Value = new List<int>(new[] {1, 2, 3, 4});
            listVariableEvent.Register(listener);
            Assert.AreEqual(0, listener.ResponseCallNumber);
            Assert.AreEqual(4, listVariableEvent.Value.Count);
            listVariableEvent.Clear();
            Assert.AreEqual(1, listener.ResponseCallNumber);
            Assert.AreEqual(0, listVariableEvent.Value.Count);
        }
    }
}
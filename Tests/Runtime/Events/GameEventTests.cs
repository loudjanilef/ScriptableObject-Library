using NUnit.Framework;
using SO;
using UnityEngine;

namespace Tests
{
    public class GameEventTests
    {
        [Test]
        public void GameEventNotifiesOnlyRegisteredListeners()
        {
            GameEvent gameEvent = ScriptableObject.CreateInstance<GameEvent>();
            SimpleGameEventListener listener = new SimpleGameEventListener();
            Assert.AreEqual(0, listener.ResponseCallNumber);

            gameEvent.Raise();
            Assert.AreEqual(0, listener.ResponseCallNumber);

            gameEvent.Register(listener);
            gameEvent.Raise();
            Assert.AreEqual(1, listener.ResponseCallNumber);

            gameEvent.UnRegister(listener);
            gameEvent.Raise();
            Assert.AreEqual(1, listener.ResponseCallNumber);
        }
    }
}
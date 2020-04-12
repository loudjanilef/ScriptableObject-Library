using SO;

namespace Tests
{
    public class SimpleGameEventListener : IGameEventListener
    {
        public int ResponseCallNumber;

        public void Response()
        {
            ResponseCallNumber++;
        }
    }
}
namespace Assignment
{
    public class TreasureChest
    {
        private string _material;
        private string _lockType;
        private string _lootQuality;
        private State _state;

        public enum State
        {
            Open,
            Closed,
            Locked
        }

        public TreasureChest()
        {
            _material = "Unknown";
            _lockType = "None";
            _lootQuality = "Unknown";
            _state = State.Closed;
        }

        public TreasureChest(string material, string lockType, string lootQuality)
        {
            _material = material;
            _lockType = lockType;
            _lootQuality = lootQuality;
            _state = State.Closed;
        }

        public State GetState()
        {
            return _state;
        }

        public State Manipulate(string action)
        {
            switch (action)
            {
                case "Open":
                    Open();
                    break;
                case "Close":
                    Close();
                    break;
                case "Lock":
                    Lock();
                    break;
                case "Unlock":
                    Unlock();
                    break;
            }

            return _state;
        }

        public void Open()
        {
            if (_state == State.Closed)
            {
                _state = State.Open;
            }
        }

        public void Close()
        {
            if (_state == State.Open)
            {
                _state = State.Closed;
            }
        }

        public void Lock()
        {
            if (_state == State.Closed)
            {
                _state = State.Locked;
            }
        }

        public void Unlock()
        {
            if (_state == State.Locked)
            {
                _state = State.Closed;
            }
        }
    }
}

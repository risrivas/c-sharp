using System;

namespace Exercises6
{
    public class StopWatch
    {
        private DateTime _start = DateTime.Now;
        private DateTime _stop = DateTime.Now;
        private bool _isStarted = false;

        public void Start()
        {
            if (!_isStarted)
            {
                _start = DateTime.Now;
                _isStarted = true;
            }
            else
            {
                throw new InvalidOperationException("Stopwatch is already started");
            }
        }

        public void Stop()
        {
            if (_isStarted)
            {
                _stop = DateTime.Now;
                _isStarted = false;
            }
            else
            {
                throw new InvalidOperationException("Stopwatch is NOT started");
            }

        }

        public TimeSpan Duration()
        {
            return _stop - _start;
        }
    }
}

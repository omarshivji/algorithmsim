using System.Threading;

namespace AlgorithmSimulator
{
    #region High Perfomance Timer
    /// <summary>
    /// A timer which works the same way as a stopwatch, 
    /// you will need to start and stop the timer and then
    /// get the duration that was elapsed between start and stop.
    /// </summary>
    public class CHPerfTimer
    {
        private long startTime, stopTime;
        private long freq;

        /// <summary>
        /// Constructor
        /// </summary>
        public CHPerfTimer()
        {
            startTime = 0;
            stopTime = 0;

            freq = System.Diagnostics.Stopwatch.Frequency;
            System.Diagnostics.Stopwatch.StartNew();
        }

        /// <summary>
        /// Starts the stopwatch
        /// </summary>
        public void Start()
        {
            Thread.Sleep(0);
            startTime = System.Diagnostics.Stopwatch.GetTimestamp();
        }

        /// <summary>
        /// Stops the stopwatch
        /// </summary>
        public void Stop()
        {
            stopTime = System.Diagnostics.Stopwatch.GetTimestamp();
        }

        /// <summary>
        /// Gets the duration counted up to now by the stopwatch
        /// </summary>
        /// <returns>Returns the duration in seconds</returns>
        public double GetTimePassed()
        {
            return (double)(((double)System.Diagnostics.Stopwatch.GetTimestamp() - (double)startTime) / (double)freq);
        }

        /// <summary>
        /// Gets the duration in seconds counted by the stopwatch.
        /// </summary>
        /// <returns>Returns the duration in seconds from start to stop.</returns>
        public double Duration
        {
            get
            {
                return (double)(((double)stopTime - (double)startTime) / (double)freq);
            }
        }
    }
    #endregion
}

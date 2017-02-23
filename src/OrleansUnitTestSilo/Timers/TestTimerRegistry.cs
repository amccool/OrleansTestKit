//namespace OrleansNonSiloTesting
//{
//    public class TestTimerRegistry : ITimerRegistry
//    {
//        private readonly List<TestTimer> _timers = new List<TestTimer>();
//
//        public readonly Mock<ITimerRegistry> Mock = new Mock<ITimerRegistry>();
//
//        public IDisposable RegisterTimer(Grain grain, Func<object, Task> asyncCallback, object state, TimeSpan dueTime,
//            TimeSpan period)
//        {
//            //Trigger the internal mock so it can be verified
//            Mock.Object.RegisterTimer(grain, asyncCallback, state, dueTime, period);
//
//            var timer = new TestTimer(asyncCallback, state);
//            _timers.Add(timer);
//
//            return timer;
//        }
//
//        public void FireAll()
//        {
//            foreach (var testTimer in _timers)
//            {
//                testTimer.Fire();
//            }
//        }
//    }
//}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanCodeDays.Delegate
{
    public partial class Production
    {
        private interface IKnowTime
        {
            DateTime Now { get; }
        }

        private class StandardKnowTime : IKnowTime
        {
            public DateTime Now
            {
                get { return System.DateTime.Now; }
            }
        }

        private IKnowTime DateTime = new StandardKnowTime();

        public bool DoSomeWork()
        {
            return DateTime.Now.Minute % 2 == 0;
        }
    }

    public partial class Production
    {
        [TestClass]
        public class MyTestClass
        {
            public class TestKnowTime : IKnowTime
            {
                public TestKnowTime(DateTime now)
                {
                    Now = now;
                }

                public DateTime Now { get; private set; }
            }

            [TestMethod]
            public void ShouldWorkOnEvenMinutes()
            {
                var sut = new Production
                {
                    DateTime = new TestKnowTime(new DateTime(2013, 9, 11, 11, 00, 15))
                };

                var result = sut.DoSomeWork();

                Assert.IsTrue(result);
            }

            [TestMethod]
            public void ShouldWorkOnOddMinutes()
            {
                var sut = new Production
                {
                    DateTime = new TestKnowTime(new DateTime(2013, 9, 11, 11, 25, 44))
                };

                var result = sut.DoSomeWork();

                Assert.IsFalse(result);
            }
        }
    }
}
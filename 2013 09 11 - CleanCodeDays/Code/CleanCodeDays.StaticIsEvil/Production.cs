using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanCodeDays.StaticIsEvil
{
    public partial class Production
    {
        private Func<DateTime> _now = () => DateTime.Now; 

        public bool DoSomeWork()
        {
            return _now().Minute % 2 == 0;
        }
    }

    public partial class Production
    {
        [TestClass]
        public class MyTestClass
        {
            [TestMethod]
            public void ShouldWorkOnEvenMinutes()
            {
                var sut = new Production
                    {
                        _now = () => new DateTime(2013, 9, 11, 11, 00, 15)
                    };

                var result = sut.DoSomeWork();

                Assert.IsTrue(result);
            }

            [TestMethod]
            public void ShouldWorkOnOddMinutes()
            {
                var sut = new Production
                    {
                        _now = () => new DateTime(2013, 9, 11, 11, 25, 44)
                    };

                var result = sut.DoSomeWork();

                Assert.IsFalse(result);
            }
        }
    }
}
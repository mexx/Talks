using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanCodeDays.Testorganisation
{
    public partial class Production
    {
        [TestClass]
        public class MyTestClass
        {
            [TestMethod]
            public void ShouldWorkOnEvenMinutes()
            {
                var sut = new Production();

                var result = sut.DoSomeWork();

                Assert.IsTrue(result);
            }

            [TestMethod]
            public void ShouldWorkOnOddMinutes()
            {
                var sut = new Production();

                var result = sut.DoSomeWork();

                Assert.IsFalse(result);
            }
        }
    }
}
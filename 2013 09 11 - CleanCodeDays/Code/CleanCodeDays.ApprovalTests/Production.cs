using System;
using ApprovalTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanCodeDays.ApprovalTests
{
    public partial class Production
    {
        public DateTime DoSomeWork(int year, int month)
        {
            return new DateTime(year, month,
                                (new DateTime(year, month, 1).DayOfWeek == DayOfWeek.Saturday ? 14 : 7) + 1 +
                                (DayOfWeek)(1 + ((month - 1) % 4)) -
                                new DateTime(year, month, 1).DayOfWeek);
        }
    }

    public partial class Production
    {
        [TestClass]
        public class DoSomeWorkTests
        {
            [TestMethod]
            public void CaptureCurrentBehaviour()
            {
                var sut = new Production();

                var result = new[]
                    {
                        sut.DoSomeWork(2013, 09),
                        sut.DoSomeWork(2013, 10),
                        sut.DoSomeWork(2013, 11),
                        sut.DoSomeWork(2013, 12),
                        sut.DoSomeWork(2014, 01),
                        sut.DoSomeWork(2014, 02),
                        sut.DoSomeWork(2014, 03),
                        sut.DoSomeWork(2014, 04),
                        sut.DoSomeWork(2014, 05),
                        sut.DoSomeWork(2014, 06),
                        sut.DoSomeWork(2014, 07),
                        sut.DoSomeWork(2014, 08),
                    };

                Approvals.VerifyAll(result, "dates");
            }
        }
    }
}
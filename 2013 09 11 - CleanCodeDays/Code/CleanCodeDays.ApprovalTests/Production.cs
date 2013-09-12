using System;

namespace CleanCodeDays.ApprovalTests
{
    public class Production
    {
        public DateTime DoSomeWork(int year, int month)
        {
            return new DateTime(year, month,
                                (new DateTime(year, month, 1).DayOfWeek == DayOfWeek.Saturday ? 14 : 7) + 1 +
                                (DayOfWeek)(1 + ((month - 1) % 4)) -
                                new DateTime(year, month, 1).DayOfWeek);
        }
    }
}
using System;

namespace CleanCodeDays.Testorganisation
{
    public class Production
    {
        public bool DoSomeWork()
        {
            return DateTime.Now.Minute % 2 == 0;
        }
    }
}
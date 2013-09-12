using System;

namespace CleanCodeDays.StaticIsEvil
{
    public class Production
    {
        public bool DoSomeWork()
        {
            return DateTime.Now.Minute % 2 == 0;
        }
    }
}
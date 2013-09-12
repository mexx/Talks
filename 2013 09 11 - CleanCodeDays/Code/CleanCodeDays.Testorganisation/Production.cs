using System;

namespace CleanCodeDays.Testorganisation
{
    public partial class Production
    {
        public bool DoSomeWork()
        {
            return DateTime.Now.Minute % 2 == 0;
        }
    }
}
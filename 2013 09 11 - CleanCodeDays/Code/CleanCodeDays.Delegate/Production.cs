﻿using System;

namespace CleanCodeDays.Delegate
{
    public class Production
    {
        public bool DoSomeWork()
        {
            return DateTime.Now.Minute % 2 == 0;
        }
    }
}
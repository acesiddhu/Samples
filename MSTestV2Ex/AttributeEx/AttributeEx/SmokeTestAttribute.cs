﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AttributeEx
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class SmokeTestAttribute : TestPropertyAttribute
    {
        public SmokeTestAttribute()
            : base("SmokeTest", null)
        {
        }
    }
}

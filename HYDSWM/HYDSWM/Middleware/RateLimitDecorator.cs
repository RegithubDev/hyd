﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEMOSWMCKC.Middleware
{
    [AttributeUsage(AttributeTargets.Method)]
    public class RateLimitDecorator :Attribute
    {
        public StrategyTypeEnum StrategyType { get; set; }
    }
}

﻿using Serilog.Events;
using System;
using System.Collections.Generic;

namespace Voidwell.Common.Logging
{
    public class LoggingOptions
    {
        public LogEventLevel MinLogLevel { get; set; } = LogEventLevel.Information;

        public List<Func<LogEvent, bool>> IgnoreRules { get; set; } = new List<Func<LogEvent, bool>>();

        public bool IncludeMicrosoftInformation { get; set; } = false;
    }
}

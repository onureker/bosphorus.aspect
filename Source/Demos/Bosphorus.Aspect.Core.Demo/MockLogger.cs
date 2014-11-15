﻿using System;
using Bosphorus.Aspect.Log;
using Bosphorus.Library.Logging.Core;

namespace Bosphorus.Aspect.Core.Demo
{
    public class MockLogger: ILogger<ServiceLog>
    {
        public void Log(ServiceLog serviceLog)
        {
            Console.WriteLine(serviceLog);
        }
    }
}

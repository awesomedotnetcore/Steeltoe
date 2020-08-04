﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

namespace Steeltoe.CircuitBreaker.Hystrix.Strategy.ExecutionHook
{
    public class HystrixCommandExecutionHookDefault : HystrixCommandExecutionHook
    {
        private static readonly HystrixCommandExecutionHookDefault Instance = new HystrixCommandExecutionHookDefault();

        private HystrixCommandExecutionHookDefault()
        {
        }

        public static HystrixCommandExecutionHook GetInstance()
        {
            return Instance;
        }
    }
}

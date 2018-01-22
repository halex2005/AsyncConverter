﻿using System;
using System.Threading.Tasks;

namespace AsyncConverter.Tests.Test.Data.FixReturnValueToTaskTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    public class Class
    {
        [DataTestMethod]
        public async Task Test()
        {
            await Task.Delay(1000).ConfigureAwait(false);
        }
    }
}

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    public class DataTestMethodAttribute : Attribute
    { }
}
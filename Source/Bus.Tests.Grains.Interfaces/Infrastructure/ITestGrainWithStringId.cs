﻿using System;
using System.Linq;
using System.Threading.Tasks;

namespace Orleans.Bus
{
    [ExtendedPrimaryKey]
    public interface ITestGrainWithStringId : IGrain, IGrainWithStringId
    {
        Task Foo();
    }
}

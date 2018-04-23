using System;
using System.Collections.Generic;

namespace Filer.Core
{
    public interface IExecutionContext
    {
        IList<string> Files { get; set; }
        IDictionary<string, string> Attributes { get; set; }
    }
}

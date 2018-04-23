using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Filer.Core
{
    public interface IFileAction
    {
      Task<IExecutionContext> DoAction(IExecutionContext context);

      IList<string> SupportedKeys { get; }
    }
}

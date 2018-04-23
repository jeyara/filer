using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Filer.Core
{
    public abstract class ActionBase
    {
        protected List<string> supportedKeys;

        protected bool IsValidContext(IExecutionContext context)
        {
            if (supportedKeys.Count() > 0)
            {
                var found = supportedKeys.Select(t => context.Attributes.Keys.Contains(t));

                if (supportedKeys.Count() != found.Count())
                    return false;
            }

            return true;
        }
    }
}

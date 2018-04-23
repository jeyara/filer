using Filer.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Filer.Actions.FindByExtension
{
    public class DoAction : ActionBase, IFileAction
    {
        public DoAction()
        {
            base.supportedKeys = new List<string>() {"RootFolder","Pattern"};
        }

        public IList<string> SupportedKeys => supportedKeys;

        Task<IExecutionContext> IFileAction.DoAction(IExecutionContext context)
        {
            if (!base.IsValidContext(context))
                throw new Exception("Required Attribute is missing");



            return Task.FromResult(context);
        }
    }
}

using Microsoft.FxCop.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FonreFxCopRule
{
    internal abstract class BaseFxCopRule : BaseIntrospectionRule
    {
        protected BaseFxCopRule(string ruleName)
            : base(ruleName, "FonreFxCopRule.FonreMetadata", typeof(BaseFxCopRule).Assembly)
        {
        }
    }
}

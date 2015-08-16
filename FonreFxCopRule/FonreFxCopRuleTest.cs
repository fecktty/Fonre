using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FonreFxCopRule
{
    internal class FonreFxCopRuleTest
    {
        internal void CheckNotNull()
        {
            string OK = null;
            string UpperOk = string.Empty;

            if (OK != null)
            {
                UpperOk = OK.ToString();
            }

            UpperOk = "RETURN";
        }
    }
}

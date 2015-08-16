using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FonreFxCopRule
{
    internal class LocalScopeStack
    {
        Stack<Dictionary<string, AnalysisResult>> stack = new Stack<Dictionary<string, AnalysisResult>>();

        /// <summary>
        /// push new block and scope
        /// </summary>
        public void PushScope()
        {
            Dictionary<string, AnalysisResult> scope = new Dictionary<string, AnalysisResult>();
            stack.Push(scope);
        }

        /// <summary>
        /// pop current scope and return to parent block
        /// </summary>
        public void PopScope()
        {
            stack.Pop();
        }

        public void SetVariable(string name, AnalysisResult value = AnalysisResult.Null)
        {
            var current = stack.Peek();
            if (current.ContainsKey(name))
            {
                current[name] = value;
            }
            else
            {
                current.Add(name, value);
            }
        }

        public AnalysisResult GetVariable(string name)
        {
            foreach (var scope in stack)
            {
                if (scope.ContainsKey(name))
                    return scope[name];
            }
            return AnalysisResult.Null;
        }
    }

    internal enum AnalysisResult
    {
        Null,
        NotNull,
        MaybeNull
    }
}

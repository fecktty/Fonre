using Microsoft.FxCop.Sdk;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace FonreFxCopRule
{
    internal sealed class FonreFxCopRule : BaseFxCopRule
    {
        private LocalScopeStack scope = new LocalScopeStack();

        public FonreFxCopRule()
            : base("FonreFxCopRule")
        {
        }

        public override Microsoft.FxCop.Sdk.TargetVisibilities TargetVisibility
        {
            get
            {
                return Microsoft.FxCop.Sdk.TargetVisibilities.All;
            }
        }

        public override Microsoft.FxCop.Sdk.ProblemCollection Check(Microsoft.FxCop.Sdk.Member member)
        {
            Method method = member as Method;
            if (method != null && method.Name.Name == "CheckNotNull")
            {
                VisitBlock(method.Body);
            }

            return this.Problems;
        }

        public override void VisitBlock(Block block)
        {
            if (block == null)
                return;

            //Debug.WriteLine("enter block");

            //
            VisitStatements(block.Statements);

            //Debug.WriteLine("exit block");
        }

        public override void VisitLocal(Local local)
        {
            base.VisitLocal(local);
        }

        public override void Visit(Node node)
        {
            Debug.WriteLine(node.NodeType.ToString());
            base.Visit(node);
        }

        public override void VisitAssignmentStatement(AssignmentStatement assignment)
        {
            base.VisitAssignmentStatement(assignment);
        }

        public override void VisitBranch(Branch branch)
        {
            base.VisitBranch(branch);
        }

        public override void VisitMethodCall(MethodCall call)
        {
            base.VisitMethodCall(call);
        }
    }
}

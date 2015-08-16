using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FonreFxCopRule
{
    internal class LocalScopeTree
    {
        private readonly ScopeTreeNode root;
        private ScopeTreeNode current;

        public LocalScopeTree()
        {
            root = new ScopeTreeNode();
            current = root;
        }

        public void CreateScopeTree()
        {
            ScopeTreeNode node = new ScopeTreeNode();
            node.Parent = current;
            node.SiblingIndex = current.ChildrenNode.Count;
            current.ChildrenNode.Add(node);

            current = node;
        }

        public void BackScopeTree()
        {
            if (current.Parent != null)
                current = current.Parent;
        }
    }

    internal class ScopeTreeNode
    {
        private List<ScopeTreeNode> childrenNode = new List<ScopeTreeNode>();
        public List<ScopeTreeNode> ChildrenNode
        {
            get { return childrenNode; }
        }

        public ScopeTreeNode Parent { get; set; }

        public int SiblingIndex { get; set; }

        public ScopeNodeDetail NodeDetails { get; set; }
    }

    internal class ScopeNodeDetail
    {

    }
}

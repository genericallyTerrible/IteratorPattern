using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class PreorderIterator<T> : AbstractTreeIterator<T>
    {
        private int exploredNodes;

        public PreorderIterator(ConcreteTree<T> tree) : base(tree)
        {
            First();
        }

        public override T First()
        {
            exploredNodes = 1;
            return tree.Nodes[0];
        }

        public override bool IsDone()
        {
            return exploredNodes == tree.Nodes.Count;
        }

        public override T Next()
        {
            if (!IsDone())
            {
                if (HasLeftChild)
                {
                    TraverseToLeftChild();
                }
                else
                {
                    CheckAndTraverseToParent();
                }

                exploredNodes++;
                return CurrentItem();
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        private void CheckAndTraverseToParent()
        {
            if (IsLeftChild)
            {
                TraverseToParent();
                if (HasRightChild)
                {
                    TraverseToRightChild();
                }
                else
                {
                    CheckAndTraverseToParent();
                }
            }
            else
            {
                TraverseToParent();
                CheckAndTraverseToParent();
            }
        }
    }
}

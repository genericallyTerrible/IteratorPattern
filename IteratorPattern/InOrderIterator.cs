using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class InorderIterator<T> : AbstractTreeIterator<T>
    {

        public InorderIterator(ConcreteTree<T> tree) : base(tree)
        {
            First();
        }

        public override void First()
        {
            exploredNodes = 0;

            if (tree.Nodes.Count > 0)
            {
                int firstIndex = (int)(PreviousPowerOf2((uint)tree.Nodes.Count) - 1);
                index = firstIndex;
            }
        }

        public override void Next()
        {
            if (!IsDone())
            {
                if (IsLeaf && HasParent)
                {
                    CheckAndTraverseToParent();
                }
                else if (HasRightChild)
                {
                    TraverseToRightChild();
                    while (HasLeftChild)
                    {
                        TraverseToLeftChild();
                    }
                }
                else if (HasParent)
                {
                    CheckAndTraverseToParent();
                }

                exploredNodes++;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        private void CheckAndTraverseToParent()
        {
            if (HasParent)
            {
                if (IsLeftChild)
                {
                    TraverseToParent();
                }
                else
                {
                    TraverseToParent();
                    CheckAndTraverseToParent();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class PostorderIterator<T> : AbstractTreeIterator<T>
    {

        public PostorderIterator(ConcreteTree<T> tree) : base(tree)
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
                if (IsRightChild)
                {
                    TraverseToParent();
                }
                else
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
                TraverseToParent();
                if (HasRightChild)
                {
                    TraverseToRightChild();
                    while (HasLeftChild)
                    {
                        TraverseToLeftChild();
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class PreorderIterator<T> : AbstractTreeIterator<T>
    {

        public PreorderIterator(ConcreteTree<T> tree) : base(tree)
        {
            First();
        }

        public override void First()
        {
            exploredNodes = 0;
        }

        public override void Next()
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
}

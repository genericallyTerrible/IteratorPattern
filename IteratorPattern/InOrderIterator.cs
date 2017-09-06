using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class InorderIterator<T> : AbstractTreeIterator<T>
    {
        private int exploredNodes;

        public InorderIterator(ConcreteTree<T> tree) : base(tree)
        {
            First();
        }

        public override T First()
        {
            exploredNodes = 1;
            int firstIndex = (int)(PreviousPowerOf2((uint)tree.Nodes.Count) - 1);
            index = firstIndex;
            return tree.Nodes[index];
        }

        public override bool IsDone()
        {
            return exploredNodes == tree.Nodes.Count;
        }

        public override T Next()
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
            }
            else
            {
                TraverseToParent();
                CheckAndTraverseToParent();
            }
        }
    }
}

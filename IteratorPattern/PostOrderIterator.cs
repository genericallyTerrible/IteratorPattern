using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class PostorderIterator<T> : AbstractTreeIterator<T>
    {

        private int exploredNodes;

        public PostorderIterator(ConcreteTree<T> tree) : base(tree)
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
                if (IsRightChild)
                {
                    TraverseToParent();
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

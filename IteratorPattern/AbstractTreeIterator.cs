using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public abstract class AbstractTreeIterator<T> : AbstractIterator<T>
    {
        private string ParentOutOfBoundsError = "Next time check if the current node has a parent with HasParent";
        private string LeftChildOutOfBoundsError = "Next time check if the current node has a left child with HasLeftChild";
        private string RightChildOutOfBoundsError = "Next time check if the current node has a right child with HasRightChild";

        protected ConcreteTree<T> tree;

        protected int index = 0;
        private int ParentIndex => (int)(Math.Ceiling((double)index / 2) - 1);
        private int LeftChildIndex => ((index * 2) + 1);
        private int RightChildIndex => ((index * 2) + 2);
        protected bool HasParent => ParentIndex >= 0;
        protected bool HasLeftChild => LeftChildIndex < tree.Nodes.Count;
        protected bool HasRightChild => RightChildIndex < tree.Nodes.Count;
        protected bool IsLeftChild => (HasParent && (index % 2) != 0);
        protected bool IsRightChild => (HasParent && (index % 2) == 0);
        protected bool IsRoot => index == 0;
        protected bool IsLeaf => !(HasLeftChild || HasRightChild);

        protected T Parent
        {
            get
            {
                if (HasParent)
                {
                    return tree.Nodes[ParentIndex];
                }
                else
                {
                    throw new IndexOutOfRangeException(ParentOutOfBoundsError);
                }
            }
        }

        protected T LeftChild
        {
            get
            {
                if (HasLeftChild)
                {
                    return tree.Nodes[LeftChildIndex];
                }
                else
                {
                    throw new IndexOutOfRangeException(LeftChildOutOfBoundsError);
                }
            }
        }

        protected T RightChild
        {
            get
            {
                if (HasRightChild)
                {
                    return tree.Nodes[RightChildIndex];
                }
                else
                {
                    throw new IndexOutOfRangeException(RightChildOutOfBoundsError);
                }
            }
        }


        public AbstractTreeIterator(ConcreteTree<T> tree)
        {
            this.tree = tree;
        }

        public override T CurrentItem()
        {
            return tree.Nodes[index];
        }

        protected void TraverseToParent()
        {
            if (HasParent)
            {
                index = ParentIndex;
            }
            else
            {
                throw new IndexOutOfRangeException(ParentOutOfBoundsError);
            }
        }

        protected void TraverseToLeftChild()
        {
            if (HasLeftChild)
            {
                index = LeftChildIndex;
            }
            else
            {
                throw new IndexOutOfRangeException(LeftChildOutOfBoundsError);
            }
        }

        protected void TraverseToRightChild()
        {
            if (HasRightChild)
            {
                index = RightChildIndex;
            }
            else
            {
                throw new IndexOutOfRangeException(RightChildOutOfBoundsError);
            }
        }

        protected uint PreviousPowerOf2(uint x)
        {
            x = x | (x >> 1);
            x = x | (x >> 2);
            x = x | (x >> 4);
            x = x | (x >> 8);
            x = x | (x >> 16);
            return x - (x >> 1);
        }
    }
}

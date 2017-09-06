using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class ConcreteTree<T> : AbstractTree<T>
    {
        private List<T> nodes = new List<T>();
        public IList<T> Nodes => nodes.AsReadOnly();

        public void Push(T node)
        {
            nodes.Add(node);
        }

        public T Pop()
        {
            T node = nodes.Last();
            nodes.RemoveAt(nodes.Count - 1);
            return node;
        }

        public override InorderIterator<T> CreateInorderIterator()
        {
            return new InorderIterator<T>(this);
        }

        public override PreorderIterator<T> CreatePreorderIterator()
        {
            return new PreorderIterator<T>(this);
        }

        public override PostorderIterator<T> CreatePostorderIterator()
        {
            return new PostorderIterator<T>(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public abstract class AbstractTree<T>
    {
        public abstract InorderIterator<T> CreateInorderIterator();
        public abstract PreorderIterator<T> CreatePreorderIterator();
        public abstract PostorderIterator<T> CreatePostorderIterator();
    }
}

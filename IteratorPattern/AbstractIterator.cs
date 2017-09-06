using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public abstract class AbstractIterator<T>
    {
        public abstract T First();
        public abstract T Next();
        public abstract bool IsDone();
        public abstract T CurrentItem();
    }
}

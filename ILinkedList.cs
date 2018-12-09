using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedL
{
    interface ILinkedList<T>
    {
        void Add(T data);
        void RemoveFirst();
        void RemoveLast();
    }
}

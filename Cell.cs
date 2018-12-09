using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedL
{
    class Cell <T>
    {
        public T Data { get; set; }
        public Cell<T> NextCell { get; set; }
        public Cell<T> PreviousCell { get; set; }

        public Cell(T data)
        {
            Data = data;
        }
    }
}

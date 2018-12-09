using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedL
{
    class LinkedList<T> : ILinkedList<T> where T : Person 
    {
        Cell<T> Head { get; set; }
        Cell<T> Tail { get; set; }
        public int Count { get; set; }
        int IdForT { get; set; }

        public LinkedList()
        {
            Count = 0;
        }


        public void Add(T data)
        {
            Cell<T> cell = new Cell<T>(data);

            if (Head == null)
            {
                Head = cell;
            }
            else
            {
                Tail.NextCell = cell;
                cell.PreviousCell = Tail;
            }
            cell.Data.IdPerson = IdForT++;
            Tail = cell;
            Count++;
        }

        public void RemoveFirst()
        {
            Head = Head.NextCell;
            Head.PreviousCell = null;
            Count--;
        }

        public void RemoveLast()
        {
            Tail = Tail.PreviousCell;
            Tail.NextCell = null;
            Count--;
        }

        public void LinkedListInfo()
        {
            var variable = Head;
            PrintConsole(variable.Data.ToString());
            variable = Head.NextCell;
            for (int i = 1; i < Count; i++)
            {
                PrintConsole(variable.Data.ToString());
                variable = variable.NextCell;
            }
        }

        void PrintConsole(string data)
        {
            Console.WriteLine(data);
        }

        
    }
}

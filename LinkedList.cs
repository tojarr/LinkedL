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
            if (Tail.PreviousCell == null)
                Head = null;
            Tail = Tail.PreviousCell;
            if (Tail != null)
                Tail.NextCell = null;
            Count--;
        }

        public void LinkedListInfo()
        {
            if (Head != null)
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
            else
                PrintConsole("Linked List does not exist");
        }

        void PrintConsole(string data)
        {
            Console.WriteLine(data);
        }

        public void RemoveAt()
        {
            if (Count > 0)
            {
                int number = 0;
                bool b = true;
                while (b)
                {
                    Console.WriteLine("Enter index(0 - {0}):", (Count - 1));
                    string str = Console.ReadLine();
                    bool success = Int32.TryParse(str, out number);
                    if (success)
                    {
                        if (number >= 0 && number <= Count - 1)
                        {
                            b = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Enter index(0 - {0}):", (Count - 1));
                    }
                }

                if (number == 0)
                {
                    RemoveFirst();
                }
                else if (number == Count - 1)
                {
                    RemoveLast();
                }
                else
                {
                    var variable = Head;

                    for (int i = 0; i < Count; i++)
                    {
                        var variableNext = Head.NextCell;
                        if(i + 1 == number)
                        {
                            variable.NextCell = variableNext.NextCell;
                            variableNext.NextCell.PreviousCell = variableNext.PreviousCell;
                            Count--;
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Linked List does not exist");
            }
        }
    }
}

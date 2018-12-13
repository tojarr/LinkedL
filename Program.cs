using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedL
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Student> linkedList = new LinkedList<Student>();
            linkedList.Add(new Student("Student1", 20));
            linkedList.Add(new Student("Student2", 24));
            linkedList.Add(new Student("Student3", 25));
            linkedList.Add(new Student("Student4", 23));
            linkedList.Add(new Student("Student5", 21));
            linkedList.Add(new Student("Student6", 22));
            linkedList.LinkedListInfo();
            Console.WriteLine();

            linkedList.RemoveFirst();
            linkedList.LinkedListInfo();
            Console.WriteLine();

            linkedList.RemoveLast();
            linkedList.LinkedListInfo();
            Console.WriteLine();

            linkedList.Add(new Student("Student7", 22));
            linkedList.LinkedListInfo();
            Console.WriteLine();

            linkedList.RemoveLast();
            linkedList.LinkedListInfo();

            linkedList.RemoveAt();
            linkedList.LinkedListInfo();

            Console.ReadKey();
        }
    }
}

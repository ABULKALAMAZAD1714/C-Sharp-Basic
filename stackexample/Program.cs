using System;
using System.Collections;

namespace stackexample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack aStack = new Stack();
            //aStack.Push(123);
            //aStack.Push("kalam");
            //aStack.Push('k');
            //foreach (var data in aStack)
            //{
            //    Console.WriteLine(data);

            //}

            //aStack.Pop();
            //aStack.Pop();


            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //foreach (var data in aStack)
            //{
            //    Console.WriteLine(data);

            //}
            Stack aStack = new Stack();
            aStack.Push("hellow");
            aStack.Push(123);
            aStack.Push(1.23);
            aStack.Push("kalam");

            foreach (var data in aStack)
            {
                Console.WriteLine(data);

            }
            aStack.Pop();
            aStack.Pop();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            foreach (var data in aStack)
            {
                Console.WriteLine(data);

            }

        }
    }
}

using System;
using System.Collections.Generic;
namespace testalgorithm
{


    class Algorithms
    {
        
        
        static void Main(string[] args)
        {

            Stack<String> stack = new Stack<string>();

            Console.WriteLine("Start Main " );
            stack.Push("Main");
            stack.Push("ResponseBuilder");
            stack.Push("CallExternalService");
            Console.WriteLine("End "+stack.Pop());
            stack.Push("ParseExternalDate");
            Console.WriteLine("End " + stack.Pop());
            Console.WriteLine("End " + stack.Pop());
            Console.WriteLine("End " + stack.Pop());

            //stack.Peek()
            //stack.TryPeek()
            string itemNext;
            Console.WriteLine(stack.TryPeek(out itemNext));

        }
    }
}

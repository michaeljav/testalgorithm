using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testalgorithm
{

    
    class Algorithms
    {
        
        static void Main(string[] args)
        {


            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(8);
            queue.Enqueue(20);
            queue.Enqueue(23);

            int removedItem = queue.Dequeue();
            Console.WriteLine(removedItem);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());

            int current;
            while (queue.TryDequeue(out current))
            {
                Console.WriteLine(current);

            }

            
            




        }
    }
}

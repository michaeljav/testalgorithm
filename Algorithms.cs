using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testalgorithm
{

    
    class Algorithms
    {
        
        static void printBinary(int n)
        {
            if (n <= 0)
            {
                return;
            }
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            for (int i = 0; i < n; i++)
            {
                int current = queue.Dequeue();
                Console.WriteLine(current);
                queue.Enqueue(current * 10);
                queue.Enqueue(current * 10 + 1);

            }
            Console.WriteLine();

        }
        static void Main(string[] args)
        {


            printBinary(5);
            printBinary(-2);
            printBinary(0);
            printBinary(2);
            printBinary(8);



            Console.Read();




        }
    }
}

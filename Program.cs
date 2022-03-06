using System;
using System.Diagnostics;

namespace testalgorithm
{
    class Program
    {

      static  Stopwatch stopWatch = new Stopwatch();
//        stopWatch.Start();
//for (.......)
//{
//}
//stopWatch.Stop();
//textbox1.Text = stopWatch.ElapsedMilliseconds.ToString();
        static int findMaximum(int a, int b, int c) {
            stopWatch.Start();
            if (a > b)
            {
                if (a > c  || a == c)
                {
                    return a;
                }
            }
            if (b > c)
            {
                if (b > a || a == b)
                {
                    return b;
                }
            }

            stopWatch.Stop();
            Console.WriteLine($"MilliSecond:  {stopWatch.ElapsedMilliseconds.ToString()}");
            //Console.WriteLine($"MilliSecond:  {stopWatch.ElapsedTicks.ToString()}");
            return c;
        }

        static int findMaximum2(int a, int b, int c)
        {
            stopWatch.Start();
            int max = a;

            if(b > max )
            {
                max = b;
            }

            if(c > max)
            {
                max = c;
            }

            stopWatch.Stop();
            Console.WriteLine($"MilliSecond: {stopWatch.ElapsedMilliseconds.ToString()}");
            //Console.WriteLine($"MilliSecond:  {stopWatch.ElapsedTicks.ToString()}");
            return max;
        }
        static void Main(string[] args)
        {

            Console.WriteLine(findMaximum(1, 2, 3));
            Console.WriteLine(findMaximum(8, 8, 1));
            Console.WriteLine(findMaximum(3, 2, 3));
            Console.WriteLine(findMaximum(1, 1, 9));
            Console.WriteLine(findMaximum(1, 9, 9));

            Console.WriteLine(findMaximum2(1, 2, 3));
            Console.WriteLine(findMaximum2(8, 8, 1));
            Console.WriteLine(findMaximum2(3, 2, 3));
            Console.WriteLine(findMaximum2(1, 1, 9));
            Console.WriteLine(findMaximum2(1, 9, 9));
        }

      
    }
}

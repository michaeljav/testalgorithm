using System;
using System.Diagnostics;
using System.Text;

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
      
        static String  Reverse(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            StringBuilder reversed = new StringBuilder(input.Length);

            for (int i = input.Length - 1 ; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }
            return reversed.ToString();

        }

        static String  Reverse2(String input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            char[] arr = input.ToCharArray();
             Array.Reverse(arr);
            return new string(arr);
        }


        static void Main(string[] args)
        {
         
            Console.WriteLine(Reverse("Hello World, My Name is  Michael"));
            Console.WriteLine(Reverse(null));
            Console.WriteLine(Reverse(""));
            Console.WriteLine(Reverse("hello"));
            Console.WriteLine(Reverse2("hello"));
            
            
            
            

        }

      
    }
}

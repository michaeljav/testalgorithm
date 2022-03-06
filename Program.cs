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
      
        static string ReverseEachWord(String input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            StringBuilder result = new StringBuilder();
            String[] arr = input.Split(" ");
            for (int i = 0; i < arr.Length; i++)
            {
                result.Append(Reverse2(arr[i]));
                if (i != arr.Length - 1)
                {
                    result.Append(" ");
                }

            }
            return result.ToString();
        }

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


            //Console.WriteLine(Reverse("Hello World"));
            //Console.WriteLine(Reverse(""));
            //Console.WriteLine(Reverse("hello"));
            //Console.WriteLine(Reverse("tacos"));
            //Console.WriteLine(Reverse("Hi!"));
            //Console.WriteLine(Reverse(null));

            //Console.WriteLine(Reverse2("Hello World"));
            //Console.WriteLine(Reverse2(""));
            //Console.WriteLine(Reverse2("hello"));
            //Console.WriteLine(Reverse2("tacos"));
            //Console.WriteLine(Reverse2("Hi!"));
            //Console.WriteLine(Reverse2(null));


            //Console.WriteLine(Reverse2("Taylor is a great worker"));
            //Console.WriteLine(Reverse2(null));
            //Console.WriteLine(Reverse2("racer racecar madam"));
            //Console.WriteLine(Reverse2("what can I do today"));
            //Console.WriteLine(Reverse2(" "));


            Console.WriteLine(("++++++++++++++++++++++++ReverseEachWord"));
            Console.WriteLine(ReverseEachWord("Taylor is a great worker"));
            Console.WriteLine(ReverseEachWord(null));
            Console.WriteLine(ReverseEachWord("racer racecar madam"));
            Console.WriteLine(ReverseEachWord("what can I do today"));
            Console.WriteLine(ReverseEachWord(" "));





        }

      
    }
}

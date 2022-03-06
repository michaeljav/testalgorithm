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
      
        static Boolean IsAtEvenIndex(string s, char item)
        {
            if (String.IsNullOrEmpty(s))
            {
                return false;
            }

            for (int i = 0; i < s.Length / 2 + 1; i += 2)
            {
                if (s[i] == item)
                {
                    return true;
                }

            }
            return false;
        }

        static void Main(string[] args)
        {
            string input = "Hello";
            Console.WriteLine(IsAtEvenIndex(input, 'L'));
            Console.WriteLine(IsAtEvenIndex(input, 'o'));
            Console.WriteLine(IsAtEvenIndex(input, 'H'));
            Console.WriteLine(IsAtEvenIndex("", 'H'));
            Console.WriteLine(IsAtEvenIndex(null, 'H'));
            
            
            

        }

      
    }
}

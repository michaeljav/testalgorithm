using System;
using System.Diagnostics;
using System.Linq;

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
        static Boolean IsUppercase(string s)
        {
            return s.All(char.IsUpper);
        }

        static Boolean IsLowercase(string s)
        {
            return s.All(char.IsLower);
        }

        static Boolean isPasswordComplex(string s)
        {
            return s.Any(char.IsUpper)
                && s.Any(char.IsLower)
                && s.Any(char.IsDigit);


        }

        static void Main(string[] args)
        {

            //Console.WriteLine(IsUppercase("HE"));
            //Console.WriteLine(IsUppercase("he"));

            //Console.WriteLine(IsLowercase("HE"));
            //Console.WriteLine(IsLowercase("he"));
            
            
            Console.WriteLine(isPasswordComplex("Hell0"));
            Console.WriteLine(isPasswordComplex("Hello"));
            

        }

      
    }
}

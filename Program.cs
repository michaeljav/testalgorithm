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
      
        static string normalizeString(String input)
        {
            return input.ToLower().Trim().Replace(",", "");
           //string lowercased= input.ToLower();
           // string trimmed = lowercased.Trim();
           // return trimmed.Replace(",", "");            
        }

        static void Main(string[] args)
        {

            //Console.WriteLine(IsUppercase("HE"));
            //Console.WriteLine(IsUppercase("he"));

            //Console.WriteLine(IsLowercase("HE"));
            //Console.WriteLine(IsLowercase("he"));
            
            
            Console.WriteLine(normalizeString(" Hello There, BUDDY     "));
            
            

        }

      
    }
}

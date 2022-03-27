using System;
using System.Collections.Generic;
namespace testalgorithm
{


    class Algorithms
    {
        
      static List<int> findMissingElement(int[] first, int[] second)
        {
            List<int> missingElements = new List<int>();
            HashSet<int> secondArrayItems = new HashSet<int>();

            foreach (int item in second)
            {
                secondArrayItems.Add(item);
            }

            foreach (int item in first)
            {
                if (!secondArrayItems.Contains(item))
                {
                    missingElements.Add(item);
                }
            }

            return missingElements;
        }

        static void Main(string[] args)
        {

            findMissingElement(new int[] { 1, 2, 3, 4 }, new int[] { 2, 4 }).ForEach(Console.WriteLine);
        }
    }
}

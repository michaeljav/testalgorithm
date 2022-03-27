using System;
using System.Collections.Generic;
namespace testalgorithm
{


    class Algorithms
    {
        
     static void displayFreqOfEachElement(int[] arr)
        {
            Dictionary<int, int> freqDictionary = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (freqDictionary.ContainsKey(arr[i]))
                {
                    freqDictionary[arr[i]]++;
                }
                else
                {
                    freqDictionary[arr[i]] = 1;
                }

            }

            foreach (KeyValuePair<int, int> x in freqDictionary)
            {
                Console.WriteLine(x.Key + " --> " + x.Value);
            }
        }

        static void Main(string[] args)
        {

            displayFreqOfEachElement(new int[] { 1, 2, 3,4,4 ,8,8,4 });
        }
    }
}

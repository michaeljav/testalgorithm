using System;
using System.Collections;
using System.Diagnostics;
using System.Text;

namespace testalgorithm
{
    class Program
    {
     
        static void RotateOnPositionInPlace(int[] item)
        {
            int temp = item[0];
            
            for (int i = 0; i < item.Length; i++)
            {
                //last item
                if (i < item.Length -1)
                {
                    item[i] = item[i + 1];
                }
                else
                {
                    item[i] = temp;
                }
                
            }
        }

        static void RotateOnPositionInPlaceToRightPlace(int[] item)
        {

            int temp = item[item.Length - 1];

            for (int i = 0; i < item.Length -1; i++)
            //for (int i = 0; i < item.Length; i++)
            {

                


                if (i == 0)
                {
                    int curr = item[i];
                    item[i] = temp;
                    item[item.Length - 1] = curr;
                }
                else
                {
                    int current = item[i];
                    item[i] = item[item.Length - 1];
                    item[item.Length - 1] = current;

                }


            }
        }

        static void Main(string[] args)
        {
            
            int[] arr = { 1,2,3,4,5,6 };

           RotateOnPositionInPlace(arr);
            Array.ForEach(arr, Console.WriteLine);
            Console.WriteLine("TEST+++++");
            RotateOnPositionInPlaceToRightPlace(arr);            
            Array.ForEach(arr, Console.WriteLine);
        }

      
    }
}

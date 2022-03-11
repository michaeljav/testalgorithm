using System;
using System.Collections;
using System.Diagnostics;
using System.Text;

namespace testalgorithm
{
    class Program
    {
     
        /*
         
         MADE BY ME
         */
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


        /*
         * 
         * 
         * 
         * 
         * SOLUTION FROM THE COURSE
         
         
         
         */
        static void RotateArrayLeft(int[] input)
        {
            int temp = input[0];
            for (int i = 0; i < input.Length -1; i++)
            {
                input[i] = input[i + 1]; 
            }
            //output [2,3,4,5,6,6];

            input[input.Length - 1] = temp;
            //output [2,3,4,5,1]

        }

        static void RotateArrayRight(int[] input)
        {
            //index   0 1 2 3 4 5
            //output [2,3,4,5,6,1]

            int temp = input[input.Length - 1];

            for (int i = input.Length - 1; i > 0; i--)
            {
                input[i] = input[i -1 ];
            }

            input[0] = temp;
        }

        static void Main(string[] args)
        {
            
            int[] arr = { 1,2,3,4,5,6 };

            //RotateOnPositionInPlace(arr);
            // Array.ForEach(arr, Console.WriteLine);
            // Console.WriteLine("TEST+++++");
            // RotateOnPositionInPlaceToRightPlace(arr);
            
            
            
            //IMPROVEMENT BY THE COURSE

            RotateArrayLeft(arr);
            RotateArrayRight(arr);            
            Array.ForEach(arr, Console.WriteLine);
        }

      
    }
}

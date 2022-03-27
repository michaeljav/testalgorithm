using System;
using System.Collections.Generic;
namespace testalgorithm
{


    class Algorithms
    {
        
        static bool hasMatchingParentheses(string s)
        {
            if (s.Length <= 0)
            {
                return false;
            }

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                char current = s[i];

                if (current == '(')
                {
                    stack.Push(current);
                    continue;
                }

                if (current == ')')
                {
                    if (stack.Count > 0)
                    {
                    stack.Pop();
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            return stack.Count == 0;


        }

        static bool hasMatchingParentheses2(string s)
        {
            if (s.Length <= 0)
            {
                return false;
            }

            int machingSymbleTracker = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char current = s[i];

                if (current == '(')
                {
                    machingSymbleTracker++;
                    continue;
                }

                if (current == ')')
                {
                    if (machingSymbleTracker > 0)
                    {
                        machingSymbleTracker--;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            return machingSymbleTracker == 0;


        }

        static void Main(string[] args)
        {


            //Console.WriteLine(hasMatchingParentheses(""));
            //Console.WriteLine(hasMatchingParentheses("((hello()))"));
            //Console.WriteLine(hasMatchingParentheses("()(hello())"));
            //Console.WriteLine(hasMatchingParentheses("((hello))"));
            //Console.WriteLine(hasMatchingParentheses("(hello)"));

            //Console.WriteLine();

            //Console.WriteLine(hasMatchingParentheses("(hello("));
            //Console.WriteLine(hasMatchingParentheses(")hello)"));
            //Console.WriteLine(hasMatchingParentheses(")hello("));
            //Console.WriteLine(hasMatchingParentheses("hello(("));
            //Console.WriteLine(hasMatchingParentheses("(hello"));
            //Console.WriteLine(hasMatchingParentheses("((hello)"));


            Console.WriteLine(hasMatchingParentheses2("((hello()))"));
            Console.WriteLine(hasMatchingParentheses2("()(hello())"));
            Console.WriteLine(hasMatchingParentheses2("((hello))"));
            Console.WriteLine(hasMatchingParentheses2("(hello)"));

            Console.WriteLine();

            Console.WriteLine(hasMatchingParentheses2("(hello("));
            Console.WriteLine(hasMatchingParentheses2(")hello)"));
            Console.WriteLine(hasMatchingParentheses2(")hello("));
            Console.WriteLine(hasMatchingParentheses2("hello(("));
            Console.WriteLine(hasMatchingParentheses2("(hello"));
            Console.WriteLine(hasMatchingParentheses2("((hello)"));

        }
    }
}

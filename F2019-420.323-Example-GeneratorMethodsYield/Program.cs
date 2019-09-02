using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace F2019_420._323_Example_GeneratorMethodsYield
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Notice the use of "GenerateNumbers" here.
            foreach (int a in GenerateNumbers())
            {
                Console.WriteLine(a);
            }

            // Convert the generated numbers to a concrete list.
            List<int> listOfNumbers = GenerateNumbers().ToList();
            Console.WriteLine("3rd element from the list that GenerateNumbers made ->" + listOfNumbers[2]);

            // Send an array to get a new list with each element multiplied by itself.
            int[] anotherList = { 2, 4, 6, 8 };

            foreach (int b in MultiplyListElementsByItself(anotherList))
            {
                Console.WriteLine("New value: " + b);
            }


        }

        /// <summary>
        /// Returns 3 numbers as a Enumerable collection.
        /// </summary>
        /// <returns></returns>
        static IEnumerable<int> GenerateNumbers()
        {
            yield return 22;

            yield return 55;

            yield return 75;
        }

        /// <summary>
        /// Takes in an array, and returns the values squared one at a time.
        /// </summary>
        /// <param name="mylist"></param>
        /// <returns></returns>
        static IEnumerable MultiplyListElementsByItself(int[] mylist)
        {
            foreach (int a in mylist)
            {
                yield return a * a;
            }
        }
    }
}

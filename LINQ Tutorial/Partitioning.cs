using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ConsoleApp2
{
    class Partitioning
    {
        DataStructures dataStructures = new DataStructures();
        public void Lecture1()
        {
            int[] numbers = dataStructures.Numbers;
            /*
             * 1. But that's not all!
             * LINQ can also be used to partition our collections.
             * We can select the first # of values, or skip 'em.
             * We can even use LambdaExpressions to select a specific #
             * of values based on rules we specify.
             * 
             * If you don't get labmda expressions, now would be a good time
             * to check them out!
             */
            var firstNumbers = numbers.Take(4);
            var lastNumbers = numbers.TakeLast(4);
            var skipNumbers = numbers.Skip(4);
            /*
             * 2. The 1st example above will take the first 4 numbers, 
             * they don't have the be in order necessarily.
             * 
             * 3. The second example selects the last 4 numbers.
             * 
             * 4. The third example will skip the first 4, and select
             * the remaining (numbers.Length - 1) - 4 numbers remaining.
             * Q: Why the -1?
             * A:   numbers.Length returns the length, but an array is
             *      0-indexed, so we reduce this value by 1.      
             */
            var numbersLargerThan3 = numbers.TakeWhile(n => n > 3);
            /*
             * 5. We have `TakeWhile(lambdaExpression)` and 
             * `SkipWhile(lambdaExpression)`, both of these functions will
             * perform their original duties but with an exception.
             * 
             * In our above example we will select numbers until our result 
             * is false.
             * 
             * If we were to write: `.SkipWhile(n => n > 3); we will skip
             * over all the numbers that meet the criteria, and select
             * the rest.
             * 
             * These functions are a form of "Grouping" which is related to
             * "filtering"
             */
        }

        public bool Test1()
        {
            // Numbers = new int[] {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            int[] numbers = dataStructures.Numbers;
            // Place your solution below.
            var smallerThan9 = numbers.Take(8);
            // Place your solution above.
            return !smallerThan9.Contains(9);
        }

        public bool Test2()
        {
            // Numbers = new int[] {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            int[] numbers = dataStructures.Numbers;
            // Place your solution below.
            var skipSmallerThan5 = numbers.Take(2);
            // Place your solution above.
            return !skipSmallerThan5.Contains(5) && skipSmallerThan5.Contains(4);
        }
    }
    #region ANSWERS
    /************************************************************************************************************
    Solution #1
    Svar smallerThan9 = numbers.TakeWhile(n => n < 9);
    ************************************************************************************************************/

    /************************************************************************************************************
     Solution #2
     var skipSmallerThan5 = numbers.SkipWhile(n => n > 4);
     ************************************************************************************************************/
    #endregion ANSWERS
}

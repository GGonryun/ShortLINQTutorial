using System;
using System.Collections.Generic;
/* 
* 0. We must always import System.Linq!
*/
using System.Linq;

namespace ConsoleApp2
{
    class Filtering
    {
        DataStructures dataStructures = new DataStructures();
        public bool Test1()
        {
            /*
             * 1. LINQ Comes with two flavors, Lambda and Query Syntax
             *    Query Syntax is the one we'll use for this guide.
             *    For more information on Lambda Syntax visit: [1]
             */
            int[] numbers = dataStructures.Numbers;
            /*
             * 2. We can use var for our variables because the smart compiler
             *    will figure out the appropriate enumerable type to return.
             * Q: What are enumerables?
             * A:   It's something you can "enumerate" over, or iterate over,
             *      like pages in a book, cd albums on a rack, cars in a parking
             *      lot. Each of these "Collections" can be enumerated in some way.
             */
            var lowNums =
            /*
             * 3. We use keywords `from` and `in`. Much like we would a "foreach" loop.
             * Q: What's a foreach loop?
             * A:   Specialized syntax to enumerate over an enumerable. 
             * The `from` `in` keyword pair will select each value in the enumerable.
             * This statement follows the syntax [from _obj_ in _enumerable collection_].
             */
                from n in numbers
            /*
             * 4. Filtering: Where
             * The `where` keyword allows us to specify a "restriction" clause.
             * In English this says: "restrict the set to only those numbers `where` n < 5"
             * The restriction must always be a boolean expresion.
             * Q: Whats a Boolean Expression?
             * A:   Any expression that returns true or false, expressions are a logical grouping
             *      of operators and operands. Such as [5==5] or 
             *      [Box.CalculateVolume() < Container.SpaceLeft;]
             */
                where n < 5
            /* 5. Projection: Select
             * We'll get to this later! But for now know it is sufficient to know that the 
             * select clause determines what parts of our object we wish to return.
             */
                select n;
            /*
             * 6. I'll give you a free pass for this one. Here's the syntax again without the comments.
             */
            var lowerNums =
                from n in numbers
                where n < 3
                select n;
            //change this to true to pass.
            return false;
        }
        public bool Test2()
        {
            /* 
             * 7. Why isn't this working?
             */
            int[] numbers = dataStructures.Numbers;
            var lowerNums =
                from n in numbers
                // Place your solution below.
                where n > 3
                // Place your solution above.
                select n;
            return lowerNums.Contains(0) && lowerNums.Contains(1) && lowerNums.Contains(2);
        }

        public bool Test3()
        {
            /*
             * 8. Can you return a list of strings that contain "Potato"?
             * Tip: You'll want to iterate through the foods.
             */
            List<string> foods = dataStructures.Foods;

            var foodsCalledPotato =
            // Place your solution below.
                new List<string>();
            //Place your solution above.
            return foodsCalledPotato.Count() == 2;
        }
    }


    #region ANSWERS
    /************************************************************************************************************
     Solution #1
     return true;
     ************************************************************************************************************/

    /************************************************************************************************************
     Solution #2
     where n < 3
     ************************************************************************************************************/

    /************************************************************************************************************
     Solution #3:
     from f in foods
     where f.Contains("Potato")
     select f;
     *************************************************************************************************************/
    #endregion

}

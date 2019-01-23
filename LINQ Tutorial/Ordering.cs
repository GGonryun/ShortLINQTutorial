using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp2
{
    class Ordering
    {
        DataStructures dataStructures = new DataStructures();
        public void Lecture1()
        {
            int[] numbers = dataStructures.Numbers;
            /*
             * 1. Now I'm sure you're asking: "Well, is that all LINQ is for?
             * Just to make some janky sets?"
             * Weeeeeeeeeeeelll, there's more!
             * Any collection that implements the IComparable interface can be
             * sorted, or in our case "Ordered".
             * 
             */
            string[] words = { "cherry", "apple", "blueberry", "small boot", "approximately 2 pounds of rice", "Reese's Peanut Butter Cups(tm)" };
            var sortedWords =
                from word in words
                orderby word
                select word;

            Console.WriteLine("The sorted list of words");
            foreach (var word in sortedWords)
            {
                Console.WriteLine(word);
            }
            /*
             * 2. If you want to see the results of this class, just [add the line
             * "orderingTest.Lecture1();" to the main class in Program.cs and run]
             * 
             * 3. We can even combine filtering, and ordering as well!
             */
            var sortedWords2 =
                from word in words
                where word.Length > 6
                /*
                 * 4 The descending keyword allows us to reverse the order.
                 */
                orderby word.Length descending
                select word;
            Console.WriteLine("The sorted list of words by length (with length > 6):");
            foreach (var word in sortedWords2)
            {
                Console.WriteLine(word);
            }
            /*
             * 5. The condition can be almost anything, you can select the order of your
             * objects so long as the order makes sense. 
             * (You can't really sort integers by their Array Rank now can you?)
             */
        }

        public bool Test1()
        {
            /*
             * Test #1! Give me these values but in reverse sorted order!
             * dataStructures.Numbers = new int[] {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
             */
            int[] numbers = dataStructures.Numbers;
            var reverseSortedOrder =
            // Place your solution below.
                new int[]{ 0, 0, 0, 0, 0, 0 };
            // Place your solution above.
            return reverseSortedOrder.ElementAt(2).Equals(7);
        }

        public bool Test2()
        {
            /*
             * Test #2?
             * How about giving me a list of food in order?
             * Oh but, they've also gotta be longer than 5 letters please.
             * 
             * Tip: Access the first letter of a string by using word[0].
             */
            List<string> foods = dataStructures.Foods;

            var longFoodsInOrder =
            // Place your solution below.
            new List<string>();
            longFoodsInOrder.Add("Poo");
            longFoodsInOrder.Add("Poo");
            longFoodsInOrder.Add("Poo");
            longFoodsInOrder.Add("Poo");
            longFoodsInOrder.Add("Poo");
            longFoodsInOrder.Add("Poo");
            longFoodsInOrder.Add("Poo");
            longFoodsInOrder.Add("Poo");
            longFoodsInOrder.Add("Poo");
            longFoodsInOrder.Add("Poo");
            longFoodsInOrder.Add("Poo");
            longFoodsInOrder.Add("Poo");
            longFoodsInOrder.Add("Poo");
            longFoodsInOrder.Add("Poo");
            // Place your solution above.
            return !longFoodsInOrder.Contains("Poo") && longFoodsInOrder.ElementAt(2).Contains("Milk");
        }
        public bool Test3()
        {
            /*
             * Test #3
             * Okay now, can you get me all even numbers, but please skip the numbers larger than 5.
             * dataStructures.Numbers = new int[] {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
             * 
             * Tip: You'll want to first sort the numbers, then make a new variable using 
             * `var correctAnswer = ?` and use one the partitioning tools to return the correct
             * enumerable.
             */
            int[] numbers = dataStructures.Numbers;
            var evenNumbers =
            // Place your solution below.
            new int[] { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 };
            var correctAnswer = evenNumbers.Skip(4);
            // Place your solution above.
            return !correctAnswer.Contains(8) && !correctAnswer.Contains(1) && correctAnswer.Count() == 3;
        }
    }
    #region ANSWERS
    /************************************************************************************************************
    Solution #1:
        from number in numbers
        orderby number descending
        select number;
    ************************************************************************************************************/

    /************************************************************************************************************
     Solution #2
        from food in foods
        where food.Length > 5
        orderby food[0]
        select food;
     ************************************************************************************************************/

    /************************************************************************************************************
     Solution #3
        from number in numbers
        where number % 2 == 0
        orderby number
        select number;
        var correctAnswer = evenNumbers.TakeWhile(n => n < 6);
    ************************************************************************************************************/
    #endregion ANSWERS
}

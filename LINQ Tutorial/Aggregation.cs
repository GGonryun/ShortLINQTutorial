using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Aggregation
    {
        DataStructures dataStructures = new DataStructures();
        public void Lecture1()
        {
            /*
             * 1. Hello again!
             * Aggregation is a simple yet 😤 powerful 😤 tools.
             * The different aggregation keywords allow you to combine
             * your values together into one value in some way or form.
             * 
             * In our example we'll be using ints and floats and strings. But that doesn't mean
             * that this wouldn't work for more complex classes. I'm just too
             * lazy to set up proper demos for that right now. Plus this is a 101
             * kinda course sooooooooooooooooooooooo.
             * 
             * 2. You've got:
             * `Count`
             * `Sum`
             * `Min`
             * `Max`
             * `Average`
             * `Aggregate`
             */
            string[] words = { "cherry", "apple", "blueberry", "small boot", "approximately 2 pounds of rice", "Reese's Peanut Butter Cups(tm)" };
            int wordCount = words.Count();
            /*
             * 2. Much like the property `.Length`, this returns the total number of 
             * elements in the collection.
             * 
             * How is `.Count` aggregation? Well it takes in a collection and puts out
             * a single value which successfully aggregates some detail of our collection.
             *
             * In this case its the total number of values in our collection.
             */
            Console.WriteLine($"Total Words: {wordCount}.");
            /*
             * 3. Unlike `Length`, we can set special conditions for counting.
             * We can use lambda expressions to determine how we want to count values.
             */
            int wordCountLongerThan6 = words.Count(w => w.Length > 6);
            Console.WriteLine($"Total Words Longer Than 6 Characters: {wordCountLongerThan6}.");
            /*
             * 4. `Sum` will add up all the values in an array.
             * 
             * `.Sum` can also take an optional lambda expression.
             * 
             * This lambda expression can be used to convert non-number types into numbers.
             */
            int sumOfChars = words.Sum(w => w.Length);
            Console.WriteLine($"Total Sum of All Characters In Words List: {sumOfChars}.");
            /*
             * 5. `Min` & `Max` & `Average`:
             * `Min` returns the smallest value in the collection and takes an 
             * optional lambda expression to convert non-number types into numbers.
             * `Max` is the same, but returns the largest value in the collection.
             * `Average` will return the mean of the numbers, it'll add them all up
             * and divide it by total number of values in the collection.
             */
            int[] numbers = dataStructures.Numbers;
            int smallestNumber = numbers.Min();
            int largestNumber = numbers.Max();
            double averageNumber = numbers.Average();
            Console.WriteLine($"Smallest Number: {smallestNumber}, LargestNumber: {largestNumber}, AverageNumber: {averageNumber}. ");
        }

        public bool Test1()
        {
            /*
             * No tests required.
             */
            return false;
        }

    }
    #region ANSWERS
    /************************************************************************************************************
    Solution #1:
        ( ͡° ͜ʖ ͡°)
    ************************************************************************************************************/

    #endregion ANSWERS
}

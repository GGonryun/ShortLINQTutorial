using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp2
{
    class Projection
    {
        DataStructures dataStructures = new DataStructures();
        public void Lecture1()
        {
            int[] numbers = dataStructures.Numbers;
            List<Product> products = dataStructures.Products;
            /*
             * 1. Selection:
             * Selection also known as "Projection", the keyword `select` as we have seen 
             * previously allows us to make changes to the values that meet our criteria
             * or refine the selection further.
             * 
             * Conceptually our goal should be to [filter objects => select a field], much
             * similar to how we would query in SQL.
             */
            var allNumbersPlusOne =
                from n in numbers
                select n + 1;
            /* 
             * 2. The above example will grab all numbers and then increment them by 1.
             * But this whole time we've been working with simple objects.
             * The true power comes from our ability to select fields of our own custom objects.
             * Even anonymous types! (But we'll save that for another tutorial.)
             */
            var productNames =
             from p in products
             select p.ProductName;
            
            /*
             * 3. In this example we've selected all of the names of our products class!
             * You can find more details about the products class in the [DataStructures.cs]
             * file.
             */
        }

        public bool Test1()
        {
            /* 4. Solve this puzzle!
             * We need to double all the values of our numbers.
             */
            int[] numbers = dataStructures.Numbers;
            var doubleNumber =
                // Place your solution below.
                new int[0];
                // Place your solution above.
            return doubleNumber.Contains(14);
        }

        public bool Test2()
        {
            /* 5. Now lets try to select all the names of all our products in the list.
             * 
             * Tip: Don't know what the variables are? Open the [DataStructures.cs] file
             * using the Solution Explorer. Inside this folder find "public class Product"
             * inside the region API we can find fields available to us.
             * 
             * Q: What's an API?
             * A:   An API stands for [A]pplication [P]rogram [I]nterface. Conceptually, these
             *      are the fields and methods available for us to access. These fields will
             *      describe how our object interacts with the outside world.
             *      
             *      Abstraction: When you want to use a toaster, you don't really care how it
             *      converts electricity to heat, or how to carefully contain the heat so that 
             *      your food is the right temperature. Instead you use the small knob or button's
             *      available. These describe how you interact with the object, 
             *      
             *      the rest is just 🔥😩🔥 fucking magic 🔥😩🔥.
             */
            List<Product> products = dataStructures.Products;
            var productNames =
                // Place your solution below.
                new List<string>();
                // Place your solution above.
            return productNames.Contains("Alice Mutton");
        }

        public bool Test3()
        {
            /*
             * 6. Next Puzzle!
             * Select only the letters "a", "b", and "c" but use numbers!
             * 
             * Tip: You'll want to use the `where` keyword for this one.
             * Tip2: Use the numbers array to select the correct values.
             */

            string[] words = new string[]{ "a", "b", "c", "d", "e", "f"};
            int[] numbers = dataStructures.Numbers;

            var correctWords =
                // Place your solution below.
                new string[0];
                // Place your solution above.
            return correctWords.Count() == 3 && correctWords.Contains("b") ;
        }

        public bool Test4()
        {
            return false;
        }
    }

    #region ANSWERS
    /************************************************************************************************************
     Solution #1
     from n in numbers
     select n * 2;
     ************************************************************************************************************/

    /************************************************************************************************************
     Solution #2
     from product in products
     select product.ProductName;
     ************************************************************************************************************/

    /************************************************************************************************************
     Solution #3:
     from n in numbers
     where n < 3
     select words[n];
     *************************************************************************************************************/
    #endregion
}

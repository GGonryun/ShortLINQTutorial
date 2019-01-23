using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp2
{
    class Quantifiers
    {
        DataStructures dataStructures = new DataStructures();
        public void Lecture1()
        {
            /*
             * 1. Congrats!
             * Some of the 🔥 best 🔥 features are still coming up!
             * 
             * We can use quantifiers in order to determine whether or not
             * a term exists within the scope of that enumerable.
             * 
             * We have 2 keywords `any` and `all`
             */
            string[] words = { "cherry", "apple", "blueberry", "small boot", "approximately 2 pounds of rice", "Reese's Peanut Butter Cups(tm)" };
            bool doesTheWordsArrayContainTM = words.Any(w => w.Contains("tm"));
            /*
             * 2. In fact, you can select words using almost any condition so long as
             * it is a lambda expression that returns a boolean value.
             * 
             * ex: words.Any(w => w.Length > 10);
             * ex: words.Any(w => w[0] > (char)13 ? w.Length > 8 : w.Length == 5);
             * 
             * 3. In plain english the question you're asking is:
             */
            Console.WriteLine($"In the `words` enumerable, is there any word that contains the substring 'tm'? {doesTheWordsArrayContainTM} ");
            /*
             * 4. When using the `all` keyword, we instead ask whether or not
             * ALL values fit our criteria. Unlike before the question we ask now is
             */
            bool areAllWordsLongerThan4 = words.All(w => w.Length > 4);
             /*
              * 5. Conceptually what happens in our full expression above is that
              * we are grabbing the words array, and then passing its individual
              * values into the lambda expression. The Lambda Expression then takes
              * this word and returns true if w.Length > 4.
              * 
              * The question we then ask is:
              * "In the `words` enumerable, are all the words greater than length 4?"
              */
            Console.WriteLine($"In the `words` enumerable, are all the words greater than length 4? { areAllWordsLongerThan4 } ");
        }

        public bool Test1()
        {
            /*
             * Test #1! 
             * Someone said that our menu may have poo in it.
             * 
             * Can you check if the menu list contains any Poo?
             */
            List<string> menuOfFood = dataStructures.Foods;
            bool hasPoo =
            // Place your solution below.
            false;
            // Place your solution above.
            return hasPoo;
        }

        public bool Test2()
        {
            /*
             * Test #2?
             * I'll give you a freebee. 
             * You're probably getting bored by now.
             * I know because I am. 😫
             * 
             * Change this to true.
             * How about that?
             */
            return false;
        }
    }
    #region ANSWERS
    /************************************************************************************************************
    Solution #1:
        menuOfFood.Any(w => w.Contains("Poo"));
    ************************************************************************************************************/

    /************************************************************************************************************
     Solution #2
        Seriously? You needed help? 🤦
     ************************************************************************************************************/
    #endregion ANSWERS
}

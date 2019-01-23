using System;

namespace ConsoleApp2
{
    class Program
    {
        /*
         * Before you begin, I would like to say thank you.
         * 
         * If anything isn't clear enough, note it and I will adjust this guide according to your feedback.
         * 
         * Instructions within brackets [] are atomic actions, these should be performed in that specific sequence
         * without interruption. 
         * 
         * The `=>` means "and then".
         * 
         * For Example:
         * To highlight groups of text first you [Highlight Text => Press Ctrl + K => Press C] 
         * 
         * You can also expect to find additional sources at the end of this file. 
         * This short sequence is to familiarize yourself with the structure of LINQ and it's basic functions.
         */
        static void Main(string[] args)
        {

            /* 
             * What is LINQ?
             * [L]anguage [IN]tegrated [Q]uery! It is a part of our programming language syntax, in fact it is a programming 
             * language syntax for querying in-memory data.
             * Why use LINQ?
             * Remember OS class? When we're Querying objects we typically have to access data structures outside of our memory, 
             * these calls are slow and require the use of external tools in order to access our data (SQL). LINQ allows us
             * to bring these data structures into our program, put them in memory, and execute our searches on in-memory
             * objects. 
             * Objects you say? 
             * That's right ladies and gentlement, ~Objects~. Most traditional data is stored much like an object. Orders have 
             * customers, and an SQL Query would probably model it similarly (We'll use the order as a key and then grab a 
             * customers object). But this can strain our mental model, wouldn't it be easier if we could just Query objects that
             * already exist as part of our Requirements Vocabulary? 
             * <start bold>
             * LINQ CAN DO IT.
             * <end bold>
             * 
             * To start the sequence, take a look at the code below. It'll tell you where to find the tests. 
             * Take a look at the Solution Explorer, (typically its to your right but if you can't find it use: 
             * [CTRL + W, S] or [go to the tool bar above and select View => Solution Explorer].
             * In the solution explorer we have various files. They contain the tests for you to fix.
             */

            Filtering filteringTests = new Filtering();
            Console.WriteLine($"Filtering Test #1:\n\tResults:{(filteringTests.Test1() ? "Success" : "Failed")}");
            Console.WriteLine($"Filtering Test #2:\n\tResults:{(filteringTests.Test2() ? "Success" : "Failed")}");
            Console.WriteLine($"Filtering Test #3:\n\tResults:{(filteringTests.Test3() ? "Success" : "Failed")}");
            Projection projectionTests = new Projection();
            Console.WriteLine($"Projection Test #1:\n\tResults:{(projectionTests.Test1() ? "Success" : "Failed")}");
            Console.WriteLine($"Projection Test #2:\n\tResults:{(projectionTests.Test2() ? "Success" : "Failed")}");
            Console.WriteLine($"Projection Test #3:\n\tResults:{(projectionTests.Test3() ? "Success" : "Failed")}");
            Partitioning partitioningTests = new Partitioning();
            Console.WriteLine($"Partitioning Test #1:\n\tResults:{(partitioningTests.Test1() ? "Success" : "Failed")}");
            Console.WriteLine($"Partitioning Test #2:\n\tResults:{(partitioningTests.Test2() ? "Success" : "Failed")}");
            Aggregation aggregationTests = new Aggregation();
            Console.WriteLine($"Aggregation Test #1:\n\tResults:{(aggregationTests.Test1() ? "Success" : "Failed")}");
            Ordering orderingTests = new Ordering();
            Console.WriteLine($"Ordering Test #1:\n\tResults:{(orderingTests.Test1() ? "Success" : "Failed")}");
            Console.WriteLine($"Ordering Test #2:\n\tResults:{(orderingTests.Test2() ? "Success" : "Failed")}");
            Console.WriteLine($"Ordering Test #3:\n\tResults:{(orderingTests.Test3() ? "Success" : "Failed")}");
            Quantifiers quantifiersTests = new Quantifiers();
            Console.WriteLine($"Quantifiers Test #1:\n\tResults:{(quantifiersTests.Test1() ? "Success" : "Failed")}");
            Console.WriteLine($"Quantifiers Test #2:\n\tResults:{(quantifiersTests.Test2() ? "Success" : "Failed")}");


        }
    }
    /* BIBLIOGRAPHY:
     * [1]:  https://www.tutorialspoint.com/linq/linq_lambda_expressions.htm
     */
}

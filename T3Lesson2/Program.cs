using System;
using System.Collections.Generic;

namespace T3Lesson2
{
    class Program
    {
        /// <summary>
        /// Today's class is going over
        /// - If, else if, and else statements
        /// - Loops
        ///     -- for
        ///     -- foreach
        ///     -- ForEach on List<string>
        ///     -- while
        ///     -- do while
        /// </summary>
        static void Main(string[] args)
        {
            // This is how to do an if statement
            int x = 10;
            int y = 5;
            if (x < 1)
            {
                Console.WriteLine("Hello world!");
                Console.WriteLine("Good-bye");
            }
            else if (y <= 5)
            {
                Console.WriteLine("Y is less than 5");
            }
            else
            {
                Console.WriteLine("Everything was false");
            }


            // for loop -- increment
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            // for loop -- decrement
            for (int r = 5; r > 0; r--)
                Console.WriteLine(r);

            // foreach #1
            List<string> foodItems = new List<string>() { "burger", "hotdog", "fries", "fried pickles", "nachos" };
            foreach (string s in foodItems)
            {
                Console.WriteLine(s);
            }

            // Brad's foreach
            List<string> Sports = new List<string>() { "football", "Basketball", "Swimming", "Baseball", "Hockey" };
            foreach (string s in Sports)
            {
                Console.WriteLine(s);
            }

            // List's built-in ForEach
            Sports.ForEach(s => Console.WriteLine(s));


            // while
            bool stop = false;
            int a = 5;

            while (!stop)
            {
                Console.WriteLine("Stop is false");
                a--;

                if (a < 1)
                    stop = true;

                if (stop)
                    Console.WriteLine("Stopping");
            }

            // do while
            bool go = false;
            int counter = 0;

            do
            {
                if(go)
                    Console.WriteLine("Go is true");

                counter++;

                if (counter > 3)
                    go = false;

                if (!go)
                    Console.WriteLine("Go is false");
            } while (go);
        }
    }
}

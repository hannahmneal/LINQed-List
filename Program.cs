using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                INSTRUCTIONS:
                Given the collections of items shown below, use LINQ to build the requested collection, and then Console.WriteLine() each item in that resulting collection.
             */

             /*
                RESTRICTION/FILTERING OPERATIONS
                Find the words in the collection that start with the letter 'L'

                - Translation: find the items that meet a condition
                    - "where" creates a new collection of items that meet a condition
              */

        List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

        // fruits.Where(fruit => fruit[0] = 'L');
        // fruits.GroupBy(fruit => fruit[0] = 'L');

        IEnumerable<string> LFruits = (from fruit in fruits
            where fruit.StartsWith("L")
            select fruit
        ).ToList();

        foreach(string f in LFruits) {
            Console.WriteLine($"All the L fruits:{f}");
        }

        }
    }
}





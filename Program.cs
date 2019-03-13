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

            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            // fruits.Where(fruit => fruit[0] = 'L');
            // fruits.GroupBy(fruit => fruit[0] = 'L');

            IEnumerable<string> LFruits = (from fruit in fruits
                                           where fruit.StartsWith("L")
                                           select fruit
            ).ToList();

            foreach (string f in LFruits)
            {
                Console.WriteLine($"All the L fruits:{f}");
            }

            /*
                ORDERING OPERATIONS
                Order the student names alphabetically, in descending order (Z-A)
             */

            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            /*
                OrderBy() sorts the elements in the source sequence based on a key value. The key for an element is calculated by a keySelector delegate method passed into the OrderBy() call.

                If you want to sort the elements within a sequence, then you will need to pass in an identity keySelector method that indicates that each element in the sequence is, itself, a key.
             */

            // How to use this way (below)??
            //  IEnumerable<string> descend = names.OrderBy(name => name);

            List<string> descend = (from name in names
                orderby name descending
                select name
            ).ToList();

            foreach (string n in descend) {
                Console.WriteLine($"Names in descending order: {n}");
            }

            // Build a collection of these numbers sorted in ascending order
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            List<int> sortedNums = (from num in numbers
            orderby num ascending
            select num
            ).ToList();

            foreach(int num in sortedNums) {
                Console.WriteLine($"Numbers in ascending order: {num}");
            }

        }
    }
}





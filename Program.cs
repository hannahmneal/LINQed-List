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


            /*
                AGGREGATE OPERATIONS
             */


             // Output how many numbers are in this list
            List<int> aggregateNums = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            Console.WriteLine($"Number of numbers in aggregateNums: {aggregateNums.Count()}");
            // logs 14

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };

            Console.WriteLine($"Total of purchases: {purchases.Sum()}");

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            Console.WriteLine($"Most expensive product: {prices.Max()}");


            /*
                PARTITIONING OPERATIONS
             */


            /*
            Store each number in the following List until a perfect square
                is detected.

            Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */

            List<double> wheresSquaredo = new List<double>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14, 16
            };

            foreach(double square in wheresSquaredo) {
                if(Math.Sqrt(square) % 1 == 0) {
                    Console.WriteLine($"This are the perfect squares: {square}");
                }
            }


            /*
                USING CUSTOM TYPES:
             */


            List<Customer> customers = new List<Customer>() {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };

            

            // foreach(Customer customer in customers) {

            // }
        }



    }
}





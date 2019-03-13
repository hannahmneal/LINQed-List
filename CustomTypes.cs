/*
    USING CUSTOM TYPES

    Given the same customer set, display how many millionaires per bank.
    Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

    Example Output:
    WF 2
    BOA 1
    FTB 1
    CITI 1

 */

namespace LINQ_Exercise {

    // Build a collection of customers who are millionaires
    using System.Collections.Generic;

    public class Customer
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Bank { get; set; }
        public List<string> Millionaires {get; set;}
    }

}

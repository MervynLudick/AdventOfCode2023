using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public static class _1_2
    {
        public static int Calculate()
        {
            var sum = 0;

            string[] lines = File.ReadAllLines("C:\\Devops\\Repos\\AdventOfCode\\AdventOfCode\\Inputs\\1.txt");

            var options = new List<string> 
            { 
                "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
                "1", "2", "3", "4", "5", "6", "7", "8", "9" 
            };

            foreach (var line in lines)
            {
                var dictionary = new SortedDictionary<int, string>
                {
                    { -1, "" } //for not found values will be removed
                };

                
                foreach (var word in options)
                {
                    dictionary[line.IndexOf(word)] = word;
                    dictionary[line.LastIndexOf(word)] = word;
                }

                dictionary.Remove(-1);

                var first = dictionary.First().Value;

                if (first.Length > 1)
                {
                    var indexOfFirst = options.IndexOf(first);
                    first = options[indexOfFirst + 9];
                }

                var last = dictionary.Last().Value;

                if (last.Length > 1)
                {
                    var indexOfLast = options.LastIndexOf(last);
                    last = options[indexOfLast + 9];
                }

                sum += int.Parse(first + last);
            }

            return sum;
        }
    }
}

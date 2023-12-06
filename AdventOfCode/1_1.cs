using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public static class _1_1
    {
        public static int Calculate()
        {
            string[] lines = File.ReadAllLines("C:\\Devops\\Repos\\AdventOfCode\\AdventOfCode\\Inputs\\1.txt");

            var sum = 0;

            foreach (var line in lines)
            {
                char first = line.First(x => char.IsDigit(x));
                char last = line.Last(x => char.IsDigit(x));
                sum += int.Parse(first.ToString() + last.ToString());
            }

            return sum;
        }
    }
}

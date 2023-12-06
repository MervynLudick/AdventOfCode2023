using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class _5_1
    {
        public static void Calculate()
        {
            var path = new LinkedList<int>();

            var lines = File.ReadLines("C:\\Devops\\Repos\\AdventOfCode\\AdventOfCode\\Inputs\\4.txt").ToList();

            var seeds = lines[0].Split(':')[1].Split(' ').Where(x => string.IsNullOrWhiteSpace(x)).ToList();

            var seedsHashSet = new HashSet<int>();

            foreach (var seed in seeds)
            {
                seedsHashSet.Add(int.Parse(seed));
            }
            
            for (int  i = 0; i < lines.Count;)
            {
                if (lines[i] == "seed-to-soil map:") 
                {
                    while (true)
                    {
                        if (lines[i] == "") break;
                        var test = lines[i].Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
                    }
                }
            }
        }

        
    }
}

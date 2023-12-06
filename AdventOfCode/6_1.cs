using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class _6_1
    {
        public static int Calculate()
        {
            var lines = File.ReadAllLines("C:\\Devops\\Repos\\AdventOfCode\\AdventOfCode\\Inputs\\6.txt");

            var times = lines[0].Split(':')[1].Split(" ").Where(x => !string.IsNullOrWhiteSpace(x)).ToList();

            var distances = lines[1].Split(':')[1].Split(" ").Where(x => !string.IsNullOrWhiteSpace(x)).ToList();

            var product = 1;

            for (int i = 0; i < times.Count; i++)
            {
                var numberOfWays = 0;
                var recordDistance = int.Parse(distances[i]);

                for (int j = 0; j < int.Parse(times[i]); j++) 
                {
                    var distance = j * (int.Parse(times[i]) - j);

                    if (distance > recordDistance)
                    {
                        numberOfWays++;
                    }
                }

                product *= numberOfWays;
            }

            return product;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{

    public class _6_2
    {
        public static long Calculate()
        {
            var lines = File.ReadAllLines("C:\\Devops\\Repos\\AdventOfCode\\AdventOfCode\\Inputs\\6.txt");

            var time = long.Parse(lines[0].Split(':')[1].Replace(" ", ""));

            var recordDistance = long.Parse(lines[1].Split(':')[1].Replace(" ", ""));

            var product = 1;

            var numberOfWays = 0;

            for (int j = 0; j < time; j++)
            {
                var distance = j * (time - j);

                if (distance > recordDistance)
                {
                    numberOfWays++;
                }
            }

            return numberOfWays;

        }
    }
    
}

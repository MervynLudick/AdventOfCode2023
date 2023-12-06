using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public static class _2_1
    {
        public static int Calculate()
        {
            var items = File.ReadLines("C:\\Devops\\Repos\\AdventOfCode\\AdventOfCode\\Inputs\\3.txt");

            var counter = 1;

            var sum = 0;

            var games = new List<Game>();

            foreach(var item in items)
            {
                var thing = item.Split(':')[1].Split(';');

                var blueCount = 0;
                var redCount = 0;
                var greenCount = 0;

                var shouldAdd = true;

                foreach(string thingName in thing)
                {
                    var colours = thingName.Trim().Split(',');

                    redCount = 0;
                    blueCount = 0;
                    greenCount = 0;

                    foreach (var colour in colours)
                    {
                        var test = colour.Trim().Split(' ');

                        if (test[1] == "blue")
                        {
                            blueCount += int.Parse(test[0]);
                        }
                        if (test[1] == "green")
                        {
                            greenCount += int.Parse(test[0]);
                        }

                        if (test[1] == "red")
                        {
                            redCount += int.Parse(test[0]);
                        }
                    }

                    if (12 - redCount < 0)
                    {
                        shouldAdd = false;
                    }

                    if (14 - blueCount < 0)
                    {
                        shouldAdd=false;
                    }

                    if (13 - greenCount < 0)
                    {
                        shouldAdd = false;
                    }
                }
                if (shouldAdd)
                {
                    sum += counter;
                }

                counter++;
            }

            return sum;
        }
    }


    public class Game
    {
        public int Id { get; set; }
        public int Blue { get; set; }
        public int Red { get; set; }
        public int Green { get; set; }
    }
}

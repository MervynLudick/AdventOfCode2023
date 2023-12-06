using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public static class _3_2
    {
        public static void Test()
        {
            string[] lines = File.ReadAllLines("C:\\Devops\\Repos\\AdventOfCode\\AdventOfCode\\Inputs\\4.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    if (char.IsNumber(lines[i][j]))
                    {
                        
                    }
                }
            }
        }

        public static List<Point> GetPointOfGears()
        {
            string[] lines = File.ReadAllLines("C:\\Devops\\Repos\\AdventOfCode\\AdventOfCode\\Inputs\\4.txt");

            var symbols = new List<Point>();

            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    if (lines[i][j] == '*')
                    {
                        symbols.Add(new Point(i, j));
                    }
                }
            }
            return symbols;
        }

        public static List<Point> GetNumberPoints()
        {
            string[] lines = File.ReadAllLines("C:\\Devops\\Repos\\AdventOfCode\\AdventOfCode\\Inputs\\4.txt");

            var numbers = new List<NumberPoint>();

            var symbols = new List<Point>();

            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length;)
                {
                    if (char.IsNumber(lines[i][j]))
                    {
                        var start = new Point(i, j);

                        while (char.IsNumber(lines[i][j])) 
                        {
                            j++;
                            if (j == lines.Length) break;
                        }
                        var end = new Point(i, j - 1);

                        numbers.Add(new NumberPoint
                        {
                            Start = start,
                            End = end
                        });
                    }
                    else
                    {
                        j++;
                    }
                }
            }
            return symbols;
        }

    }

    public class NumberPoint
    {
        public Point Start { get; set; }
        public Point End { get; set; }
    }
}

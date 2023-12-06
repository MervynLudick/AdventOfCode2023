using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public static class _3_1
    {
        public static int Tester()
        {
            string[] lines = File.ReadAllLines("C:\\Devops\\Repos\\AdventOfCode\\AdventOfCode\\Inputs\\4.txt");

            var start = new Point(0,0,0);
            var end = new Point(0,0,0);
            var points = GetIndexOfSymbols();

            var sum = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length;)
                {
                    if (char.IsDigit(lines[i][j]))
                    {
                        start = new Point(i, j);
                        while (char.IsLetterOrDigit(lines[i][j]) )
                        {
                            j++;

                            if (j == 140)
                            {
                                break;
                            }
                        }
                        end = new Point(i, j-1);

                        var isTrue = false;

                        foreach(var point in points)
                        {
                            if (start.Y - 1 == point.Y && start.X == point.X)
                            {
                                isTrue = true;
                                break;
                            }

                            if (end.Y + 1 == point.Y && start.X == point.X)
                            {
                                isTrue = true;
                                break;
                            }

                            for (int y =  start.Y - 1; y <= end.Y + 1; y ++)
                            {
                                if (point.X == start.X - 1 || point.X == start.X + 1)
                                {
                                    if (point.Y == y)
                                    {
                                        isTrue = true;
                                        break;
                                    }
                                }
                            }

                            if (isTrue) break;
                        }

                        if (isTrue)
                        {
                            var number = int.Parse(lines[start.X].Substring(start.Y, end.Y - start.Y + 1));

                            sum += number;
                        }


                    }
                    else
                    {
                        j++;
                    }
                }
            }

            return sum;
        }

        public static List<Point> GetIndexOfSymbols()
        {
            string[] lines = File.ReadAllLines("C:\\Devops\\Repos\\AdventOfCode\\AdventOfCode\\Inputs\\4.txt");

            var symbols = new List<Point>();

            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    if (!char.IsLetterOrDigit(lines[i][j])  && lines[i][j] != '.')
                    {
                        symbols.Add(new Point(i, j));
                    }
                }
            }

            return symbols;
        }
    }

    public class Point
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point(int x, int y, int id)
        {
            X = x;
            Y = y;
            Id = id;
        }
    }
}
